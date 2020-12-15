using System;
using System.Collections.Generic;

namespace Day10
{
    class Part1
    {
        public List<double> inputList {get; set;}
        
        public Part1(List<double> list)
        {
            this.inputList = list;
        }

        public double Execute(){
            var dict = new Dictionary<double, int>();

            inputList.Sort();
            
            for (int i = 1; i < inputList.Count; i++)
            {
                var difference = inputList[i-1] - inputList[i];

                if (dict.ContainsKey(difference)){
                    dict[difference] += 1;
                } else {
                    dict.Add(difference, 1);
                }
                var results = 0;

                foreach(var kvp in dict){
                    results += Convert.ToInt32(kvp.Key) * kvp.Value;
                }
                return results;
            }
            
            return -1;
        }

       
       
    }
}
