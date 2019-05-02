using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_56_event
{
    class Program
    {
        //delegate : says that our event can only trigger methods which have a set method

        delegate void MyDelegate(); //pattern : method must be void ...()
        // event uses this delegate
        static event MyDelegate myEvent; // create event; when it triggers any methdods must match this pattern

        static void Main(string[] args)
        {
            //goal: replace manually calling 3 methods with 1 event trigger
            myMethod01();
            myMethod02();
            myMethod03();

            myEvent += myMethod01;
            myEvent();
        }

        static void myMethod01()
        {
            Console.WriteLine("Doing something");
        }
        static void myMethod02()
        {
            Console.WriteLine("Doing something");
        }
        static void myMethod03()
        {
            Console.WriteLine("Doing something");
        }
       
    }
}
