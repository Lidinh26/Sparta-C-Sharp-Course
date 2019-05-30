using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_78_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //t
            var s = new Stopwatch();
            s.Start();
            var t = new Task(
                 () =>
                 {
                     Console.WriteLine("Starting Task Now at time " + s.ElapsedTicks);
                     System.Threading.Thread.Sleep(1000);
                     Console.WriteLine($"Finishing task at time {s.ElapsedTicks}");
                 });

            t.Start();
            Console.WriteLine($"Program has finished at time {s.ElapsedTicks}");
            //Console.ReadLine();
            //Declare and start with the Run() command
            var t02 = Task.Run(
                // This thing is a "delegate" which is a placeholder for a method
                () =>
                {
                    Console.WriteLine($"Running Task t02 at time {s.ElapsedTicks}");
                });

            //Older ways of doing this

            //Action delegate

            var t03 = Task.Run(
                new Action(Method01)

            );

            //another older way : explicitly using the 'delegate' keyword
            //anonymous delegate with the 'delegate' keyword

            var t04 = Task.Run(
                delegate
                {
                    Console.WriteLine($"In task t04 with anon delegate at {s.ElapsedTicks}");
                }

                );

            //last older way : Task.factory

            var t05 = Task.Factory.StartNew(() => { Console.WriteLine($"In task 05"); });

            Console.ReadLine();
        }

        static void Method01()
        {
            Console.WriteLine("In Method01");

        }

    }
}


