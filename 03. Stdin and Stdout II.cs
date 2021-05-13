using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //STDIN AND STDOUT II
            String cadena;
            int entero;
            double doble;

            Console.WriteLine("Introduce 3 valores en orden (int, double, String):");
            entero = Convert.ToInt32(Console.ReadLine());
            doble = Convert.ToDouble(Console.ReadLine());
            cadena = Console.ReadLine();
            Console.WriteLine("\nLos valores introducidos fueron:\n");
            Console.WriteLine("String: {0}",cadena);
            Console.WriteLine("Double: {0}",doble);
            Console.WriteLine("Int: {0}",entero);
        }
    }
}
