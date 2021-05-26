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
    public class Player
    {
        public string nombre;
        public int puntos;

        public Player(string nombre, int puntos)
        {
            this.nombre = nombre;
            this.puntos = puntos;
        }
    }

    public class Checker : Comparer<Player>
    {
        public override int Compare(Player p1, Player p2)
        {
            if (p1.puntos == p2.puntos)
            {
                return p1.nombre.CompareTo(p2.nombre);
            }
            return p2.puntos - p1.puntos;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            //COMPARATOR
            Console.Write("Número de jugadores: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Player[] jugadores = new Player[n];
            Checker checker = new Checker();

            for(int i = 0; i<n; i++)
            {
                jugadores[i] = new Player(PedirString(i), PedirValorInt(i));
            }

            Array.Sort(jugadores, checker);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(jugadores[i].nombre +" "+ jugadores[i].puntos);
            }
        }     

        static int PedirValorInt(int i)
        {
            Console.Write("J{0} Puntuación: ",i+1);
            return Convert.ToInt32(Console.ReadLine());
        }

        static string PedirString(int i)
        {
            Console.Write("J{0} Nombre: ", i+1);
            return Console.ReadLine();
        }
    }
}
