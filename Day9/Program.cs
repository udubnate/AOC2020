using System;

namespace Day9
{
    class Program
    {
        static int preamble = 5;

        static void Main(string[] args)
        {
           var input = new Input("sample.txt");
           var list = input.Parse();
           
            Part1 p1 = new Part1(list, preamble);
            var output = p1.Execute();
            Console.WriteLine(output);

        }
    }
}
