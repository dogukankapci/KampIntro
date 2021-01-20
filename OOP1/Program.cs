﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;   // 2 => arka planda "mobilya" demek olsun.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,  // kırtasiye kategorisi olduğunu varsayalım.
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            // instance alma
            // case  sensitive => C# küçük büyük harf duyarlıdır.
            // PascalCase  // camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            // int, double,bool,... değer tip
            // diziler, class, abstract, interface,... referans tip 
 

        }
    }
}
