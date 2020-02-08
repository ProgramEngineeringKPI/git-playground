using System;

namespace NiceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm doing some very important stuff!");

            var fileReader = new TextFileReader("../../../input.txt");
            
            var stuff = new ImportantStuff();
            var result = stuff.DoWhatNeedsToBeDone(fileReader);
            
            Console.WriteLine($"Result is {result}");
        }
    }
}