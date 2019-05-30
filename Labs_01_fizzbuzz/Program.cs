using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_01_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //count to 100
            //start from 1, up to 100, increment by 1
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0) { Console.WriteLine("fizz"); }
                if (i % 5 == 0) { Console.WriteLine("buzz"); }
                if (i % 15 == 0) { Console.WriteLine("fizzbuzz"); }
            }

            string reverse = "Reverse me";

            char[] myArray = reverse.ToCharArray();
            Array.Reverse(myArray);

            Console.WriteLine(myArray);

            string[] friends = new string[5] { "Hi", "hi", "hi", "hi", "hi" };
            //You need to tell C# how many elements the array can hold
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Kim";
            friends[3] = "Tony";
            friends[4] = "Jenny";

            string sampleString1 = "SomeString1";
            String empty = string.Empty; //This tells the user that the string in empty

            if (string.IsNullOrEmpty(empty)) //This checks if the string is empty
            {
                Console.WriteLine("String is Empty");
            }


            Dictionary<string, int> Customers = new Dictionary<string, int>();
            Customers.Add("", 30);
            Customers.Add("", 30);
            
            foreach (var item in Customers)
            {
                Console.WriteLine(item);
            }



        }
    }
}
