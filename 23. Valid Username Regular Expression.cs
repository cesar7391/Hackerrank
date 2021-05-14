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
            Console.Write("Número de usuarios: ");
            int n = Convert.ToInt32(Console.ReadLine());
                      
            Regex expresion = new Regex("^[a-zA-Z][a-zA-Z0-9_]{7,29}$");
            Match match;

            for(int i = 0; i<n; i++)
            {
                Console.Write("Nombre de usuario: ");
                String s = Console.ReadLine();
                match = expresion.Match(s);
                if (match.Success)
                    Console.WriteLine("Válido");
                else
                    Console.WriteLine("Inválido");               
            }
        }        
    }
}
