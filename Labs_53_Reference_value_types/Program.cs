using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_53_Reference_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            int x = 100;
            int y = x;
            Console.WriteLine($"x is {x} and y is {y}"); //prints 100,100

            //change one
            x = 400;
            Console.WriteLine($"x is {x} and y is {y}"); //prints 400,100

            //Change has affected only new value

            //reference types

            var array01 = new int[] { 100, 200, 300 };
            var array02 = array01;

            //before
            foreach (int item in array01) { Console.WriteLine(item); }
            foreach (int item in array02) { Console.WriteLine(item); }

            //change ONE item
            array02[2] = 99999999;

            //after
            foreach (int item in array01) { Console.WriteLine(item); }
            foreach (int item in array02) { Console.WriteLine(item); }

            //change has affected both arrays

        }
    }
}
