using System;
using System.Collections.Generic;

namespace Day15
{
    class Part2
    {
        public List<int> inputList { get; set; }

        public Part2(List<int> list)
        {
            this.inputList = list;
        }

        public long Execute(long stopAt)
        {
            
            var count = inputList.Count;
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < inputList.Count; i++)
            {
                AddMap(dict, inputList[i], i);
            }
            


            while (count < stopAt){
                
                // check previous
                int previous = inputList[^1];
                //find all spoken
                 if (dict.ContainsKey(previous) && dict[previous].Count > 1){
                    var val = dict[previous][^1] - dict[previous][^2];
                    inputList.Add(val);
                    AddMap(dict, val, count);
                }
                else {
                    inputList.Add(0);
                    AddMap(dict, 0, count);
                }
                count++;
            }
            //printList();
            return inputList[count-1];

           //throw new Exception("Not implemented yet");
        }


        public void printList(){
            Console.WriteLine(string.Join(',', inputList));
        }

        public void AddMap(Dictionary<int, List<int>> map, int key, int value){
            if (map.ContainsKey(key)){
                map[key].Add(value);

            } else {
                map.Add(key, new List<int>());
                map[key].Add(value);
            }
        }
    }
}
