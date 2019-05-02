using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_labs_test
{
    class Program
    {
        static int[] array;

        static Queue<int> queue = new Queue<int>();

        static List<int> list = new List<int>();

        static Stack<int> stack = new Stack<int>();

        static Dictionary<int, int> dictionary = new Dictionary<int, int>();
        static void Main(string[] args)
        {

            /*Build an array, queue, list, stack and dictionary.  Pass in 3 numbers to the array.  Pass the numbers in turn to the queue,
            list, stack and dictionary, and whenever you transfer a number also multiply it by 2. */


            array = new int[3] {2, 30, 30};

            foreach (int item in array)
            {
                queue.Enqueue(item * 2);
            }

            while (queue.Count > 0)
            {
                list.Add(queue.Dequeue() * 2);
            }

            foreach (int item in list)
            {
                stack.Push(item * 2);
            }

            for (int i = 0; i < 3; i++)
            {
                dictionary[i] = stack.Pop() * 2;
            }

            var total = 0;
            foreach (var key in dictionary.Keys)
            {
                total += dictionary[key];
            }

            Console.WriteLine(total);
        }

    }
}
