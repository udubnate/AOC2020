using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Day8.OpCode;

namespace Day8
{
    class Program
    {

        static string FilePath = "Day8input.txt";
        static List<Run> generateRuns(List<OpCode> InstructionSet)
        {
            var Runs = new List<Run>();
            Queue<int> jmpop = new Queue<int>();
            int idx = 0;
            foreach (OpCode op in InstructionSet)
            {
                if (op.Op == Operation.nop || op.Op == Operation.jmp)
                {
                    jmpop.Enqueue(idx);
                }
                idx++;
            }
            while (jmpop.Count != 0)
            {
                List<OpCode> oplist = new List<OpCode>();
                int index = jmpop.Dequeue();
                int loopcount = 0;
                foreach (OpCode op1 in InstructionSet)
                {
                    OpCode newOp = new OpCode(op1.Op, op1.Argument);
                    if (index == loopcount)
                    {
                        if (newOp.Op == Operation.nop)
                        {
                            newOp.Op = Operation.jmp;
                        }
                        else if (newOp.Op == Operation.jmp)
                        {
                            newOp.Op = Operation.nop;
                        }
                    }
                    oplist.Add(newOp);
                    loopcount++;
                }
                Runs.Add(new Run(oplist, index));
            }

            return Runs;
            // throw new InvalidOperationException("Code isn't written");

        }

        static int Execute(List<OpCode> InstructionSet)
        {
            //Execute instruction set
            int curpos = 0;
            int accumulator = 0;
            while (curpos < InstructionSet.Count)
            {
                OpCode curOpCode = InstructionSet[curpos];

                if (curOpCode.Visited)
                {
                    return -1;
                }
                else
                {
                    curOpCode.Visited = true;
                }

                switch (curOpCode.Op)
                {
                    case OpCode.Operation.acc:
                        accumulator += curOpCode.Argument;
                        curpos += 1;
                        break;
                    case OpCode.Operation.jmp:
                        curpos += curOpCode.Argument;
                        break;
                    case OpCode.Operation.nop:
                        curpos += 1;
                        break;
                    default:
                        Console.WriteLine("Operation underknown");
                        break;
                }
            }
            return accumulator;
        }
        static void Main(string[] args)
        {


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
                    Operation oper = (Operation)Enum.Parse(typeof(Operation), codes[0], true);
                    OpCode op1 = new OpCode(oper, value);
                    InstructionSet.Add(op1);
                }
            }
            //part2
            var Runs = generateRuns(InstructionSet);

            foreach (Run run in Runs)
            {
                int val = Execute(run.ListOps);
                if (val != -1){
                Console.WriteLine(run.LineNumber);
                Console.WriteLine("Current acc: " + val);
                }
            }


            Console.WriteLine("Hello World!");
        }
    }
}
