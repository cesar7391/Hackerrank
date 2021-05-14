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
            //STRING TOKENS
            Console.Write("Cadena: ");
            String s = Console.ReadLine();            
            String expresion = "[^A-Z^a-z]+";
            String[] tokens = Regex.Split(s.Trim(), expresion);

            Console.WriteLine(tokens.Length);

            foreach(String cad in tokens)
            {
                Console.WriteLine(cad);
            }

        }
    }
}
