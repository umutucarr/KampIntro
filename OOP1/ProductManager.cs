using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //içinde ürün ile ilgi operasyonlar olur.
    class ProductManager
    {
        public void Add(Product product)
        {
            
            Console.WriteLine("Ürün eklendi: "+product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Ürün güncellendi: "+product.ProductName);
        }
        

    }
}
