using System;
using System.Collections.Generic;

namespace Day15
{
    class Part1
    {
        public List<int> inputList { get; set; }

        public Part1(List<int> list)
        {
            this.inputList = list;
        }

        public long Execute(int stopAt)
        {
            
            
            for (int i = 0; i < inputList.Count; i++)
            {
                
            }
            int count = inputList.Count;
            var dict = new Dictionary<int, int>();

            while (count < stopAt){
                
                // check previous
                int previous = inputList[count-1];
                //find all spoken
                var indexes = findAllIndex(previous);
                if (indexes.Count < 2){
                    inputList.Add(0);
                }
                else {
                    var val = indexes[indexes.Count -1 ] - indexes[indexes.Count -2 ];
                    inputList.Add(val);
                }
                count++;
            }
            printList();
            return inputList[count-1];

           //throw new Exception("Not implemented yet");
        }

        public List<int> findAllIndex(int number){
            var list = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == number){
                    list.Add(i);
                }
                
            }
            return list;
        }

        public void printList(){
            Console.WriteLine(string.Join(',', inputList));
        }
    }
}
