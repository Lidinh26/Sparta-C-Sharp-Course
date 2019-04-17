using System;
using Labs_04_dll;

namespace Labs_04_use_dll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Reading from another library");
            var item = new Li_library();
            item.LisData = "some data here";
            Console.WriteLine(item.LisData);
            Console.WriteLine(item.LisFixedData);

            Console.ReadLine();

        }
    }
}
