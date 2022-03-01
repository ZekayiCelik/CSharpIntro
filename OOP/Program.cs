using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, ProductName = "Kalem", 
                CategoryId =3,UnitPrice= 35,UnitsInStock=5 };

            //PascalCase    camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            //int,double,bool....değer tip
            //diziler,class,abstract class,interfaces..... referans tip
            //ref out

            //void nedir
            int result = productManager.Sum(3, 2);
            result = result * 2;
            Console.WriteLine(result+ "İt's been coded without void");
            productManager.Sum2(3, 4);

        }
    }
}
