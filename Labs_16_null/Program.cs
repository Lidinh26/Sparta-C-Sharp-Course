using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_16_null
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = null;
            string y = " ";
            Console.WriteLine(x == y); //false

            // If reading from the database and there literally is no data coming in, then thats a null

            //integers : default value is '0'

            int z = new int();
            Console.WriteLine(z);

            //scenario : reading numbers from a database
            //want to differentiate from '0' and blank space
        }
    }
}
