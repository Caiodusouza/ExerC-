using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a nota do aluno (de 0 a 10):");
        double nota = double.Parse(Console.ReadLine());

        // Determinar a classificação
        int categoria = nota switch
        {
            >= 9 and <= 10 => 1, // Nota A
            >= 7 and < 9 => 2,   // Nota B
            >= 5 and < 7 => 3,   // Nota C
            >= 3 and < 5 => 4,   // Nota D
            >= 0 and < 3 => 5,   // Nota F
            _ => 0               // Nota inválida
        };

        // Exibir classificação usando switch
        switch (categoria)
        {
            case 1:
                Console.WriteLine("Classificação: A");
                break;
            case 2:
                Console.WriteLine("Classificação: B");
                break;
            case 3:
                Console.WriteLine("Classificação: C");
                break;
            case 4:
                Console.WriteLine("Classificação: D");
                break;
            case 5:
                Console.WriteLine("Classificação: F");
                break;
            default:
                Console.WriteLine("Nota inválida. Insira um valor entre 0 e 10.");
                break;
        }
    }
}
