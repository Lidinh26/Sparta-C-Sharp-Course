using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> mylist = new List<int>();

            // adding items in mylist 
            for (int i = 1; i < 10; i++)
            {
                mylist.Add(i);
            }

            // Displaying items of mylist 
            // by using foreach loop 
            foreach (int items in mylist)
            {
                Console.WriteLine(items);
            }
        }
    }
}

