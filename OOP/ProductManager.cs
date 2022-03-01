using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ProductManager
    {
        //Encapsulation
        
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "Eklendi");
        
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");


        }

        public int Sum(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Sum2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2 +"it's been coded by void");
        }

    }
}
