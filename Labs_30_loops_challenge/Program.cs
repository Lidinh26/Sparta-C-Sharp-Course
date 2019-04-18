using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_30_loops_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 1000; i++)

            {
                if (i % 105 == 0) { Console.WriteLine("No"); }

                if (i % 100 == 0) { Console.WriteLine("Hello, my name is Li"); }
                
                if (i % 5 == 0) { Console.WriteLine("Yes"); }
                
                else Console.WriteLine(i);

            }

            for (int a = 1000; a > 0; a--)
            {

                Console.WriteLine(a);
            }


           
        }
    }
}
