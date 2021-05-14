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
            //STRING REVERSE
            Console.Write("Ingresa la cadena: ");
            String cadena = Console.ReadLine();
            String cadenaI = Reversa(cadena);

            if (Comprobar(cadena, cadenaI))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        static String Reversa(String cadena)
        {
            char[] arregloC = cadena.ToCharArray();
            String cadenaI = "";

            for(int i = arregloC.Length - 1; i >= 0; i--)
            {
                cadenaI += arregloC[i];
            }

            return cadenaI;
        }

        static bool Comprobar(String cadena, String cadena2)
        {
            return cadena.Equals(cadena2);                         
        }
    }
}
