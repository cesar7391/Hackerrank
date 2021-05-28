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
        static void Main(string[] args)
        {
            Adder A = new Adder();
            Console.WriteLine("My superclass is: " + A.GetType().BaseType.Name + "\n" + A.Add(10, 25) + " " + A.Add(12, 30) + " " + A.Add(25, 3));
        }
    }
    class Arithmetic
    {
        public int Add(int valor1, int valor2)
        {
            int AddResult = valor1 + valor2;
            return AddResult;
        }
    }
    class Adder : Arithmetic
    {
    }

}
