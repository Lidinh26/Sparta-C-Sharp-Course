using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;



namespace Rabbit_explosion_game
{
    public class Program
    {
        static List<Rabbit> RabbitList;
        static void Main(string[] args)
        {
            Console.WriteLine($"The number of rabbits is: {RabbitCounter(20)[20]}");
            Process.Start("RABBIT EXPLOSION!!!!!!!!.csv");

        }

        /// <summary>
        /// We created a rabbit counter
        /// </summary>
        /// <param name="seconds">How many seconds we want the counter to run</param>
        /// <returns>The number of rabbits when we want the counter to end</returns>
        public static ArrayList RabbitCounter(int maxTime)
        {
            int populationLimit = 100000;
            ArrayList myRabbitArray = new ArrayList();

            // Write header to CSV file
            File.WriteAllText("RABBIT EXPLOSION!!!!!!!!.csv", "Time (seconds),Population");


            RabbitList = new List<Rabbit>();
            RabbitList.Add(new Rabbit());
            RabbitList.Add(new Rabbit());

            //Add the first population to the ArrayList
            myRabbitArray.Add(RabbitList.Count);

            int seconds = 0;

            while (seconds <maxTime)
            {
                //Write time and population to CSV files
                File.AppendAllText("RABBIT EXPLOSION!!!!!!!!.csv", $"\n{seconds},{RabbitList.Count}");

                System.Threading.Thread.Sleep(10);
                ++seconds;

                List<Rabbit> babyRabbits = new List<Rabbit>();
                foreach (var item in RabbitList)
                {
                    if(RabbitList.Count + babyRabbits.Count >= populationLimit)
                    {
                        break;
                    }
                    babyRabbits.Add(new Rabbit());
                }
                RabbitList.AddRange(babyRabbits);
                Console.WriteLine("Breading rabbits");

                myRabbitArray.Add(RabbitList.Count);
                // Add new population size to arrayList

            }
            //Write final population to file
            File.AppendAllText("RABBIT EXPLOSION!!!!!!!!.csv", $"\n{seconds},{RabbitList.Count}");

            return myRabbitArray;
        }
    }

    class Rabbit
    {

    }
}
