using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        private static object Manager;

        static void Main(string[] args)
        {
            //IntarfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
              new sqlServerCustomerDal(),
              new OracleCustomerDal(),
              new MySqlCustomerDal(),
            };

            foreach (var customerDal in customerDals) 
            {
                customerDal.Add();
            }



            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager Manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Sevval",
                LastName = "Deniz",
                Address = "İstanbul"

            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Kalben Farah",
                LastName = "Deniz",
                Departmant = "Computer Scienses"
            };
            Manager.Add(customer);
            Manager.Add(student);
            Console.ReadLine() ;    
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class student: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

