﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_code_challenege
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }


            string name = "Carmen";

            char[] myArray = name.ToCharArray();

            Array.Reverse(myArray);

            Console.Write(myArray);

            // Reverse("Hello");

            //static string Reverse(string y)
            //{
            //    for (int i = y.Length - 1; i >= 0; i--)
            //    {
            //        Console.WriteLine(y[i]);
            //    }
            //    return y;
            //
        }
    }
}
