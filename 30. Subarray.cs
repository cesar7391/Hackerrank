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
            //SUBARRAY
            Console.Write("Número de elementos: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] matriz = new int[n];

            for (int i = 0; i < n; i++)
            {
                matriz[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Subarrays con suma negativa: " + ContarSubarrays(matriz));

        }

        static int ContarSubarrays(int[] matriz)
        {
            int contador = 0;

            for (int i = 0; i < matriz.Length; i++)
            {
                int suma = 0;
                for (int j = i; j < matriz.Length; j++)
                {
                    suma = suma + matriz[j];

                    if (suma < 0)
                        contador++;
                }
            }

            return contador;
        }
    }
}

