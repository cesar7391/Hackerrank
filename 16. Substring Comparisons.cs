using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUBSTRING COMPARISONS
            Console.Write("Ingresa la cadena: ");
            String s = Console.ReadLine();
            Console.Write("Valor de k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n"+getSmallestAndLargest(s, k));
        }

        static String getSmallestAndLargest(String s, int k)
        {
            String cadena = s.Substring(0,k);
            String menor = cadena, mayor = cadena;

            for(int i = 10; i<=s.Length-k; i++)
            {
                cadena = s.Substring(i, k);

                if (cadena.CompareTo(mayor) > 0)
                    mayor = cadena;

                if (cadena.CompareTo(menor) < 0)
                    menor = cadena;
            }

            return menor + "\n" + mayor;
        }
    }
}
