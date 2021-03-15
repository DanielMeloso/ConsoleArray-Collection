using System;
using System.Collections.Generic;

namespace ConsoleArray_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipagem estática
            string[] a = new string[3];
            //tipagem dinâmica
            //var a = new string[3];

            a[0] = "Daniel";
            a[1] = "Monique";
            a[2] = "Mirian";
            //a[4] = "teste"; //não é possível incluir, pois só existem 3 espaços no array

            int size = a.Length; //contar a quantidade de elementos
            Array.Sort(a); //pode colocar ordenação aqui

            foreach (string nome in a) 
            {
                Console.WriteLine(nome);
            }

            //localizar uma informação
            if (Array.Exists(a, e=> e== "Daniel"))
            {
                Console.WriteLine("Encontrei o Daniel no array");
            }

            if (Array.Exists(a, e => e.IndexOf("Dan") != -1)) //procurando por parte da String
            {
                Console.WriteLine("Encontrei o Daniel no array pesquisando somente por Dan");
            }

            Console.WriteLine("\n COLLECTION \n");
            //uma collection, não precisamos inforar a quantidade de espaços na memória
            List<String> l = new List<string>();
            l.Add("Daniel");
            l.Add("Monique");
            l.Add("Mirian");

            int sizeList = l.Count; //contar a quantidade de elementos
            Console.WriteLine(l[0]); //podemos buscar um elemento específico, assim como no array;

            foreach (string nomeArray in l)
            {
                Console.WriteLine(nomeArray);
            }

            l.ToArray(); //podemos converter uma Collection em array

            if (l.Exists(e => e == "Monique")) //localizar uma informação
            {
                Console.WriteLine("Encontrei a Monique no meu Collection");
            }

            Console.Read();
        }
    }
}
