using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D ARRAY
            Console.Write("Número de elementos en el array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            ImprimirArray(a);            
        }

        static void ImprimirArray(int[] a)
        {
            Console.WriteLine("Elementos:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }        
    }
}
