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
            //BIGDECIMAL
            Console.Write("Número: ");
            int n = Convert.ToInt32(Console.ReadLine());            

            String[] s = new String[n];
            decimal[] d = new decimal[n];

            for(int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
                d[i] = Convert.ToDecimal(s[i]);
            }

            Array.Sort(d);

            //Output
            Console.WriteLine();
            for(int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(d[i]);
            }
        }       
    }
}
