using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{
                    FirstName="Firdevs" 
                }, new Student
                {
                    FirstName="Erva"
                }, new Person
                {
                    FirstName="Serkan"
                }

             };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();



            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    class Customer : Person 
    {
        public string City { get; set;  }

    }

    class Student : Person
    {
        public string Department { get; set; }
    }

}
