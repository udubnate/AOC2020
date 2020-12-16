using System;
using System.Collections.Generic;

namespace Day16
{
    class Rule
    {
        public string Name { get; set; }

        public List<List<int>> ranges;

         public Rule(string name, List<List<int>> ranges)
        {
         this.Name = name;
         this.ranges = ranges;
        }
        
    }
}
