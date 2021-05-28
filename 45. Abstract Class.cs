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
            MyBook new_novel = new MyBook();
            Console.Write("Título del libro: ");
            new_novel.SetTitle(Console.ReadLine());
            Console.WriteLine("El título es: " + new_novel.GetTitle());
        }
    }
    abstract class Book
    {
        public abstract void SetTitle(string s);
        public abstract string GetTitle();
    }
    class MyBook : Book
    {
        string title;
        public override string GetTitle()
        {
            return title;
        }

        public override void SetTitle(string s)
        {
            title = s;
        }
    }

}
