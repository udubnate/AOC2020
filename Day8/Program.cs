using System;
using System.Collections.Generic;
using System.IO;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string FilePath = "sample.txt";
            List<OpCode> InstructionSet = new List<OpCode>();

            //using statement to close out streamReader after use
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    //end with EOF
                    if (string.IsNullOrEmpty(line)) break;

                    string[] codes = line.Split(' ');
                    int value = Convert.ToInt32(codes[1]);
                    OpCode op1 = new OpCode(codes[0], value);
                    InstructionSet.Add(op1);
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
