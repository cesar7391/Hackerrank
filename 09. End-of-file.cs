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
            String cadena="";
            int c = 1;
            //End-of-file
            do
            {
                cadena = Console.ReadLine();
                Console.WriteLine("{0}. {1}", c,cadena);
                c++;
            } while (!cadena.EndsWith("end-of-line"));
        }
    }
}
