using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int [4];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;

            foreach (var item in myArray)
            {
                Console.WriteLine(item);

            }

            /*int[,] my2DArray = new int[5,5];
            my2DArray[0,0] = 1;
            my2DArray[0,1] = 2;
            my2DArray[0,3] = 3;
            my2DArray[0,4] = 4;
            my2DArray[0,5] = 4;
            my2DArray[1,0] = 4;
            my2DArray[1,1] = 4;
            my2DArray[1,2] = 4;
            my2DArray[1,3] = 4;
            my2DArray[1,4] = 4;
            my2DArray[1,5] = 100;
         

            foreach (var twoD in my2DArray)
            {
                Console.WriteLine(twoD);

            }*/
            int number = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
}

