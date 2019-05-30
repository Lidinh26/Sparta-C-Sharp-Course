using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_64_base
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new parent();
            p1.DoThis();

            var c1 = new Child();
            c1.DoThis();

        }

    }

    class parent
    {
        public virtual void DoThis()
        {
            Console.WriteLine("I'm in the parents");
        }
    }

    class Child : parent
    {
        public override void DoThis()
        {
            base.DoThis();
            Console.WriteLine("I'm in the child");
        }
    }
}
