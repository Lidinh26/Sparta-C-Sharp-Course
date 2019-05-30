using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_73_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 7;
            // x = "Hi" Invaid

            dynamic y = 7;

            y = "Hi";
            y = true;
            y = new int[10];

            Console.WriteLine(y.gettype);
        }
    }
}
