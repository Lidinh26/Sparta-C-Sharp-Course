using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_09_operators
{
    class Program
    {
        static void Main(string[] args)
        {



            //increment operators - adding one!
            int x = 100;
            // y=x then xii  ie increment by 1
            // so y=x=100 then x increments to 101
            int y = x++; //same as int x=100; y=x; x++;

            Console.WriteLine($"x is {x} and y is {y}");

            //if we want to expect results, use this
            int a = 100;
            int b = ++a;
            //BOTH 101 AS EXPECTED
            //first;ly increment a to 101 then b=a=101 after
            Console.WriteLine($"a is {a} and b is {b}");

            //GENERAL RULE - ONLY USE ++; ON ITS OWN SEPERATE LINE!!
            //BEST WAY 


            // NOT OPERATOR

            bool isExcellent = true;
            bool isRubbish = false;

            Console.WriteLine(isExcellent);
            Console.WriteLine(isRubbish);
            
        }
    }
}
