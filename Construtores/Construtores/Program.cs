using System;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            string titular;
            int conta;
            double quantia;
            
            Console.Write("Entre com o número da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            titular = Console.ReadLine();

            ContaBancaria Cliente = new ContaBancaria(titular, conta);

            Console.Write("Entre com o valor do depósito inicial: ");
            quantia = double.Parse(Console.ReadLine());
            Cliente.Deposito(quantia);
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(Cliente);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine());
            Cliente.Deposito(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(Cliente);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            Cliente.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(Cliente);
           
        }
    }
}
