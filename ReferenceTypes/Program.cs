using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boelan value types
            int sayi1 = 10;

            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("sayi 1 =" +sayi1);

            //Array,class,interface......reference types
            int[] sayilar1 = new int[] { 1,2,3};
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;

            sayilar2[0] = 1000;

            Console.WriteLine("sayilar1[0]"+sayilar1[0]);

            Person person1 = new Person();

            Person person2 = new Person();

            person1.FirstName = "Engin";
            person1 = person2;
            person2.FirstName = (" Elif ");

            
            Console.WriteLine(person1.FirstName);
             

            Customer customer = new Customer();
            customer.FirstName = "Salih";

            Employee employee = new Employee();
            Person person3 = new Person();
            person3 = customer;
            customer.CreditCartNumber = 2334124;
            employee.FirstName = "Veli";
            Console.WriteLine(person3.FirstName);

            //customer =employee;
            //its wrong we can't do it like we couldnt get equals to in to string
            //we do boxing
           Console.WriteLine(((Customer)person3).CreditCartNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }
    class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public int LastName { get; set; }
        
    }
    class Customer:Person
    {
        public int CreditCartNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}


 