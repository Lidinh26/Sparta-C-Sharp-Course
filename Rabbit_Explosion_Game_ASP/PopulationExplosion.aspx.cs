using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rabbit_Explosion_Game_ASP
{

    public partial class PopulationExplosion : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int increase = 0;
            int population = 2;

            do 
            {
              
                population = RabbitCounter(increase);

                increase++;
            }
            while ((Int32.Parse(TextBox1.Text) > population));

            Label1.Text = "\n\nIt takes " + (increase-1) + " seconds to reach a population limit" + " of " + TextBox1.Text + ".";

        }

        /// <summary>
        /// We created a rabbit counter
        /// </summary>
        /// <param name="seconds">How many seconds we want the counter to run</param>
        /// <returns>The number of rabbits when we want the counter to end</returns>
        public static int RabbitCounter(int maxTime)
        {
            List<Rabbit> RabbitList;

            int populationLimit = 100000000;

            RabbitList = new List<Rabbit>();
            RabbitList.Add(new Rabbit());
            RabbitList.Add(new Rabbit());

            int seconds = 0;

            while (seconds < maxTime)
            {
                ++seconds;

                List<Rabbit> babyRabbits = new List<Rabbit>();
                foreach (var item in RabbitList)
                {
                    if (RabbitList.Count + babyRabbits.Count >= populationLimit)
                    {
                        break;
                    }
                    babyRabbits.Add(new Rabbit());
                }
                RabbitList.AddRange(babyRabbits);
            }
            return RabbitList.Count;
        }
    }
    class Rabbit
    {

    }
}