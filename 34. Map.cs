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
            //MAP ~ DICTIONARY C#
            Console.Write("Número de registros: ");
            int n = PedirValor();
            string busqueda;
            Dictionary<string, string> dicc = new Dictionary<string, string>();

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nombre: ");
                String nombre = Console.ReadLine();
                Console.Write("Número telefónico: ");
                string telefono = Console.ReadLine();
                dicc.Add(nombre, telefono);
            }

            do
            {
                Console.Write("Buscar persona por nombre: ");
                busqueda = Console.ReadLine();

                try
                {
                    string contacto = dicc[busqueda];
                    Console.WriteLine(busqueda + " = " + contacto);
                }
                catch (Exception e)
                {
                    Console.WriteLine("NO ENCONTRADO");
                }
            } while (busqueda != "");
        }

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
