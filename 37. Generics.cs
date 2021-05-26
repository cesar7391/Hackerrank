using System;
using System.Collections;
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
        static void Main(String[] args)
        {
            //GENERICS
            int[] arrayInt = { 1, 2, 3 };
            string[] arrayString = { "Hello", "World" };

            Printer<int> printerInt = new Printer<int>();
            Printer<string> printerString = new Printer<string>();

            printerInt.printArray(arrayInt);
            printerString.printArray(arrayString);           
        }

        public class Printer<T>
        {
            public void printArray(T[] array)
            {
                foreach (object a in array)
                {
                    Console.WriteLine(a);
                }
            }
        }

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
