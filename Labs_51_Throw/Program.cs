using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_51_Throw
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var output = TryThis();
                if(output == -1)
                {

                    throw new Exception("Hey something really bad went wrong");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("But program still working!");
            }
            finally
            {

            }

        }
        static int TryThis()
        {

            return -1;
        }
    }
}
