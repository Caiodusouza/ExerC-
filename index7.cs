using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor do seu salário (em R$):");
        double salario = double.Parse(Console.ReadLine());

        double imposto;

        // Determina a faixa de imposto
        if (salario <= 1500.00)
        {
            imposto = salario * 0.05; // 5% de imposto
        }
        else if (salario <= 3000.00)
        {
            imposto = salario * 0.10; // 10% de imposto
        }
        else
        {
            imposto = salario * 0.15; // 15% de imposto
        }

        Console.WriteLine($"\nSeu salário: R${salario:F2}");
        Console.WriteLine($"Imposto calculado: R${imposto:F2}");
    }
}
