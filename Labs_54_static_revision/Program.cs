using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_54_static_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object which is called 'instance'
            var d1 = new Dog();
            d1.bark();
            d1.Age = 5;
            List<Dog> doglist = new List<Dog>();
            for (int i = 0; i < 1000; i++)
            {
                doglist.Add(new Dog());
                //or
                var d = new Dog();
                d.Age = 4;
                doglist.Add(d);
            }
        }
    }
    //class is a blueprint for creating dogs (objects which we call dog)
    class Dog
    {
        public int _private; //field
        //public static int numLegs = 4; //This is now attached to the dog class because its static //access via Dog.numLegs
        public static readonly int numLegs = 4;

        //if you tried to write d1.numLegs it wouldnt work. Need to use the dog class


        public int Age { get; set; } //instance field


        public void bark() { } //instance method

        //property with validation code
        public int Agee
        {
            get
            {
                return Agee;
            }
            set
            {
                if (Agee > 0)
                {
                    this.Agee = value;
                }

            }
        }

    }

}
