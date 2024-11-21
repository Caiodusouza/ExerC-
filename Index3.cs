using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a idade:");
        int idade = int.Parse(Console.ReadLine());

        // Determinando a classificação como categoria numérica
        int categoria = idade switch
        {
            >= 0 and <= 12 => 1,
            >= 13 and <= 17 => 2,
            >= 18 and <= 59 => 3,
            >= 60 => 4,
            _ => 0 // Para idades inválidas
        };

        // Classificação com switch
        switch (categoria)
        {
            case 1:
                Console.WriteLine("Classificação: Criança");
                break;
            case 2:
                Console.WriteLine("Classificação: Adolescente");
                break;
            case 3:
                Console.WriteLine("Classificação: Adulto");
                break;
            case 4:
                Console.WriteLine("Classificação: Idoso");
                break;
            default:
                Console.WriteLine("Idade inválida. Por favor, digite uma idade válida.");
                break;
        }
    }
}
