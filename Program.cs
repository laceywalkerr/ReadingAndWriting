using System;

namespace Chapter8ReadingAndWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The quick brown");
            Console.WriteLine("fox jumps");
            Console.Write("over the");
            Console.WriteLine("lazy dog");
            Console.WriteLine("");
            string input = Console.ReadLine();
        }
    }
}