using System;
using System.Diagnostics;
namespace Labs_13_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = 10;
            Console.WriteLine("Start number is " + start);
            Trace.WriteLine("To output windows: Start number is " + start);

            int end = 15;

            for (int i = start; i <end; i++)
            {

                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
