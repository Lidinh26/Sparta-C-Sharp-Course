using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_17_datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaring a new date 
            var d = new DateTime();

            Console.WriteLine(d);

            //not very helpful:default date and time is year 0000

            //so..

            var e = DateTime.Today;
            var f = DateTime.Now;

            Console.WriteLine(e);
            Console.WriteLine(f);


            //add calendar day/week/month

            e = e.AddDays(1);
            e = e.AddMonths(1);
            e = e.AddHours(1);

            Console.WriteLine(e);
            //use seconds, millie seconds, ricks (10 to the power of 7 i.e 100 nanoseconds)
            //elapsed time


            //CRUDE : subtracking time

            var start = DateTime.Now;

            for(int i =0; i <1000000; i++)
            {
                   
            }

            var stop = DateTime.Now;

            Console.WriteLine($"Counting took {(stop - start)}");


            //EASY WAY
            var s = new Stopwatch();
            s.Start();
           
            int total = 0;

            for (int i = 0; i <10000000; i++)
            {

                total += i;

            }

            s.Stop();
            Console.WriteLine(s.ElapsedTicks);
            Console.WriteLine(s.Elapsed);

        }
    }
}
