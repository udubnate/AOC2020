using System;

namespace Day9
{
    class Program
    {
        static readonly int preamble = 25;
        static readonly string FilePath = "day9.txt";
        static void Main(string[] args)
        {
           var input = new Input(FilePath);
           var list = input.Parse();
           
            Part1 p1 = new Part1(list, preamble);
            var output = p1.Execute();
            Console.WriteLine(output);

            Part2 p2 = new Part2(list, output);
            var part2 = p2.Execute();
            Console.WriteLine(part2);

        }
    }
}
