using System;
using System.Collections.Generic;

namespace Day9
{
    class Part1
    {
        public List<int> inputList {get; set;}
        public int preamble {get; set;}
        public Part1(List<int> list, int premable)
        {
            this.inputList = list;
            this.preamble = premable;
        }

        public int Execute(){
            
            //ptr for look back
            var prestart = 0;
            var prestop = this.preamble;

            for (int i = preamble; i < inputList.Count; i++)
            {
                if  (!sumPrevious(prestart, prestop, inputList[i])){
                    return i;
                } 
                prestart++; 
                prestop++;
            
            }
            return -1;
        }

        public bool sumPrevious(int prestart, int prestop, int val){

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = 0; j < inputList.Count; j++)
                {
                    if (inputList[i] + inputList[j] == val){
                        return true;
                    }
                }
            }
            return false;
        }
       
    }
}
