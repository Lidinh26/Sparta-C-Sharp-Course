using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_10_bodmas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bracket, operator/indexes, dm, as
            //Got to get your BODMAS clear!! always divide first
            // 96 + 20 / 5 - 77 / 11 
            //96 + 4 - 7 = 93

            var FiveSquared = Math.Pow(5, 2);
            var ThirteenCubed = Math.Pow(13, 3);

            Console.WriteLine(FiveSquared * ThirteenCubed - (7 / 4.0));

            Console.WriteLine(100/8); // WRONG 
            Console.WriteLine(100/8.0); //12.5 CORRECT
            Console.WriteLine(100%8); // 4 REMAINDER CORRECT

        }
    }
}
