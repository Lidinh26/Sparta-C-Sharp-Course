using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Labs_70_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Model1())
            {
                //LINQ SELECT
                //Data type is iqueryable which means data not loaded until actually needed
                //Lazy loading
                var customers =
                    from customer in db.Customers
                    where (customer.City == "Berlin" || customer.City == "London")
                    select customer;

                //Data actually loaded here
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.CustomerID,-15}{customer.ContactName} from {customer.City}");
                }

                //Only works for primary key
                var oneCustomer = db.Customers.Find("ALFKI");
                Console.WriteLine($"One customer is {oneCustomer.ContactName} from {oneCustomer.City}");


                //ORDER BY
                var allCustomers =
                    from c in db.Customers
                    orderby c.City
                    select c;
                foreach (var customer in allCustomers)
                {
                    Console.WriteLine($"{customer.CustomerID,-15} {customer.ContactName,-20} from {customer.City}");
                }

                //CREATE NEW OUTPUT OBJECT


                var customOutputobject =
                    from c in db.Customers
                    orderby c.Country, c.City
                    select c;

                foreach (var c in customOutputobject)
                {
                    Console.WriteLine($"{c.CustomerID,-15} {c.ContactName,-20} from {c.Country} {c.City}");
                }

                Console.WriteLine();
                Console.WriteLine();

                var customOutputobject2 =
                   from c in db.Customers
                   orderby c.Country, c.City
                   select new
                   {
                       ID = c.CustomerID,
                       Name = c.ContactName,
                       Location = c.City + "in" + c.Country
                   };

                foreach (var c in customOutputobject2)
                {
                    Console.WriteLine($"{c.ID,-10} {c.Name,-25} {c.Location}");
                }

                Console.WriteLine("\n\nNow also create a custom class");


                //We can wrap in brackets to make a list
                var customOutputobject3 =
                    (from c in db.Customers
                     orderby c.Country, c.City
                     select new CustomObject()
                     {
                         ID = c.CustomerID,
                         Name = c.ContactName,
                         Location = c.City + " in " + c.Country
                     }).ToList();

                customOutputobject3.ForEach(item =>
                {
                    Console.WriteLine($"{item.ID,-25} {item.Name,-25} {item.Location}");

                });
            }
        }

        class CustomObject
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }

        }
    }
}
