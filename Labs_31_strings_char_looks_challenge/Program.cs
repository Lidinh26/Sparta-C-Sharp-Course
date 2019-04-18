using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_31_strings_char_looks_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 256; i++)
            {
                Console.WriteLine($"{i} = {(char)i}"); //casting - changing a int to a char

            }
        }
    }
}
