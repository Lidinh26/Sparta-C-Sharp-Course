using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_59_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new child();
            c.property01 = 10;
            c.useThisTool02();
        }
    }


    interface IDoThis01
    {
        int property01 { get; set; }
        void useThisTool02();
    }
    interface IDoThis02
    {
        void useThisTool02();
    }

    class parent{ }

    class child : parent, IDoThis01, IDoThis02
    {
        public int property01 { get; set; }
        public void useThisTool02() { }
    }
}
