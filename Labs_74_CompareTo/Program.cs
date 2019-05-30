using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_74_CompareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hi";
            string y = "The";
            var output = x.CompareTo(y);
            var output2 = y.CompareTo(x);
            var output3 = x.CompareTo(x);
            Console.WriteLine($"{output}\n{output2}\n{output3}");

            var a = new Custom();
            var b = new Custom();
            var output4 = a.CompareTo(b);

            Console.WriteLine(output4);
        }

        class Custom : IComparable //IComparer for array // IComparable 
            
        {
            public int property01 { get; set; }
            public int CompareTo(object obj)
            {
                return -1;
            }
        }
    }
}
