using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stastic Method");
            Console.WriteLine(Customer.StaticMethod()); //static method is avlaiable when you have not created a instance of the class

            Console.WriteLine("Instance Method");

            //create a instance of the customer class and store in variable called 'customer'

            Customer cust = new Customer();  // new customer object
            Console.WriteLine(cust.instanceMethod());

            //static method doesnt show up //since we created an instance of the customer class of the instance method appears

        }
    }

    class Customer
    {
         
        public string instanceMethod()
        {
            return "Hello from the Instance Method of the customer class";
        }

        public static string StaticMethod()
        {
            return "Hello from the Static method of the customer class";
        }
     
        private string Age;

        public string age { get; set; }
        
        
    }
}
    
