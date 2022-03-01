using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;//bir özelliğe değer atadığımız zaman set ederiz
            Console.WriteLine(product.Id);//Get çalışacak
            product.UnitPrice = 50;
            Console.WriteLine(product.UnitInStock);

        }

    }


    class Product
    {
        public Product()
        {

           
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        //Field
        decimal _unitPrice;


        public decimal UnitPrice
        {
            get { return _unitPrice + _unitPrice * 18 / 100; }
            set { _unitPrice = value; }
            
        }
        public decimal UnitInStock;
    }
}
