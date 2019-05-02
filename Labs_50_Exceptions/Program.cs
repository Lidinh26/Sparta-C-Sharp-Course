using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_50_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try { }
            // something can go wrong here
            catch { }
            // process the 'exception' i.e 'handle it'
            finally { }
            // always do this code regardless if exception or not

            int x = 10, y = 0;

            
            try
            {
                int z = x / y;

            }

            //catch devide by zero exception only
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Error - division by zero");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }

            //catch every exception of all types
            catch (Exception e)
            {
                Console.WriteLine("OOPS! SNAP! Something went wrong!");
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }

            finally
            {

                Console.WriteLine("But program is still working");
            }

            Console.WriteLine("Program still works here");
        }
    }
}
