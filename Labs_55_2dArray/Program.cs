using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_55_2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1D = new int[] { 10, 20, 30 }; //literal
            var array1Da = new int[10];

            Console.WriteLine(array1Da[0]); //first item
            Console.WriteLine(array1Da[array1Da.Length-1]); // last item

            int[,] array2D = new int[5, 5]; //5x5 grid
            //2nd row and 3rd column
            //2nd row has index 1, 3rd column has index 2
            Console.WriteLine(array2D[1, 2]);

            int[,,] array3D = new int[5, 5, 5];
            //row 3, col4, height 5
            Console.WriteLine(array3D[2,3,4]);

        }
    }
}
