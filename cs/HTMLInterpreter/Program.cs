using System;
using System.IO;
using HtmlAgilityPack;

namespace HTMLInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"test.html";

            HTMLInterpreter htmlInterpreter = new HTMLInterpreter();

            Console.WriteLine(htmlInterpreter.ApplyPermissions(File.ReadAllText(path)));
            Console.ReadLine();
        }
    }
}
