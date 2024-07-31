using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exerciciosFixacao4
{
    public class Professor : Pessoa
    {
        public int NumeroTurmas;
        public double Salario;
        private int Registro;
        private int CPF;
        private int RG;
        private string Endereco;
        private int Celular;
        private string Email;

        public int Registro1 { get => Registro; set => Registro = value; }
        public int CPF1 { get => CPF; set => CPF = value; }
        public int RG1 { get => RG; set => RG = value; }
        public string Endereco1 { get => Endereco; set => Endereco = value; }
        public int Celular1 { get => Celular; set => Celular = value; }
        public string Email1 { get => Email; set => Email = value; }

        public override string ToString()
        {
            return "Nome: " + nome + ",\n"
                + "Sexo: " + sexo + ",\n"
                + "Data de nascimento: " + data_nascimento + ",\n"
                + "Nascionalidade: " + nascionalidade + ",\n"
                + "CPF: " + CPF1 + ",\n"
                + "Celular: " + Celular1;
        }
    }

}
