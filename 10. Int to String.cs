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
            //Int to String
            int n;
            String s;
            do
            {
                Console.Write("Introduce el número: ");
                n = Convert.ToInt32(Console.ReadLine());
                s = Convert.ToString(n);                
                
            } while (n < 100 || n > 100);
            

            if (n == Convert.ToInt32(s))
                Console.WriteLine("Good Job");
            else
                Console.WriteLine("Wrong answer");
        }
    }
}
