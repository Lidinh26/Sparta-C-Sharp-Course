using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_15_rounding_error
{
    class Program
    {
        static void Main(string[] args)
        {

            double total = 0;
            for (int i = 1; i < 8192; i++)
            {

                total += 0.7;

            }

            Console.WriteLine(total);


            decimal total2 = 0;
            for (int i = 1; i < 8192; i++)
            {

                total2 += 0.7M;

            }

            Console.WriteLine(total2);
        }
    }
}
