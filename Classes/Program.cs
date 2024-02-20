using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustemerManager customerManeger=new CustemerManager();
            customerManeger.Add();
            customerManeger.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id= 1;
            customer.FirstName = "Firdevs";
            customer.LastName = "Tetik";

            Customer customer2 = new Customer
            {
                Id = 2, City="İstanbul", FirstName="Erva", LastName="Tetik"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

        }
    }
    

    
}
