using System;
using System.Collections.Generic;

namespace Day13
{
    class Program
    {
       static readonly string FilePath = "input.txt";
        static void Main(string[] args)
        {
           var input = new Input(FilePath);
           var list = input.Parse();
           
            //Part1 p1 = new Part1(list);
            //p1.Execute();
            //Console.WriteLine(p1);

            Part2 p2 = new Part2(list);
            p2.Execute();
            Console.WriteLine(p2);
        }
    }
}
