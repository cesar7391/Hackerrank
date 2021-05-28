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
	public class Student
	{
		private int id;
		private String fname;
		private double cgpa;
		public Student(int id, String fname, double cgpa)
		{
			this.Id = id;
			this.Fname = fname;
			this.Cgpa = cgpa;
		}

        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public double Cgpa { get => cgpa; set => cgpa = value; }
    }


	class Program
    {
        private static int Comparar(Student s1, Student s2)
        {
            if(s1.Cgpa < s2.Cgpa)
            {
                return s1.Fname.CompareTo(s2.Fname);
            }
            return 0;
        }

        static void Main(String[] args)
        {
            //SORT
            int cont = 1;
            int testCases = PedirValor();
            List<Student> studentList = new List<Student>();

            while(testCases > 0)
            {
                Console.Write("ID [{0}]: ",cont);
                int id = PedirValor();
                Console.Write("Nombre [{0}]: ", cont);
                String fname = Console.ReadLine();
                Console.Write("Promedio General [{0}]: ", cont);
                double cgpa = Convert.ToDouble(Console.ReadLine());

                Student est = new Student(id, fname, cgpa);
                studentList.Add(est);

                testCases--;
                cont++;
            }

            studentList.Sort(delegate (Student s1, Student s2)
            {
                if (s1.Cgpa == null && s2.Cgpa == null) return 0;
                else if (s1.Cgpa == null) return -1;
                else if (s2.Cgpa == null) return 1;
                else return s1.Cgpa.CompareTo(s2.Cgpa);
            });

            studentList.Reverse();

            foreach (Student est in studentList)
            {
                Console.WriteLine(est.Fname);
            }
        }     

        static int PedirValor()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
