using System;
namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             
            //Class object create and declaration//

            Course courseOB1 = new Course();
            Course courseOB2 = new Course();
            Course courseOB3 = new Course();


            //Class type array create //
                                                //object as element of array//
            Course[] massivOB = new Course[] { courseOB1, courseOB2 ,courseOB3 };
        }
    }


    class Course
    {
        public string CoursName { get; set; }
        public string Tutor { get; set; }
        public int Price { get; set; }
    }
}
