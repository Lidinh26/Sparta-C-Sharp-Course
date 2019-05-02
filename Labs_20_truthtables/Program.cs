using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_20_truthtables
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND

            Console.WriteLine(1&1);
            Console.WriteLine(0&0);
            Console.WriteLine(1&0);
            Console.WriteLine(0&1);

            // OR

            Console.WriteLine(1|1);
            Console.WriteLine(0|0);
            Console.WriteLine(1|0);
            Console.WriteLine(0|1);

            Console.WriteLine(true&&true); 
            Console.WriteLine(false&true);

            //XOR
            Console.WriteLine(1^1); //false
            Console.WriteLine(1^0); //true


        }
    }
}
