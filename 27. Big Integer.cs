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
            //BIG INTEGER
            Console.Write("Número a: ");
            BigInteger a = (Convert.ToInt64(Console.ReadLine()));
            Console.Write("Número b: ");
            BigInteger b = (Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine(a + b);
            Console.WriteLine(a * b);
        }        
    }
}
