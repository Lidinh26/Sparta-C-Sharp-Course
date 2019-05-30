using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_82_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTHis();
            Console.WriteLine($"AlsoDoThis = {AlsoDoThis()}");

            int output = AndThis(out string y);

            Console.WriteLine($"AndThis: {output,-10}{y}");

            int number1 = JustDoIt(1, 2);
            int number2 = JustDoIt(1, 2, 3);

            Console.WriteLine($"JustDoIt = {number1}");
            Console.WriteLine($"JustDoItOverload = {number2}");

            var tupleoutput = TupleThis(); //THis way isnt so great to print out tuple
            Console.WriteLine(tupleoutput.Item1);
            Console.WriteLine(tupleoutput.Item2);

            var tuplerightway = TupleThisAlso();
            Console.WriteLine(tuplerightway.NumberA);
            Console.WriteLine(tuplerightway.StringB);
        }

        static void DoTHis()
        {
            Console.WriteLine("I am doing nothing");
        }

        static int AlsoDoThis()
        {
            return -1;
        }

        static int AndThis(out string y)
        {
            y = "Returning this string";
            return -100;
        }

        static int JustDoIt(int num1, int num2)
        {
            return num1 + num2;
        }

        static int JustDoIt(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;

        }

        static (int,string) TupleThis()
        {
            return (22, "and some text");
        }

        static (int NumberA, string StringB) TupleThisAlso()
        {
            return (22, "and more text also");
        }
    }
}
