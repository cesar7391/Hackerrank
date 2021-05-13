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
            int n;
            //IF-ELSE
            Console.WriteLine("Escribe un número: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 >= 1)
                Console.WriteLine("Weird");
            else
            {
                if(n >=2 && n <= 5)
                    Console.WriteLine("Not Weird");
                else if (n >= 6 && n <= 20)                
                    Console.WriteLine("Weird");
                else if(n > 20)                
                    Console.WriteLine("Not Weird");                
            }
        }
    }
}
