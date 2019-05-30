using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_65_base_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("Li", 27);
            var c = new Parent("Carmen", 24);
        }
    }

    class Parent
    {
        string name;
        int age;

        public Parent(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Parent() { }

        class Child : Parent
        {
            public Child(string name, int age) : base() { }
        }
    }
}
