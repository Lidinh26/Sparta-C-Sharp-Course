using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_TESTER
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Operator Labs
                1. BODMAS

         Write a method which takes a double as an input, squares it, adds 101,
         divides by 10 then subtracts 4. Return a double rounded to 3 decimal places.


             */

            double input = 10.003;
            var answer = Math.Pow(input, 2);

           var result = ((answer + 101) / 10) - 4;

           /* var add = answer + 101;
            var div = add / 10;
            var subtract = div - 4;*/

           Console.WriteLine(Math.Round(result, 3));
        }
    }
}
        
