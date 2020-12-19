using System;
using System.Collections.Generic;

namespace Day13
{
    class Part2
    {
        public List<List<string>> List {get; set;}
        
        public int Timestamp { get; set; }

        public List<string> Stops { get; set; }

        public int Min {get; set;}

        public int StopAt {get; set;}

        
        public Part2(List<List<string>>  list)
        {
            Timestamp = Convert.ToInt32(list[0][0]);
            Stops = list[1];

        }

        // need to refer to Chinese remainder theorem, didn't work for mine, but got the right answer from another solution
        public void Execute(){

            //10 million
           long maxtime = Int64.MaxValue;
           
           for (long i = 0; i < maxtime; i++)
           {
               bool testVal = true;

               for (int j = 0; j < Stops.Count; j++)
               {
                   long curstop = i + j;

                   if (Stops[j] == "x") {
                       continue;
                   }

                   int busNum = Convert.ToInt32(Stops[j]);
                   if (curstop % busNum == 0){
                       testVal = testVal & true;
                       continue;
                   } else {
                       testVal = false;
                       break;
                   }
               }
               if (testVal == true){
                   Console.WriteLine(i);
                   break;
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
