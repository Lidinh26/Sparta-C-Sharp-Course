using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labs_45_file_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            // Read 1 line of text as a string 
            //string data = File.ReadAllText("File.txt");
            //Console.WriteLine(data);

            //write data - DELETS OLD TEXT AND WRITES NEW TEXT
            Console.WriteLine("\n\nwriting new ");
            File.WriteAllText("file.txt", "Hello");

            Console.WriteLine("\n\nreading text back again");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            //append : adds at the end
            Console.WriteLine("\n\nAppending Text");
            File.AppendAllText("file.txt", $"{Environment.NewLine}name here is some data 2 - {DateTime.Now}");
            File.AppendAllText("file.txt", $"{Environment.NewLine}name here is some data 3");
            File.AppendAllText("file.txt", $"{Environment.NewLine}name here is some data 4");
            File.AppendAllText("file.txt", $"{Environment.NewLine}name here is some data 5");
            File.AppendAllText("file.txt", $"{Environment.NewLine}name here is some data 6");
            File.AppendAllText("file.txt", "\nsearchterm22");
            data = File.ReadAllText("file.txt");
            Console.WriteLine(data);

            /*   //data logging : used all the time - add a datatime.now
               Console.WriteLine("\n\nLogging With DateTime Stamp");
               File.AppendAllText("file.txt", "\n" + DateTime.Now.ToString());
               data = File.ReadAllText("file.txt");
               Console.WriteLine(data);

               //data logging : used all the time - add a datatime.now part 2
               Console.WriteLine("\n\nAppending Text");
               File.AppendAllText("file.txt", "\nand here is some more data 2 " + DateTime.Now.ToString());
               File.AppendAllText("file.txt", "\nand here is some more data 3 " + DateTime.Now.ToString());
               File.AppendAllText("file.txt", "\nand here is some more data 4 " + DateTime.Now.ToString());
               File.AppendAllText("file.txt", "\nand here is some more data 5 " + DateTime.Now.ToString());
               File.AppendAllText("file.txt", "\nand here is some more data 6 " + DateTime.Now.ToString());
               data = File.ReadAllText("file.txt");
               Console.WriteLine(data);



               // reading multiple lines to an array
               Console.WriteLine("\n\nSearching text file for a term");
               string[] dataArray = File.ReadAllLines("file.txt");
               foreach (string item in dataArray)
               {
                   if (item == "searchterm22")
                   {
                       Console.WriteLine("Bingo ! searchterm22 has been found!");

                   }
               }
                for (int i = 0; i < dataArray.Length; i++)
                       {

                           if (dataArray[i] == "searchterm22") {
#

                               Console.WriteLine($"Bingo! {i}");
                           }

                       }

       */

            //file.copy

            //File.WriteAllText("file.txt", "some data");

            // File.Copy("file.txt", "filecopy.txt", true);

            //File.Delete("filecopy.txt");

            //File.Move("file.txt", "filecopynewname.txt");

            /* if (!File.Exists("file.copynewname.txt"))
             {

                 File.Move("filecopy.txt", "filecopynewname.txt");
             }

             }*/

            Console.WriteLine(File.GetCreationTime("filecopynewname.txt"));
            Console.WriteLine(File.GetLastWriteTime("filecopynewname.txt"));

            //MAKE A NEW FOLDER
            Directory.CreateDirectory("Parent");
            Directory.CreateDirectory("Parent\\child1");
            Directory.CreateDirectory("Parent\\child2");
            Directory.CreateDirectory("Parent\\child3");
            File.WriteAllText("Parent\\child1\\file.txt", "hello");
            File.WriteAllText("Parent\\child3\\file.txt", "hello");


            //DELETE FOLDER
            Directory.Delete("Parent/Child2", true);

            //create new folder in c:\ drive

            Directory.CreateDirectory("/Testfolder");

            //create in MyDocuments
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/test folder");



        }


    }
}

        
    

