using System;
using System.Globalization;

namespace Construtores
{
    class ContaBancaria
    {
        public string Nome;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        
        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: " + Conta
                + ", Titular: " + Nome
                + ", R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
         }
    }
}
