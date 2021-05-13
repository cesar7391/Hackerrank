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
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            Console.Write("Introduce cadena A: ");
            String A = Console.ReadLine();
            Console.Write("Introduce cadena B: ");
            String B = Console.ReadLine();

            int longitud = A.Length + B.Length;
            Console.WriteLine(longitud);

            int comparacion = A.CompareTo(B);
            if (comparacion > 0)
                Console.WriteLine("Si");
            else
                Console.WriteLine("No");

            String ATitle = ti.ToTitleCase(A);
            String BTitle = ti.ToTitleCase(B);
            Console.WriteLine("{0} {1}", ATitle, BTitle);

        }
    }
}
