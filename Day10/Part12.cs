using System;
using System.Collections.Generic;

namespace Day10
{
    class Part2
    {
        public Dictionary<int, long> _counts = new Dictionary<int, long>();
        public List<long> inputList { get; set; }

        public Part2(List<long> list)
        {
            this.inputList = list;
        }

        public long Execute()
        {
            var dict = new Dictionary<long, int>();
            //Add initial value at 0
            //inputList.Add(0);
            inputList.Sort();
            //Add max plus 3
            //inputList.Add(inputList[inputList.Count-1] + 3);
            //_counts = new List<long>();

            long results = CountArrangements(0, inputList);
            return results;
        }

        private long CountArrangements(int startIdx, List<long> joltages){
            if (_counts.ContainsKey(startIdx))
            {
                return _counts[startIdx];
            }

            if (startIdx == joltages.Count - 1)
            {
                return 1;
            }

            var result = 0L;

            for (var i = startIdx + 1; i < joltages.Count && joltages[i] <= joltages[startIdx] + 3; i++)
            {
                result += CountArrangements(i, joltages);
            }

            _counts.Add(startIdx, result);
            return result;

            throw new Exception("error");
        }



    }
}
