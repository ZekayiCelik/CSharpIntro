using System;

namespace Classes2
{
    class Program
    {
        //instance
        
        static void Main(string[] args)
        {
            Product product1 = new Product() {ProductName= "Laptop",UnitPrice=10000,UnitsInStock=5};
            
            
            
            ProductManager productManager = new ProductManager();
            productManager.Add();
        }
    }
}
  