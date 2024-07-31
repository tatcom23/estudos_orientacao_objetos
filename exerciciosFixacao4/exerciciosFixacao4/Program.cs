using System;

namespace exerciciosFixacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor P1 = new Professor();
            Pessoa E1 = new Estudante();

            P1.nome = "Fernando";
            P1.sexo = 'M';
            P1.data_nascimento = DateTime.Now;
            P1.nascionalidade = "brasileiro";
            P1.CPF1 = 323575989 - 22;
            P1.Celular1 = 442537894;

            Console.WriteLine("Dados do Professor 1: \n" + P1);
        }
    }
}