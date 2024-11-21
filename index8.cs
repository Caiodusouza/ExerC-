using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Conversor de Temperatura");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.Write("Digite sua escolha: ");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.Write("\nDigite a temperatura em Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}°F");
                break;

            case 2:
                Console.Write("\nDigite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine());
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Temperatura em Celsius: {celsius:F2}°C");
                break;

            default:
                Console.WriteLine("\nOpção inválida. Por favor, escolha 1 ou 2.");
                break;
        }
    }
}
