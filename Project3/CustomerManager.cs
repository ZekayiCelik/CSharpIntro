using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
            new Customer { Id = 1, FirstName = "Zekayi", LastName = "Celik", City = "Kütahya",},
            new Customer { Id = 2, FirstName = "Özlem", LastName = "Solmaz", City = "Kütahya" },
            new Customer { Id = 3, FirstName = "Elif", LastName = "Ceyhan", City = "Kütahya" },
            new Customer { Id = 4, FirstName = "Salih", LastName = "Celik", City = "Kütahya" },
            new Customer { Id = 5, FirstName = "Ali", LastName = "Colak", City = "Kütahya",Email="Asy@" }

            };
        }
        List<Customer> customers;


        public List<Customer> GetAll()
        {
           
            return customers;
        } 


        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
 