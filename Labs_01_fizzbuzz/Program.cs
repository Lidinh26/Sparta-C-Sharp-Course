using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_01_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //count to 100
            //start from 1, up to 100, increment by 1
            for(int i=1;i<100;i++)
            {
                Console.WriteLine(i);
                if(i%3 == 0) { Console.WriteLine("fizz"); }
                if(i%5 == 0) { Console.WriteLine("buzz"); }
                if(i%15 == 0) { Console.WriteLine("fizzbuzz"); }
               
            
            }

            Console.ReadLine();

        }
    }
}
