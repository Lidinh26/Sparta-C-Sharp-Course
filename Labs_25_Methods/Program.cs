using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_25_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Method is a function we can call#
           
           void DoThis()
            {
                Console.WriteLine("I am doing something");
      
            }
            DoThis();


            void DoThis2()
            {
                Console.WriteLine("I am doing something!!!!");

            }
            DoThis2();

            void DoThis3()
            {
                Console.WriteLine("I am doing something");

            }
            DoThis3();

            void DoThis4()
            {
                Console.WriteLine("I am doing something");

            }
            DoThis4();

            void DoThis5()
            {
                Console.WriteLine("I am doing something");

            }
            DoThis5();

            for (int i = 1; i < 5; i++)
            {

                DoThis();

            }

        }
    }
}
