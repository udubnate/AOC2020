using System;
using System.Collections.Generic;

namespace Day8
{
    class Run
    {
        public List<OpCode> ListOps { get; set; }
        public int LineNumber { get; set; }
        
        
        public Run(List<OpCode> ListOps, int line){
            this.ListOps = ListOps;
            this.LineNumber = line;
        }
    }
}
