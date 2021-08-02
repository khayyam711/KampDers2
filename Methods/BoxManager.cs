using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BoxManager
    {

        public  void Add(Product product)
        {
            Console.WriteLine("Add Product :  " + product.Name);
        }




        public void ADD2(string adi,string aciklama ,int fiyat ) //Avoid Encupsulation 
        {
            Console.WriteLine("Add Product :  " + adi);

        }
    }
}
