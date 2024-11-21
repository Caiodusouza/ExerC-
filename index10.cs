using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Fatorial");
        Console.WriteLine("Digite um número inteiro não negativo:");

        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case < 0:
                Console.WriteLine("\nErro: O número deve ser não negativo.");
                break;

            case 0:
                Console.WriteLine("\nO fatorial de 0 é 1.");
                break;

            default:
                Console.WriteLine($"\nO fatorial de {numero} é {CalcularFatorial(numero)}.");
                break;
        }
    }

    static long CalcularFatorial(int n)
    {
        long fatorial = 1;
        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }
}
