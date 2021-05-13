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
            Console.Write("Introducir cadena: ");
            String cadena = Console.ReadLine();
            Console.Write("Introducir indice inicio: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introducir caracteres siguientes: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(cadena.Substring(start,end));
        }
    }
}
