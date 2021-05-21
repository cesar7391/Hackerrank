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
            Console.Write("Número de consultas: ");
            int q = Convert.ToInt32(Console.ReadLine());
            while (q > 0)
            {
                Console.Write("Número de elementos: ");
                int n = PedirValor();
                Console.Write("Longitud del salto: ");
                int salto = PedirValor();

                int[] juego = new int[n];

                for (int i = 0; i < n; i++)
                {
                    juego[i] = PedirValor();
                }

                if (PuedoGanar(salto, juego))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("TRUE");
            }
        }

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool PuedoGanar(int salto, int[] juego)
        {
            return Resolver(salto, juego, 0);
        }

        static bool Resolver(int salto, int[] juego, int i)
        {
            if (i >= juego.Length)            
                return true;            
            if (i < 0 || juego[i] == 1)            
                return false;            

            juego[i] = 1;

            return Resolver(salto, juego, i + salto) || Resolver(salto, juego, i + 1) || Resolver(salto, juego, i - 1);
        }        
    }
}
