using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DateAcces
{
    public class XProductDal : IProductDal
    {
        List<Product> _products;
        public XProductDal()
        {
            _products = new List<Product>
            {
            new Product{ProductId = 1, ProductName = "Acer x",  QuantityPerUnit = "32 GB ram",UnitPrice = 10000,UnitInStock =2},
            new Product { ProductId = 2, ProductName = "Mac x", QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 1},
            new Product { ProductId = 3, ProductName = "Asus X", QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 0 },
            new Product { ProductId = 4, ProductName = "Dell X", QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 3 },
            new Product { ProductId = 5, ProductName = "Hp X" , QuantityPerUnit = "32 GB ram", UnitPrice = 10000, UnitInStock = 10 },


            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("X ile eklendi");
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
