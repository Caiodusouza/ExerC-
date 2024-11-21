using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Classificação de Filme");
        Console.WriteLine("Escolha uma classificação:");
        Console.WriteLine("1 - G (Livre)");
        Console.WriteLine("2 - PG (Maior de 10 anos)");
        Console.WriteLine("3 - PG-13 (Maior de 13 anos)");
        Console.WriteLine("4 - R (Maior de 18 anos)");
        Console.Write("Digite sua escolha: ");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("\nClassificação: G (Livre). Qualquer idade pode assistir.");
                break;
            case 2:
                Console.WriteLine("\nClassificação: PG. Recomendado para maiores de 10 anos.");
                break;
            case 3:
                Console.WriteLine("\nClassificação: PG-13. Permitido para maiores de 13 anos.");
                break;
            case 4:
                Console.WriteLine("\nClassificação: R. Permitido para maiores de 18 anos.");
                break;
            default:
                Console.WriteLine("\nOpção inválida. Escolha um número de 1 a 4.");
                break;
        }
    }
}
