using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_code_challenege2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a operator: ");
            string OP = (Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (OP == "/")
            {
                Console.WriteLine("Your answer is: " + num1 / num2);
            }
            else if (OP == "*")
            {
                Console.WriteLine("Your answer is: " + num1 * num2);

            }
            else if (OP == "+")
            {
                Console.WriteLine("Your answer is: " + num1 + num2);
            }
            
            else Console.WriteLine("Wrong operator");

        }
    }
}
