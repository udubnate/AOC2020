using System;

namespace Day10
{
    class Program
    {
        static readonly string FilePath = "Day10.txt";
        static void Main(string[] args)
        {
           var input = new Input(FilePath);
           var list = input.Parse();
           
            Part1 p1 = new Part1(list);
            var output = p1.Execute();
            Console.WriteLine(output);

            Part2 p2 = new Part2(list);
            var part2 = p2.Execute();
            Console.WriteLine(part2);
        }

    }
}
