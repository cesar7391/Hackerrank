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
            //LOOPS II

            Console.Write("Introduce el valor de a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el valor de b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número de pasos: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //a+2^0*b-a+2^0*b+2^1*b-a+2^0*b+2^1*b+2^2*b...
            for (int i = 0; i<n; i++)
            {
                //Se usa la fórmula                
                a = a + (Math.Pow(2, i)*b);
                Console.Write("{0} ", a);
            }
            Console.WriteLine();            
        }
    }
}
