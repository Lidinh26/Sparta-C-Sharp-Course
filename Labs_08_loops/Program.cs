using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_08_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //FOR
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Your numnber is {i}");
                Console.WriteLine($"Number squared is {i * i}");

                //WHILE
            }
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"while loop : number is {counter}");
                counter = counter + 1;
            }

            //DO..WHILE
            counter = 0;
            do
            {
                Console.WriteLine($"Do..While : number is {counter}");
                counter++;
            }
            while (counter < 10);


            // ARRAY

            // ARRAY is a FIXED-SIZE STRUCTURE which is very fast to access.

            //DECLARE
            int[] myIntegerArray = new int[10]; //size has 10 boxes for integers
            string[] myStringArrray = new string[10]; //size has 10 boxes for strings

            //ACCESS FOR ONE ITEM

            //FIRST ITEM HAS INDEX 0
            myIntegerArray[0] = 100;
            myIntegerArray[1] = 101;
            myIntegerArray[2] = 102;
            myIntegerArray[3] = 103;
            myIntegerArray[4] = 104;
            myIntegerArray[5] = 105;

            //LAST ITEM : INDEX = SIZE-1 IE 10-1 = [9]
            myIntegerArray[9] = 999;

            //FOREACH: COUNT OVER EVERY ITEM IN ARRAY
            foreach (int item in myIntegerArray)
            {
                Console.WriteLine($"Item in array is {item}");

            }

            // REPEAT FOR STRING ARRAY
            string[] myStringArray = new string[3];
            myStringArray[0] = "Hello";
            myStringArray[1] = "You";
            myStringArray[2] = "Smell";

            foreach (string item in myStringArray)
            {
                Console.WriteLine($"Item in array is {item}");

            }

            // 10-MINUTE LAB : BUILD FOR THEN WHILE LOOPS TO COUNT TO 1000

            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"For loop to 1000 {i}");

            }

            int count = 0;
            while (count <= 1000)
            {
                Console.WriteLine($"While loop to 1000 {count}");
                // count = count + 1;
                //OR count++ for increment by 1


            }
            // FILL ARRAY WITH 1000 NUMBERS AND PRINTS OUT ALSO
            //VAR - Any variable type - let the computer decide
            var myLargeArray = new int[1000];
            for (int i =0; i <myLargeArray.Length; i++)
            {

                //fill the array
                myLargeArray[i] = i;
                                             
            }

            

            }
        }
    }