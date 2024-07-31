using System;

namespace exercioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Informe o nome e a idade da pessoa x: ");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Informe o nome e a idade da pessoa y: ");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (x.Idade > y.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + x.Nome);
            } else
            {
                Console.WriteLine("Pessoa mais velha: " + y.Nome);
            }
            
        }
    }
}
