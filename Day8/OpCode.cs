using System;

namespace Day8
{
    class OpCode
    {
        public string Operation { get; set; }
        public int Argument { get; set; }
        public bool Visited {get ; set; }
        
        public OpCode(string operation, int argument){
            this.Operation = operation;
            this.Argument = argument;
            Visited = false;
        }
    }
}
