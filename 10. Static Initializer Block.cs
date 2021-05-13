using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static int B, H;
        static bool ok;

        static Program()
        {
            ok = true;
            Console.Write("Valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nValor de H: ");
            H = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(B<= 0 || H <= 0)
                {
                    throw new Exception("El ancho y el alto deben ser positivos");
                    ok = false;
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        
        static void Main(string[] args)
        {
            if (ok)            
                int Area = B * H;

            Console.WriteLine("El resultado es: " + Area); 
        }
    }
}
