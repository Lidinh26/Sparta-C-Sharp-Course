using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_21_review
{
    class Program
    {
        static void Main(string[] args)
        {

            Method1();

            Method2(100);

            Method03(5); // not using 25 here
            var outputNumber = Method03(5); //25
        }

        static void Method1()
        {

        }

        static void Method2(int x)
        {

        }


        static int Method03(int x)
        {
         

            return x * x;
        }
    }





}
