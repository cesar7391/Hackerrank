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
        static void Main(String[] args)
        {
            //STACK
            string valor;          
            do
            {
                Stack<char> pila = new Stack<char>();
                valor = Console.ReadLine();
                
                for(int i =0; i<valor.Length; i++)
                {
                    if (pila.Count() != 0)
                    {
                        switch (valor[i])
                        {
                            case '}':
                                if (pila.Peek() == '{')
                                    pila.Pop();
                                break;
                            case ']':
                                if (pila.Peek() == '[')
                                    pila.Pop();
                                break;
                            case ')':
                                if (pila.Peek() == '(')
                                    pila.Pop();
                                break;
                            default:
                                pila.Push(valor[i]);
                                break;
                        }
                    }
                    else
                    {
                        pila.Push(valor[i]);
                    }                    
                }

                if (pila.Count() == 0)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");

            } while (valor != "");
            
        }

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
