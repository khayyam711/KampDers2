using System;

namespace ValueReferance
{
    class Program
    {
        static void Main(string[] args)
        {
            int eded = 10;
            int eded2 = 30;       // stack//VALUE 
            eded = eded2;
            eded2 = 65;

            Console.WriteLine("Value: "+eded);
            Console.WriteLine("-----------------------------------------");

            int[] ededler = new int[] { 10, 20, 30 };
            int[] ededler2 = new int[] { 100, 200, 300 };
            ededler = ededler2;
            ededler2[0] = 999;       // Referance 
            Console.WriteLine("STACK HEAP: "+ededler[0] );


                



        }
    }
}
