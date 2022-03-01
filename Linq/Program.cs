using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},

            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryID=1,ProductName="Acer notebok",QuentityPerUnit="^32Gb Ram", UnitInPrice=60000,UnitInStock=5},
                new Product{ProductId=2,CategoryID=1,ProductName="Asus notebok",QuentityPerUnit="16Gb Ram", UnitInPrice=8000,UnitInStock=3},
                new Product{ProductId=3,CategoryID=1,ProductName="HP notebok",QuentityPerUnit="8gb Ram", UnitInPrice=6000,UnitInStock=2},
                new Product{ProductId=4,CategoryID=2,ProductName="Samsung Telefon",QuentityPerUnit="4Gb Ram", UnitInPrice=5000,UnitInStock=15},
                new Product{ProductId=5,CategoryID=2,ProductName="Apple Telefon",QuentityPerUnit="4Gb Ram", UnitInPrice=8000,UnitInStock=0},
            };
            //Test(products);

            //GetProducts(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDscTest(products);

            //ClassicLinqTest(products);
            //SQL bilinmeli 
            var result = from p in products
                         join c in categories
                         on p.CategoryID equals c.CategoryId
                         where p.UnitInPrice>5000
                         orderby p.UnitInPrice
                         select new ProductDto { ProductId = p.ProductId, CategoriyName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitInPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine(" {0}-----{1}",productDto.ProductName,productDto.CategoriyName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitInPrice < 16000
                         orderby p.UnitInPrice descending, p.ProductName ascending//descending de olabiilir
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitInPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDscTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("bok")).OrderByDescending(p => p.UnitInPrice).ThenBy(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);

            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("bok"));
            Console.WriteLine(result);
        }

        private static void Fin(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == ("Acer notebook"));
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            foreach (var product in products)
            {
                if (product.UnitInPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);

                }

            }

            Console.WriteLine("Linq--------------------");

            var result = products.Where(product => product.UnitInPrice > 5000 && product.UnitInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine();
        }

        static List<Product> GetProducts(List<Product> products)
        
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitInPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProduct.Add(product);

                }
                
            }return filteredProduct;


        }

      
        static List<Product> GetProductsLİnq(List<Product> products)
        {return products.Where(product => product.UnitInPrice > 5000 && product.UnitInStock > 3).ToList(); }





    }
    class ProductDto
    {
        public int ProductId { get; set; }

        public string CategoriyName { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }


    }
    class Product
    {
        public int ProductId { get; set; }

        public int CategoryID { get; set; }

        public string ProductName { get; set; }

        public string QuentityPerUnit { get; set; }

        public decimal UnitInPrice { get; set; }

        public int UnitInStock { get; set; }



    }

    class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
