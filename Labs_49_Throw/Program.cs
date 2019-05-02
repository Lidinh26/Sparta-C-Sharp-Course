using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_49_Throw
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            while (true)
            {

                counter++;

                if (counter > 100000)
                {

                    throw new Exception("number is too big");
                }
            }

        }
    }
}
