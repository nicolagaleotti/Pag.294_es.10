using System;
using System.Collections.Generic;
using Metodo;

namespace Esercizio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Inserisci la lunghezza dell'array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int numero;
            List<int> lista = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                do
                {
                    numero = r.Next(0, n * 3);
                } while (lista.Contains(numero));
                lista.Add(numero);
                a[i] = numero;
            }
            a = CountingSort.Sort(a);
            Console.WriteLine("Array ordinato:");
            for ( int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();

        }
    }
}
