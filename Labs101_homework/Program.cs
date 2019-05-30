using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs101_homework
{
    class Program
    {
        static void Main(string[] args)
        {

        }


       
    }


    public class Collections
    {
        public static int UseCollections(int a, int b, int c, int d, int e)
        {

            //create a list with these 5 items
            var list = new List<int>(){a, b, c, d, e};
            var stack = new Stack<int>();
            var queue = new Queue<int>();

            

            for (int i =0; i <list.Count; i++)
            {
                //iterate over this list : multiply each item by 2: add to a stack

                stack.Push(2 * list[i]);
            }


            // Iterate over the stack : add 10 to each numbner : add to a queue
            while(stack.Count != 0)
            {

                queue.Enqueue(10 + stack.Pop());
            }

            //Iterate over the queue: return total

            var sum = 0;

            while(queue.Count != 0)
            {

                sum += queue.Dequeue();

            }

            return sum;



        }
    }
}
