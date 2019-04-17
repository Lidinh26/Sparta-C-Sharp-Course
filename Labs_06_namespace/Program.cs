using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Li;
using Li2;

namespace Labs_06_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Li.GreaterTrainer();

            var item2 = new GreaterTrainer();

            var item3 = new Li2.ExcellentLearner();
            Console.WriteLine(item3.Learnlots);
        }
    }
}

namespace Li{
    public class GreaterTrainer { }
}

namespace Li2{
    public class ExcellentLearner
    {
    public string Learnlots = "running c#";


    }

}