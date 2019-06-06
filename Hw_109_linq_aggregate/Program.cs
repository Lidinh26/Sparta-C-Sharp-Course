using System;
using System.Linq;

namespace Hw_109_linq_aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class LINQAggregate
    {
        public static int LINQAggregateSum(int[] array)
        {
            // Use LINQ Aggregate to sum all the members of an array
            //e.g aray[1,2,3]

            int sum = array.Aggregate((a, b) => a + b);
            return sum;
        }

        public static string[] LINQUnion(string[] array1, string[] array2)
        {
            ////Use LINQ Union to join 2 arrays and eliminate duplicates


            var result = array1.Union(array2).ToArray();

            return result;
        }


        // Repeat for LINQ Intersection : Show items common to both sets

        public static string[] LINQIntersect(string[] array1, string[] array2)
        {
            // Repeat for LINQ Intersection : Show items common to both sets

            var result = array1.Intersect(array2).ToArray();

            return result;
        }

    }

    public class ProjectB
    {
        public static int[] ProjectBUnion(int[] array1, int[] array2)
        {
            return array1.Union(array2).ToArray();
        }
    }
}
