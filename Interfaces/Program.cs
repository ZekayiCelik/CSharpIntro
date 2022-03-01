using System;

namespace Interfaces
{
    class Program
    {
        // interface newlenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //IPersonManager employeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
        }
    }


    interface IPersonManager
    {
        // unimplemented operation
        //interfaces publictir defaultu publictir ici dolmaz 
        void Add();
        void Update();
    }
    //inherits class - class------------implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel güncellendi");
        }

       
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {



        }
    }





    //implemented operation
    //class PersonManager
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }

    //}

    //class CustomerManager : PersonManager
    //{

    //}
}
