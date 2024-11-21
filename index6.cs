using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma bebida pelo número:");
        Console.WriteLine("1 - Café");
        Console.WriteLine("2 - Chá");
        Console.WriteLine("3 - Suco");
        Console.WriteLine("4 - Refrigerante");
        Console.Write("Digite sua escolha: ");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("\nVocê escolheu: Café.");
                break;
            case 2:
                Console.WriteLine("\nVocê escolheu: Chá.");
                break;
            case 3:
                Console.WriteLine("\nVocê escolheu: Suco.");
                break;
            case 4:
                Console.WriteLine("\nVocê escolheu: Refrigerante.");
                break;
            default:
                Console.WriteLine("\nOpção inválida. Por favor, escolha um número de 1 a 4.");
                break;
        }
    }
}
