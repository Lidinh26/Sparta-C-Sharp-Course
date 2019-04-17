using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_01_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

          // Console.ReadLine();

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("finished waiting - hit any key");

            Console.WriteLine("Printing out arguments array");
            foreach(string item in args)
            {

                Console.WriteLine("Your item is - " + item);
            }

            Console.ReadLine();


        }
    }
}
