using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labs_46_file_operator_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var mydocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Directory.CreateDirectory(mydocuments + "/test lab");


            var filelist = Directory.EnumerateFiles(mydocuments) + "/test lab";

            var bobisthere = false;

            foreach (var item in filelist)
            {
                Console.WriteLine(mydocuments + "/test lab\\bobfile.txt");
                Console.WriteLine(item);
             //   if (item == (mydocuments + "/test lab\\bobfile.txt"))
                {
                    Console.WriteLine("Bobby is here");
                }
               // else
                    Console.WriteLine("bobbly is not here");
            }
            
        }
    }
}
