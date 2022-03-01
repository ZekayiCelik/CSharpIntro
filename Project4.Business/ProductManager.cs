using Project4.DateAcces;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Business
{
    public class ProductManager:IProducService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName =="Laptop")
            {
                throw new DuplicateProductException("Laptop eklenemez");
            }
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            //iş kodları yazılır
             return _productDal.GetAll();
        }
        
    }
}
 