using System;

namespace Day8
{
    class OpCode
    {
        public enum Operation { acc, jmp, nop}

        public Operation Op { get; set; }
        public int Argument { get; set; }
        public bool Visited {get ; set; }
        
        public OpCode(Operation operation, int argument){
            this.Op = operation;
            this.Argument = argument;
            Visited = false;
        }
    }
}
