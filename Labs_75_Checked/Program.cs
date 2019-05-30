using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_75_Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            short s = 12345;
            int i = 1234567890;
            long l = 1234567890123456789;

            var largeNumber = int.MaxValue; // largest number a int can take is 2 147 483 647
            var largeUnsignedNumber = uint.MaxValue; // Largest number is 4 294 967 296
            var smallNumber = int.MaxValue; // smallest number a int can take is  - 2 147 483 648

            Console.WriteLine(largeNumber);
            largeNumber++;
            Console.WriteLine(largeNumber);
            largeNumber++;
            Console.WriteLine(largeNumber);
            largeNumber++;
            Console.WriteLine(largeNumber);

            //Integers by default : no run time checking for overflow exception


            //heavy on cpu ao dont use unless need it 

            checked
            {
                var bigNumber = int.MaxValue;
                //var biggerBigNumber = bigNumber * 10;
                  
            }

            //if using large numbers then use
            var hugenumber = double.MaxValue;
            Console.WriteLine(hugenumber);
            var hugenumber2 = decimal.MaxValue;
            Console.WriteLine(hugenumber2);
            




        }
    }
}
