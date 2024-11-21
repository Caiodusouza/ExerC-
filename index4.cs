using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("1 - Exibir 'Olá, Mundo!'");
            Console.WriteLine("2 - Exibir 'Bem-vindo ao C#'");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nOlá, Mundo!");
                    break;
                case 2:
                    Console.WriteLine("\nBem-vindo ao C#!");
                    break;
                case 3:
                    Console.WriteLine("\nSaindo do programa...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção entre 1 e 3.");
                    break;
            }
        } while (opcao != 3); // Repete o menu até que a opção "Sair" seja escolhida.
    }
}
