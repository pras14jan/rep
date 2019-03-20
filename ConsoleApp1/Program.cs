using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            ProcessCalculate pc = new ProcessCalculate();

            Console.WriteLine("Hello World!");
            var l = new List<string>();
            l= pc.Execute();
            for (int i=1; i<= l.Count(); i++)
            {
                Console.WriteLine(l);
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
