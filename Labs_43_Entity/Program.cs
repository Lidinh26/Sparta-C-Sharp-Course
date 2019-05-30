using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_43_Entity
{
    class Program
    {
        static Customer customerToupdate;
        static Customer findOneCustomer;



        static void Main(string[] args)
        {
            // by using the 'using' statement it will automatically clean up database connection when done
            /*using (var db = new NorthwindEntities())

            {

                var customers = db.Customers.ToList();

                foreach (var customer in customers)
                {

                    Console.WriteLine(customer.CustomerID);
                }

                foreach (var customer in customers)
                {

                    Console.WriteLine($"{customer.CustomerID}, name is {customer.ContactName}");
                }

                //update one customer

                customerToupdate = db.Customers.Where(cust => cust.CustomerID == "Phill").FirstOrDefault();
                //FirstOrDefault(); - This searches for the first field 

                customerToupdate.City = "PhilsCity";
                db.SaveChanges();
            }
            using (var db = new NorthwindEntities())
            {

                findOneCustomer =
                    (from cust in db.Customers
                     where cust.CustomerID == "Phil"
                     select cust).FirstOrDefault();
                Console.WriteLine($"\n\nUpdated customer has new city = {findOneCustomer.City}");
            }
            try //contact database
            {
                 
            }
            catch //any errors
            {

            }
            finally //close database
            {

            }
            */

        }
    }
}
