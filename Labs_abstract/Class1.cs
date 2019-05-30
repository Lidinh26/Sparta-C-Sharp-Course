using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_abstract
{
    public class Class1 { }


}

class parent
{
    public string name;
    public int age { get; set; }

    public void SayHi()
    {
        Console.WriteLine("Say hello");
    }

}

class child : parent
{
    public void cry()
    {
        Console.WriteLine("Child is crying");
    }
}

