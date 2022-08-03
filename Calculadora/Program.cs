// Declarar variáveis que comecem com valor 0
double num1 = 0; double num2 = 0;

// Mostrar um título no C# console.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\r");

// Pedir ao usuário para inserir o primeiro numero.
Console.WriteLine("Insira um número e precione Enter");
num1 = Convert.ToDouble(Console.ReadLine());

// Pedir ao usuário para inserir o segundo numero.
Console.WriteLine("Insira outro número e precione Enter");
num2 = Convert.ToDouble(Console.ReadLine());

// Pedir ao usuário para escolher uma opção
Console.WriteLine("Selecione uma opção da lista abaixo:");
Console.WriteLine("\ta - Adicionar");
Console.WriteLine("\ts - Subtrair");
Console.WriteLine("\tm - Multiplicar");
Console.WriteLine("\td - Dividir");
Console.Write("Sua opção? ");

// Use uma instrução de troca para fazer a conta
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Seu resultado: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Seu resultado: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Seu resultado: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        // Ficar pedindo para o usuário inserir um número diferente de zero até que ele o faça
        while (num2 == 0)
        {
            Console.WriteLine("Digite um divisor diferente de zero");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Seu resultado: {num1} / {num2} = " + (num1 / num2));
        break;
}

//Espere a resposta do usuário antes de fechar.
Console.Write("Precione uma tecla para fechar o App Calculadora...");
Console.ReadKey();