using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampDers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] CoursName = new string[] {"Product1", "Product2", "Product3", "Product4", "Product5" };


            for (int i = 0; i < CoursName.Length; i++)
            {
                Console.WriteLine(CoursName[i]);
            }

            Console.WriteLine("FOR END!!!!");


            foreach (string product in CoursName)
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();

            Console.WriteLine("CLASS START");


            Course course1 = new Course();

            course1.CoursName = "C#";
            course1.Tutor = "NAME";
            course1.Price = 59;
        


            
        }
    }



    class Course
    {
        public string CoursName { get; set; }
        public string Tutor { get; set; }
        public int Price { get; set; }
    }



}
