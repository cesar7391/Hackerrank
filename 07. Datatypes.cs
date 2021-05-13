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
            long x;
            //DATATYPES
            Console.Write("¿Cuántos números se introducirán?: ");
            int t = Convert.ToInt32(Console.ReadLine());


            for(int i =0; i < t; i++)
            {
                try
                {
                    x = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine(x + "puede ser de tipo: ");

                    if ((x >= -128) && (x <= 127)) Console.WriteLine("* byte");
                    if ((x >= -32768) && (x <= 32767)) Console.WriteLine("* short");
                    if ((x >= Int32.MinValue) && (x <= Int32.MaxValue)) Console.WriteLine("* int");
                    if ((x >= Int64.MinValue) && (x <= Int64.MaxValue)) Console.WriteLine("* long");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("NO SE PUEDE DETERMINAR " + ex.ToString());
                }
                

            }
        }
    }
}
