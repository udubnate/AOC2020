using System;
using System.Collections.Generic;

namespace Day10
{
    class Part1
    {
        public List<long> inputList { get; set; }

        public Part1(List<long> list)
        {
            this.inputList = list;
        }

        public long Execute()
        {
            var dict = new Dictionary<long, int>();
            //Add initial value at 0
            inputList.Add(0);
            inputList.Sort();
            //Add max plus 3
            inputList.Add(inputList[inputList.Count-1] + 3);

            for (int i = 1; i < inputList.Count; i++)
            {
                var difference = inputList[i] - inputList[i-1];

                if (dict.ContainsKey(difference))
                {
                    dict[difference] += 1;
                }
                else
                {
                    dict.Add(difference, 1);
                }
            }
            var results = 1;

            foreach (var kvp in dict)
            {
                results *= kvp.Value;
            }
            return results;
        }



    }
}
