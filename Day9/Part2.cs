using System;
using System.Collections.Generic;

namespace Day9
{
    class Part2
    {
        public List<double> inputList {get; set;}
        public double invalidNumber {get; set;}
        public Part2(List<double> list, double invalidNumber)
        {
            this.inputList = list;
            this.invalidNumber = invalidNumber;
        }

        public double Execute(){
            return sumContinous(invalidNumber);
        }

        public double sumContinous(double total){
            for (int i = 0; i < inputList.Count; i++)
            {
                double sum = inputList[i];

                for (int j = i+1; j < inputList.Count; j++)
                {
                    sum += inputList[j];

                    if (sum == total){
                        return sumSmallMax(i, j);
                    } 
                    else if (sum > total){
                        break;
                    }
                }
            }

            return -1;
        }
       
        public double sumSmallMax(int x, int y){
            double min = double.MaxValue;
            double max = double.MinValue; 
            for (int i = x; i < y; i++)
            {
                min = Math.Min(inputList[i], min);
                max = Math.Max(inputList[i], max);
                
            }
            return max + min;
        }
    }
}
