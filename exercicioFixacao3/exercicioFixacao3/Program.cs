using System;
using System.Globalization;

namespace exercicioFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            double media;

            Console.WriteLine("Insira nome e salário do primeiro funcionário:");
            x.Nome = Console.ReadLine();
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira nome e salário do segundo funcionário:");
            y.Nome = Console.ReadLine();
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (x.Salario + y.Salario) / 2;

            Console.WriteLine();
            Console.WriteLine("O salário médio= " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
