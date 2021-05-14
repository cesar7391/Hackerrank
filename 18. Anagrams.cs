using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ANAGRAMS
            Console.Write("Cadena 1: ");
            String a = Console.ReadLine();
            Console.Write("Cadena 2: ");
            String b = Console.ReadLine();

            if(isAnagram(a, b))
                Console.WriteLine("Anagramas");
            else
                Console.WriteLine("No anagramas");
        }

        static bool isAnagram(String a, String b)
        {
            char[] aC = a.ToCharArray();
            char[] bC = b.ToCharArray();
            Array.Sort(aC);
            Array.Sort(bC);
            String c1 = aC.ToString();
            String c2 = bC.ToString();

            if (c1.Equals(c2))
                return true;
            else
                return false;
        }

    }
}
