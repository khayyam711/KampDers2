using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product ProductOb1 = new Product();
            Product ProductOb2 = new Product();
            Product ProductOb3 = new Product();


            ProductOb1.Id = 1;
            ProductOb1.Name = "Ball";
            ProductOb1.Price = 7;
            ProductOb1.Information = "Green";

            ProductOb2.Id = 2;
            ProductOb2.Name = "Table";
            ProductOb2.Price = 9;
            ProductOb2.Information = "Square";

            ProductOb3.Id = 3;
            ProductOb3.Name = "Pen";
            ProductOb3.Price = 1.5;
            ProductOb3.Information = "Red";

            Product[] product = new Product[] {ProductOb1,ProductOb2,ProductOb3 };


            foreach (var x in product)
            {   
                Console.WriteLine(x.Id +" "+x.Name + " " +x.Information + " " +x.Price );
            }



            Console.WriteLine("----------------METHODS---------------------");


            //Inctance

            BoxManager boxManager = new BoxManager();
            boxManager.Add(ProductOb1);
            boxManager.Add(ProductOb2);
            boxManager.Add(ProductOb3);
             

            Console.ReadKey();
        }



    }
}
