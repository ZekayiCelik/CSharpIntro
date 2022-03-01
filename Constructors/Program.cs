using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id =1,FirstName ="Zekayi",LastName ="Çelik",City="Kütahya"};
            Customer customer2 = new Customer(2,"Elif","Ceyhan","Kütahya");// constructorda method gibi verdik ne yapması gerektiğini
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Özlem";
            customer3.LastName = "Solmaz";
            customer3.City = "Kütahya";
            // iki tane contructor oluşturduk 
        }
        
    }

    class Customer
    {
        //iki tane constructor verdik overload yaptık overload constructorda geçerli 
        //iki tane vermemizin sebebi karışmaması için customer 1 ile 2 karışmaması için
        //cusatomer 3 de ayrıu bir örnek 

        //default contsructor
        public Customer()
        {

        }
        public Customer(int id,string firsName,string lastName,string city)
        {
            Id = id;
            FirstName = firsName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
