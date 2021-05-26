using System;
using System.Collections;
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
        static void Main(String[] args)
        {
            //HASHSET
            Console.Write("Número de pares: ");
            int t = PedirValor();
            String[] par_izq = new string[t];
            String[] par_der = new string[t];

            for(int i = 0; i < t; i++)
            {
                Console.Write("Par [{0}] izquierda: ",i+1);
                par_izq[i] = Console.ReadLine();
                Console.Write("Par [{0}] derecha: ",i+1);
                par_der[i] = Console.ReadLine();
            }

            HashSet<string> set = new HashSet<string>();
            for(int i = 0; i < t; i++)
            {
                set.Add(par_izq[i] + "-" + par_der[i]);
                Console.WriteLine(set.Count());
            }
        }

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
