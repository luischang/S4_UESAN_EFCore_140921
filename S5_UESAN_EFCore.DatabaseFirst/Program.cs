using Microsoft.EntityFrameworkCore;
using S5_UESAN_EFCore.DatabaseFirst.Models;
using System;
using System.Linq;

namespace S5_UESAN_EFCore.DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var data = new SalesDBContext();

            //var customer = new Customer()
            //{
            //    FirstName = "Cristiano",
            //    LastName = "Ronaldo",
            //    Country = "PORTUGAL",
            //    City = "Lisboa",
            //    Phone = "9992882277"
            //};

            //data.Customers.Add(customer);
            //data.SaveChanges();

            //Query LINQ

            var search = (from c in data.Customers
                          where c.Country == "FRANCE"
                          select c).ToList();
            
            foreach (var item in search)
            {
                Console.WriteLine("First Name: "+item.FirstName + " - City " + item.City);
            }

            //Query Lambda Expressions
            //var search2 = data.Customers.Where(x => x.Country == "FRANCE").ToList();

            //var search3 = data.Customers.Where(c => c.Id == 92).FirstOrDefault();

            //Console.WriteLine("La búsqueda encontró a: " +search3.FirstName + " " + search3.LastName);

            //Update
            //search3.Country = "PERU";
            //data.SaveChanges();

            //Delete
            //data.Customers.Remove(search3);
            //data.SaveChanges();
            Console.WriteLine("*****************************************************");
            var search4 = data.Customers.Include(z=>z.Orders).Where(x => x.Country == "FRANCE").ToList();

            foreach (var item in search4)
            {
                Console.WriteLine("First Name: " + item.FirstName + 
                    " - City " + item.City + 
                    "- #Orders: " + item.Orders.Count());
            }
        }
    }
}
