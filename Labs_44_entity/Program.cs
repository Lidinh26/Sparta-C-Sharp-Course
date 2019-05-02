using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_44_entity
{
    class Program
    {
        static List<Customer> customerList; //all
        static Customer Customer; //one
        static Customer newCustomer; // add new 



        static void Main(string[] args)
        {
  //Select all data as List
  //Changes city name for a certain customerid
            
            using (var db = new NorthwindEntities())
            {
                //standard LINQ query 
                customerList =
                    (from customer in db.Customers
                     select customer).ToList<Customer>();


                 foreach (Customer customer in customerList)
                {
                    Console.WriteLine($"ID : {customer.CustomerID};, " + $"Name : {customer.ContactName}, City : {customer.City}");

                }


                //select one customer and update
                Customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();
                Customer.City = "BERLIN";
                db.SaveChanges();
    
            }




            using (var db = new NorthwindEntities())
            {
                //standard LINQ query 
                customerList =
                    (from customer in db.Customers
                     select customer).ToList<Customer>();


                foreach (Customer customer in customerList)
                {
                    Console.WriteLine($"ID : {customer.CustomerID};, " + $"Name : {customer.ContactName}, City : {customer.City}");

                }
            }

                // You check just one entry specific
                /*Customer = db.Customers.Where(cust => CustomerID == "FRANK").FirstOrDefault();
                Console.WriteLine($"{Customer.CustomerID}, {Customer.ContactName}, {Customer.City}"); */



                // You check just one entry specific -  more readable but longer to code
                /* Customer =
                     (from cust in db.Customers
                     where cust.CustomerID == "FRANK"
                     select cust).FirstOrDefault();
                Console.WriteLine($"{Customer.CustomerID}, {Customer.ContactName}, {Customer.City}"); 
           } */



//ADDING NEW DATA
            using (var db = new NorthwindEntities())
            {
                //insert new
                newCustomer = new Customer()
                {
                    CustomerID = "LIDID33",
                    ContactName = "Bob",
                    CompanyName = "SpartaGlobal",
                    City = "London"


                };

                db.Customers.Add(newCustomer);
                db.SaveChanges();

            }

            //query
             using (var db = new NorthwindEntities())
             {
                 Customer = db.Customers.Where(cust => cust.CustomerID == "LIDID").FirstOrDefault();
                 Console.WriteLine($"{Customer.CustomerID}, {Customer.ContactName}, {Customer.CompanyName}, {Customer.City}");
             }

//DELETING DATA
            //delete this new record
            using (var db = new NorthwindEntities())
            {
                // select customer

                Customer = db.Customers.Where(cust => cust.CustomerID == "LIDID33").FirstOrDefault();

                //delete customer

                db.Customers.Remove(Customer);
                db.SaveChanges();

            }
//Query to view data
            //query
            using (var db = new NorthwindEntities())
            {

                Customer = db.Customers.Where(cust => cust.CustomerID == "LIDID33").FirstOrDefault();
                if (Customer != null)
                {

                  //  Customer = db.Customers.Where(cust => cust.CustomerID == "LIDID").FirstOrDefault();
                    Console.WriteLine($"{Customer.CustomerID}, {Customer.ContactName}, {Customer.CompanyName}, {Customer.City}");
                }
                else
                {

                    Console.WriteLine($"Customer LIDID does not exist");





                }
            }






        }   
    }
}
