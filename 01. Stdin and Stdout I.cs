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
            int n1, n2, n3;
            //STDIN AND STDOUT I
            Console.WriteLine("Introduce 3 números para mostrar:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los números introducidos fueron:");
            Console.WriteLine("{0}\n{1}\n{2}\n", n1, n2, n3);
        }
    }
}
