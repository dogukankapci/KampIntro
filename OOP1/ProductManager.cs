using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // Ürünle ilgili operasyonları yazacağız bu class'a. ProductManager da denebilir, ProductService de denebilir. 
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }




    }
}
