using System;
using System.IO;
using HelloWorld.math;
namespace HelloWorld
{
    

    class Program
    {
        static void Main(string[] args)
        {
           var cookie = new HttpCookie();
           cookie["name"] = "Tiago";
           System.Console.WriteLine(cookie["name"]);

        }
    }
}