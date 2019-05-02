using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_11_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //string
            string x = "Hi";
            string y = " there";
            //concatenate
            Console.WriteLine(x+y);

            //super-long strings - this is memory ineficient
            //stringbuilder : use to build very long strings

            var longString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {

                longString.Append($"Adding{i}");
            }

            Console.WriteLine(longString);

            Console.WriteLine("Integer maximum values");
            Console.WriteLine($"2^32 is {Math.Pow(2, 32)}");
            Console.WriteLine($"max and min values {int.MaxValue}," + $"{int.MinValue}");

            //SHORT 
            short s = 12345; //16 bit default

            // INT
            int ii = 1234567890; //32 bit default 

            //LONG
            long l = 1234567890123456789; //64 bit default

            //UNSIGNED integers : all positive
            ushort ushort1 = 123;
            //cant be negative
            //


            //float 32 bit
            //double 64 bit
            //decimal 128 bits long (precise for money) 

        }
    }
}
