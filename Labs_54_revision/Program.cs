using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_54_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            var c = new Child();
            p.HaveParty();
            c.HaveParty();
            var c1 = new Child1();
            c1.HaveParty();
            var c2 = new Child2();
            c2.HaveParty();
            var c3 = new Child3();
            c3.HaveParty();
            var c4 = new Child4();
            c4.HaveParty();
        }

    }

    public class Parent
    {
        public virtual void HaveParty() { Console.WriteLine("Parent is partying"); }
    }
    public class Child : Parent
    {
        public override void HaveParty() { Console.WriteLine("Child is swimming"); }

    }
    public class Child1 : Parent
    {
        public override void HaveParty() { Console.WriteLine("Child is killing"); }

    }
    public class Child2 : Parent
    {
        public override void HaveParty() { Console.WriteLine("Child is eating"); }

    }
    public class Child3 : Parent
    {
        public override void HaveParty() { Console.WriteLine("Child is peeing"); }

    }
    public class Child4 : Parent
    {
        public override void HaveParty() { Console.WriteLine("Child is walking"); }

    }


}

    
