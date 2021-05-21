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
        static void Main(string[] args)
        {
            //ARRAYLIST
            ArrayList[] arrayList = new ArrayList[20000];
            Console.Write("Número de arrays: ");
            int lista = PedirValor();

            for(int i = 0; i<lista; i++)
            {
                arrayList[i] = new ArrayList();
                Console.Write("Número de valores en el array #{0}: ",i + 1);
                int numero = PedirValor();

                for (int j = 0; j < numero; j++)
                {
                    Console.Write("Valor {0}/{1}: ",j + 1,numero);
                    int valor = PedirValor();
                    arrayList[i].Add(valor);
                }
            }

            Console.Write("Número de consultas: ");
            int cons = PedirValor();
            for (int i = 0; i < cons; i++)
            {
                Console.Write("coordenada X: ");
                int x = PedirValor();
                Console.Write("coordenada Y: ");
                int y = PedirValor();
                try
                {
                    Console.WriteLine(arrayList[x-1][y-1]);

                }catch(Exception e)
                {
                    Console.WriteLine("¡ERROR!");
                }
            }

        }

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
