using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_32_bodmas_bidmas_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Take a number and add 15 to that number, multiply the total by 3 and divide by 4,
            //then multiply the result by the square of that number. Round till 4 decimals, don't lose any fractions.


            Double x = 100.0565645;
            var answer =(((x + 15) * 3)/ 4);
            var answer2 = (Math.Pow(answer, 2));    //Math
            Console.WriteLine((Math.Round(answer2, 4)));
            
            //Divide the year you born with by the month you born in, then multiply by the cube of the day you're
            //born on. Note: when you upload this to GitHub, you might, for privacy reasons, want to change the date to a random date.

            Console.WriteLine((Math.Pow(21, 3) * 1607 / 12));


            //If you drive somewhere with a certain speed and it takes you 1.5 hour to reach your destination, how long will it
            //take if you increase your speed by 15 %? 75 %?

            double oldtime = 90; 

            //var fifthteen = speed * 1.15; 
            //var seventy = speed * 1.75;

            var newTime1 = oldtime / 1.15;
            var newTime2 = oldtime / 1.75;

            Console.WriteLine((Math.Round(newTime1, 2)));
            Console.WriteLine((Math.Round(newTime2, 2)));








        }
    }
}
