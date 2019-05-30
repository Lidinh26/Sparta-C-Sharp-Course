using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lab_61_raw_sql
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(@"Data Source=localhost;
                    Initial Catalog=Northwind;Persist Security Info=True;
                    User ID=SA;Password=Passw0rd2018"))
            {
                connection.Open();
                Console.WriteLine(connection.State);

                // add new customer 
                /*
                var newCustomer = new Customer("Blog1", "Company1", "JoeBloggs1", "London");
                string SQLInsert = "Insert into Customers (CustomerID,CompanyName,ContactName) values " +
                       $"('{newCustomer.CustomerID}','{newCustomer.CompanyName}','{newCustomer.ContactName}')";
                Console.WriteLine(SQLInsert);
                */


                /*string SQLInsert2 = "Insert into Customers (CustomerID,CompanyName,ContactName,City) values " +
                        "('tff','JoeBloggs5','Company5', 'ggg')";
                Console.WriteLine(SQLInsert2);
                using (var command = new SqlCommand(SQLInsert2, connection))
                {
                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine("Number of records added : " + affected);
                }*/

                //extra
                var newCustomer2 = new Customer()
                {
                    CustomerID = "Blog2",
                    CompanyName = "Company2",
                    ContactName = "JoeBloggs2"
                };




                // update customer

                string SQLUpdate = $"Update Customers Set City='London' where CustomerID='ALFKI'";
                using (var command = new SqlCommand(SQLUpdate, connection))
                {
                    int newData = command.ExecuteNonQuery();
                    Console.WriteLine("The number of records edited: " + newData);
                }

                // delete customer

                string SQLDelete = $"delete FROM Customers where CustomerID='Blog1'";
                using (var command = new SqlCommand(SQLDelete, connection))
                {
                    int del = command.ExecuteNonQuery();
                    Console.WriteLine("The number of records deleted: " + del);
                }


                // read customers

                string SQLSelect = "Select * from Customers";

                using (var command = new SqlCommand(SQLSelect, connection))
                {
                    SqlDataReader sqlreader = command.ExecuteReader();

                    while (sqlreader.Read())
                    {
                        string CustomerID = sqlreader["CustomerID"].ToString();
                        string CompanyName = sqlreader["CompanyName"].ToString();
                        string ContactName = sqlreader["ContactName"].ToString();
                        string City = sqlreader["City"].ToString();

                        var customer = new Customer(CustomerID, CompanyName, ContactName, City);

                        customers.Add(customer);
                    }

                    // now print out data

                    //foreach (var c in customers)
                    //{
                    //    Console.WriteLine($"{c.CustomerID,-15} is {c.ContactName,-40} from {c.CompanyName} in {c.City}");
                    //}

                    customers.ForEach(c =>
                    {
                        Console.WriteLine($"{c.CustomerID,-15} is {c.ContactName,-30} from {c.CompanyName,-40} in {c.City}");
                    });





                }


            }



        }
    }

    internal class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }


        public Customer(string CustomerID, string CompanyName, string ContactName, string city)
        {
            this.CustomerID = CustomerID;
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.City = city;
        }

        // default constructor
        public Customer() { }

    }
}
