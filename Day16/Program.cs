using System;

namespace Day16
{
    class Program
    {
         class Program
        {
         static readonly string FilePath = "Day15.txt";
         static readonly long StopAt = 30000000;
        static void Main(string[] args)
        {
           var input = new Input(FilePath);
           var list = input.Parse();

            Part1 p1 = new Part1(list);
           // var output = p1.Execute(StopAt);
           // Console.WriteLine(output);

            Part2 p2 = new Part2(list);
            var part2 = p2.Execute(StopAt);
            Console.WriteLine(part2);
        }
    }
}
