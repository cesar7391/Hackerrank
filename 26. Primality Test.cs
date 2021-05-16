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
            //PRIMALITY TEST
            Console.Write("Número: ");
            int n = (Convert.ToInt32(Console.ReadLine()));

            if(EsPrimo(n))
            Console.WriteLine("Primo");
            else
            Console.WriteLine("No primo");

        }     
        
        static bool EsPrimo(int n)
        {
            if (n <= 1 && n == 4)
                return false;

            for(int i = 2; i < (n/2); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
