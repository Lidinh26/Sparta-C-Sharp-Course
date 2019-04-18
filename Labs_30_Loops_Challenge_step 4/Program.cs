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
            Console.WriteLine("Please pick a number from 1 - 2 and press return");
            string userValue;
            userValue = Console.ReadLine();

            if (userValue == "1")
            {

                for (int i = 1; i <= 1000; i++)

                {
                    if (i % 105 == 0) { Console.WriteLine("No"); }

                    if (i % 100 == 0) { Console.WriteLine("Hello, my name is Li"); }

                    if (i % 5 == 0) { Console.WriteLine("Yes"); }

                    else Console.WriteLine(i);

                }
            }

            else if (userValue == "2")
            {

                for (int a = 1000; a > 0; a--)
                {

                    Console.WriteLine(a);
                }


            }
            else
            {

                Console.WriteLine("You've failed!");
            }



        }
    }
}

