using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_63_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fruit.apple);

            //Enum is a structure to hold values which are not expected to change

            Console.WriteLine((int)Fruit.count);

            //You can also use cast and use integers 

            Console.WriteLine($"There are {(int)Fruit.count} types of fruit");

            //and count how many in the enum4
        }
    }

    enum Fruit
    {
        banana, apple, pear, plum, peach, count
    }
}
