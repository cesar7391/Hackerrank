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
            //List
            Console.Write("Número de valores en la lista: ");
            int n = PedirValor();

            List<int> listaI = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                listaI.Add(PedirValor());
            }

            Console.Write("Número de operaciones: ");
            int q = PedirValor();

            for (int i = 0; i < q; i++)
            {
                Console.Write("Operación (Insert/Delete): ");
                String comando = Console.ReadLine();
                if (String.Equals(comando, "Insert"))
                {
                    Console.Write("Índice a insertar: ");
                    int x = PedirValor();
                    Console.Write("Valor: ");
                    int v = PedirValor();
                    listaI.Insert(x, v);
                }

                if (String.Equals(comando, "Delete"))
                {
                    Console.Write("+Indice a eliminar: ");
                    int x = PedirValor();
                    listaI.RemoveAt(x);
                }
            }    
            
            foreach(int x in listaI)
            {
                Console.WriteLine(x);
            }
        }

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
