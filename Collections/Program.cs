using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names=new string[]{ "Melik","Tural","Hakim","Cabar" };

            //foreach ( string ad in names)
            //{
            //    Console.WriteLine(ad);
            //}
              

            //names[4] = "Sahin";      //ADD Item and  out off index of array 
            //                               // Console.WriteLine(names[4]);  


            // LIST ADD ELEMENTS 
            List<string> names2 = new List<string> { "Melik", "Tural", "Hakim", "Cabar" };

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("ElaveAD");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            Console.ReadKey();
        }
    }
}
