using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_27_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            var car01 = new Mercedes();
            car01.Speed = 10;
            // pass in old and get out new speed
            var increaseSpeed = car01.Acceleration(car01.Speed);
            Console.WriteLine(increaseSpeed);
            increaseSpeed = car01.Acceleration(car01.Speed);
            Console.WriteLine(increaseSpeed);
            increaseSpeed = car01.Acceleration(car01.Speed);
            Console.WriteLine(increaseSpeed);
            increaseSpeed = car01.Acceleration(car01.Speed);
            Console.WriteLine(increaseSpeed);
            increaseSpeed = car01.Acceleration(car01.Speed);

        }
    }
    class Mercedes
    {
        public int Speed;

        public int Acceleration(int oldSpeed)

        {
            oldSpeed++;
            Speed = oldSpeed;
            return Speed;
           

        }


    }
        
        
}
