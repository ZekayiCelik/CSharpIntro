using Project4.Business;
using Project4.DateAcces;
using Project4.Entities;
using System;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new XProductDal());
            
            
            foreach (var product  in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            try
            {
                productManager.Add(new Product
                {
                    ProductId = 10,
                    ProductName = "Laptop",
                    QuantityPerUnit = "Dört ayaklı masa",
                    UnitInStock = 10,
                    UnitPrice = 400
                });
            }
            catch (DuplicateProductException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
