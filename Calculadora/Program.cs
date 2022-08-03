using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // se uma operação como divisão resultar em erro o valor padrão é um NaN.

            // Usar um switch para fazer a conta
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Pedir para o usuário inserir um divisor diferente de zero.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Retornar texto para uma uma opção de entrada incorreta
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Exibe o título do App Calculadora no C# Console.
            Console.WriteLine("Calculadora em C# Console\r");
            Console.WriteLine("-------------------------\r");

            while (!endApp)
            {
                // Declarar variáveis e setar caso vazio
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Pedir ao usuário para inserir o primeiro numero.
                Console.Write("Digite um número e pressione Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Este valor não é válido. Por favor insira um número inteiro: ");
                    numInput1 = Console.ReadLine();
                }


                // Pedir ao usuário para inserir o segundo numero.
                Console.Write("Digite outro numero e precione Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Este valor não é válido. Por favor insira um número inteiro: ");
                    numInput2 = Console.ReadLine();
                }

                // Pedir ao usuário para selecionar o operador
                Console.WriteLine("Selecione um operador conforme a lista abaixo:");
                Console.WriteLine("\ta - Adicionar");
                Console.WriteLine("\ts - Subtrair");
                Console.WriteLine("\tm - Multiplicar");
                Console.WriteLine("\td - Dividir");
                Console.Write("Sua opção? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("O resultado dessa operação é um erro matemático. \n");
                    }
                    else Console.WriteLine("Seu resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh não! Ocorreu uma excessão ao tentar fazer as contas.\n - Details: " + e.Message);
                }

                Console.WriteLine("----------------------------------\n");

                // Aguardar o usuário responder antes de fechar.
                Console.Write("Precione 'n' e Enter para fechar a aplicação, ou precione qualquer outra tecla e Enter para continuar calculando: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}