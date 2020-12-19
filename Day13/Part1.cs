using System;
using System.Collections.Generic;

namespace Day13
{
    class Part1
    {
        public List<List<string>> List {get; set;}
        
        public int Timestamp { get; set; }

        public List<string> Stops { get; set; }

        public int Min {get; set;}

        public int StopAt {get; set;}

        
        public Part1(List<List<string>>  list)
        {
            Timestamp = Convert.ToInt32(list[0][0]);
            list[1].RemoveAll(HasX);
            Stops = list[1];

        }

        // Search predicate returns true if the string contains X in it
        private bool HasX(String s)
        {
            return s.ToLower().Contains("x");
        }

        public void Execute(){

            Min = Int32.MaxValue;

            foreach (string stop in Stops){
                int stopval = Convert.ToInt32(stop);
                int remaindermin = stopval - (Timestamp % stopval);
                if (remaindermin < Min){
                Min = remaindermin;
                StopAt = stopval;
                }
            }
        }

        public override string ToString()
        {
            int calc = Min * StopAt;
            return $"Min: {Min} :: StopAt {StopAt} :: Calc {calc}";
        }

    }
}
