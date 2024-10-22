using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Fernanda");
            list.Add("Luísa");
            list.Add("Cecília");
            list.Insert(2, "Amora"); // você define a posição (índice) de inserção 
            list.Add("Amanda");
            list.Add("Angelo");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); //utiliza a expressão lambda para retorna um valor
            Console.WriteLine("First 'A': " + s1); // x(string) retorna o primeira string cuja a primeira posição é igual a 'A'

            string s2 = list.FindLast(x => x[0] == 'A'); // retorna a ultima ocorrência cuja a primeira letra inicie com 'A'
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // retorna a posição da 1ª ocorrência cuja a primeira letra inicie com 'A'
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // retorna a posição da última ocorrência cuja a primeira letra inicie com 'A'
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("---------------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5); // retorna uma nova lista a partir de uma expressão lambda
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------------------------");
            list.Remove("Amora"); // remove um elemento da lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------");
            list.RemoveRange(1, 2); // remove os elementos a partir da referencia de posição, 
            foreach (string obj in list) // nesse caso remove 2 itens a partir do índice 1
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------");
            list.RemoveAt(2); // remove o elemento que está no indice indicado
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("---------------------------------");
            list.RemoveAll(x => x[0] == 'A'); // remove todos os elementos a partir da expressão lambda
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

           
        }
    }
}
