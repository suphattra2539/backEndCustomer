using System;
using System.Collections.Generic;
using System.Linq;

namespace Gread
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            List<Student> listF = new List<Student>();
            Console.WriteLine("Input Prople Student :");
            int index = Int32.Parse(Console.ReadLine());
            // student.Add();
            int[] int1 = new int[index];
            for (int i = 0; i < index; i++)
            {
                var student = new Student();

                Console.WriteLine("input Name :");
                var name = Console.ReadLine();
                student.Name = name;

                Console.WriteLine("input Score :");
                var scores = Int32.Parse(Console.ReadLine());
                student.Score = scores;

                CalGrade(student);
                // int num = int1[i];
                list.Add(student);
            }
            //int num = int1[0];
            for (int i = 0; i < index; i++)
            {
                var student2 = list[i];
                Console.WriteLine("Name : " + student2.Name);
                Console.WriteLine("G : " + student2.Grade);

            }
            Console.WriteLine("====================");

            for (int i = 0; i < index; i++)
            {
                if (list[i].Grade == "F")
                {
                    listF.Add(list[i]);
                }
            }

            Console.WriteLine("====================");
            for (int i = 0; i < listF.Count; i++)
            {
                var student = listF[i];
                Console.WriteLine("Student F Name  : " + student.Name);
                Console.WriteLine("Student F Grade : " + student.Grade);
            }
            Console.ReadKey();
        }

        private static void CalGrade(Student student)
        {
            if (student.Score > 79)
            {
                student.Grade = "A";
            }
            else if (student.Score > 69)
            {
                student.Grade = "B";
            }
            else if (student.Score > 59)
            {
                student.Grade = "C";
            }
            else if (student.Score > 49)
            {
                student.Grade = "D";
            }
            else
            {
                student.Grade = "F";
            }
        }
    }

    public class Student
    {
        //Property
        public string Name { get; set; }
        public string Grade { get; set; }
        public int Score { get; set; }

    }
}
