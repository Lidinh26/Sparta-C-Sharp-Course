using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Homework_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //For loop using array
            int[] myArray2 = new int[] { 10, 20, 30 };
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myArray2[i]);
            }
            Console.ReadLine();


            //Foreach loop using array
            int[] numbers1 = new int[] {10,40,50 };

            foreach (int Numbers in numbers1)
            {
                Console.WriteLine(Numbers);
            }
            Console.ReadLine();

            //While loop using array 

            int number = 0;

            while( number < 10)
            {
                Console.WriteLine(number);
                number++;
                Console.ReadLine();
            }

            int calculations = 0;
            do
            {
                Console.WriteLine(calculations);
                calculations++;
            }

            while (calculations < 10);

            Console.ReadLine();
            





            /* for (int i = 0; i < length; i++)
             {

             }


             //Exercise 2
             int[] myArray = new int[1000];

             for (int i = 0; i < myArray.Length; i++)
             {
                 Console.WriteLine(i);
             }
















             List<int> number = new List<int>(1000);

             for (int i = 0; i < number.Count; i++)
                 {

                 }

             Console.WriteLine(number); */
        }
    }
}
