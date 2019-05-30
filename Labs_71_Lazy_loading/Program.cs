using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_71_Lazy_loading
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int [3] { 1, 2, 3 };

            var output =
                from item in myarray
                select item;

            //lazy loading so query not actually run yet
            //prove this by updating the array first

            myarray[1] = 2000000;

            //now lets read the query
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            //force query to run immediately (IMMEDIATE EXECUTION) .ToList() or similar
            //Also if outout just a scalar number eg output.count ==> run immediately
        }
    }
}
