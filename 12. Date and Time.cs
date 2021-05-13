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
            //Date and Time
            int month, day, year;
            String dia;

            Console.Write("Escribe la fecha (MM dd yyyy): ");
            String fecha = Console.ReadLine();

            IFormatProvider fp = new System.Globalization.CultureInfo("es-ES", false);
            DateTime fechaF = new DateTime();
            fechaF = DateTime.ParseExact(fecha , "MM dd yyyy", fp);

            int diaSemana = (int)fechaF.DayOfWeek;
            String diaTxt="";

            switch (diaSemana)
            {
                case 0:
                    diaTxt = "DOMINGO";
                    break;
                case 1:
                    diaTxt = "LUNES";
                    break;
                case 2:
                    diaTxt = "MARTES";
                    break;
                case 3:
                    diaTxt = "MIÉRCOLES";
                    break;
                case 4:
                    diaTxt = "JUEVES";
                    break;
                case 5:
                    diaTxt = "VIERNES";
                    break;
                case 6:
                    diaTxt = "SÁBADO";
                    break;
            }

            Console.WriteLine(diaTxt);

            
        }
    }
}
