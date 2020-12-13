using System;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ParseInput.Parse("Day7input.txt");
            string day7p1 = Day7.Day7Part1.Run(input);

            Console.WriteLine("Hello World!");
        }
    }
}
