using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o operador (+, -, *, /):");
        char operador = Console.ReadLine()[0];

        double resultado;

        switch (operador)
        {
            case '+':
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                break;

            case '-':
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                break;

            case '*':
                resultado = numero1 * numero2;
 
