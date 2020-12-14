using System;
using System.Collections.Generic;

namespace Day9
{
    class Part1
    {
        public List<double> inputList {get; set;}
        public int preamble {get; set;}
        public Part1(List<double> list, int premable)
        {
            this.inputList = list;
            this.preamble = premable;
        }

        public double Execute(){
            
            //ptr for look back
            var prestart = 0;
            var prestop = this.preamble;

            for (int i = preamble; i < inputList.Count; i++)
            {
                if  (!sumPrevious(prestart, prestop, inputList[i])){
                    return inputList[i];
                } 
                prestart++; 
                prestop++;
            
            }
            return -1;
        }

        public bool sumPrevious(int prestart, int prestop, double val){

            for (int i = prestart; i < prestop; i++)
            {
                for (int j = prestart; j < prestop; j++)
                {
                    if (inputList[i] + inputList[j] == val && i != j){
                        return true;
                    }
                }
            }
            return false;
        }
       
    }
}
