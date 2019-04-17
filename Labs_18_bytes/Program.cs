using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_18_bytes
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = 0b10101010; //Latest c# has literal binary type

            //also can use hex

            byte bb = 0xff; //f=15 decimal = 111 binary 

            char c = 'f';

            Console.WriteLine(c);
            //convert to a number using (int) (casting)
            Console.WriteLine((int)c);

            char c02 = 'g';
            Console.WriteLine(c02);
            Console.WriteLine((int)c02);

            char c03 = (char)104;
            Console.WriteLine(c03);

            string s = "abcdef";
            foreach (char item in s)
            {
                Console.WriteLine(item);

            }



        }

     



    }

}
