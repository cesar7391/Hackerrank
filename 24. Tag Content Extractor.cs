using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //VALID USERNAME REGULAR EXPRESION
            Console.Write("Número de líneas: ");
            int n = Convert.ToInt32(Console.ReadLine());                      
            //[] es una clase de caracteres, ^ se usa para negar, + para aceptar 1 o más caracteres, //n utiliza los grupos de caracteres, iniciando en 1 de izq a derecha
            Regex expresion = new Regex("<([^<>]+)>([^<>]+)</\\1>");
            Match match;

            for(int i = 0; i<n; i++)
            {
                Console.Write("Línea: ");
                String s = Console.ReadLine();
                match = expresion.Match(s);
                if (match.Success)
                    Console.WriteLine(match.Groups[2]);
                else
                    Console.WriteLine("Nada");               
            }
        }        
    }
}
