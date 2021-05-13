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
            //OUTPUT FORMATTING

            Console.WriteLine(" ================================ ");
            for (int i = 0; i < 3; i++)
            {
                String cadena = Console.ReadLine();
                int numero = Convert.ToInt32(Console.ReadLine());
                //Para completar ceros restantes se puede usar String.Format indicando el formato
                Console.WriteLine("{0} {1}\n",cadena.PadRight(15),String.Format("{0:000}",numero));

            }
            Console.WriteLine(" ================================ ");
            
        }
    }
}
