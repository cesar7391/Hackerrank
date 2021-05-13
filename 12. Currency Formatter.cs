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
            Console.Write("Pago: ");
            double payment = Convert.ToDouble(Console.ReadLine());

            String us = String.Format("${0:N}",payment);
            String india = String.Format("Rs.{0:N}", payment);
            String china = String.Format("¥{0:N}", payment);
            String france = payment.ToString("C",CultureInfo.CreateSpecificCulture("fr-FR"));

            Console.WriteLine();
            Console.WriteLine("US: " + us);
            Console.WriteLine("India: " + india);
            Console.WriteLine("China: " + china);
            Console.WriteLine("France: " + france);
            Console.WriteLine();
        }
    }
}
