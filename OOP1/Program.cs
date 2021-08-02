using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;


            Product product2 = new Product { ID = 3, CategoryId = 4, UnitPrice = 300, UnitInStock = 7, ProductName = "PEN" };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            // Case sensistive 
            //stack                            //heap

            productManager.ADD(product1);
        }
    }
}
