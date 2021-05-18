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
            //2D ARRAY
            int[][] matriz = new int[6][];
            int resultado = -63;
            int suma;

            for (int i = 0; i < 6; i++)
            {
                String[] fila = Console.ReadLine().Split(' ');
                for(int j = 0; j < 6; j++)
                {
                    int[] filaI = Array.ConvertAll(fila, s => int.Parse(s));
                    matriz[i] = filaI;                    
                }
            }

            for(int i = 0; i<=3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma = matriz[i][j] + matriz[i][j + 1] + matriz[i][j + 2] + matriz[i + 1][j + 1] + matriz[i + 2][j] + matriz[i + 2][j + 1] + matriz[i + 2][j + 2];

                    if (suma > resultado)  
                        resultado = suma;                    
                }                              
            }

            Console.WriteLine("\n"+resultado);
            //ImprimirArray(matriz);          
        }

        static void ImprimirArray(int[][] a)
        {
            Console.WriteLine("Elementos:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write(a[i][j]+" ");                    
                }
                Console.WriteLine();
            }
        }        
    }
}
