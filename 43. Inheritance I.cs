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
            bird mockingbird = new bird();
            mockingbird.walk();
            mockingbird.sing();
            mockingbird.fly();
        }
    }

    class Animal
    {
        public void walk()
        {
            Console.WriteLine("I am walking");
        }
    }

    class bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("I am flying");
        }

        public void sing()
        {
            Console.WriteLine("I am singing");
        }
    }   
    
}
