using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DateAcces
{
     public class ProductDal:IProductDal
    {
        // Ado.Net
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
            new Product{ProductId = 1, ProductName = "Acer",  QuantityPerUnit = "32 GB ram",UnitPrice = 10000,UnitInStock =2},
            new Product { ProductId = 2, ProductName = "Mac", QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 1},
            new Product { ProductId = 3, ProductName = "Asus", QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 0 },
            new Product { ProductId = 4, ProductName = "Dell", QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 3 },
            new Product { ProductId = 5, ProductName = "Hp", QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 10 },


            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado net ile eklendi");
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;

        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product customer)
        {
            throw new NotImplementedException();
        }
    }
}
