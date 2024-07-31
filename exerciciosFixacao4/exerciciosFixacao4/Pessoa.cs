using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosFixacao4
{
    public class Pessoa
    {
        public string nome;
        public char sexo;
        public DateTime data_nascimento;
        public string nascionalidade;
        public List <string> disciplina;
        private int idade;

        public int Idade { get => idade; set => idade = value; }
    }
}
