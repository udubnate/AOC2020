using System;

namespace Day5
{
    class Seat
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int SeatId { get; set; }

        public Seat(String s){
            this.Row = calcRow(s);
            this.Column = calcCol(s);
            this.SeatId = calcSeatId();
        }

        public int calcRow(String str){
            string rowstr = str.Substring(0, 7);
            double value = 0;
            for (int i = 0; i < rowstr.Length; i++)
            {
                // add binary value
                if (rowstr[rowstr.Length-i-1] =='B'){
                    value += Math.Pow(2,i);
                }           
            }
            return Convert.ToInt32(value);
        }

        public int calcCol(String str){
            string rowstr = str.Substring(7, 3);
            double value = 0;
            for (int i = 0; i < rowstr.Length; i++)
            {
                // add binary value
                if (rowstr[rowstr.Length-i-1] =='R'){
                    value += Math.Pow(2,i);
                }           
            }
            return Convert.ToInt32(value);
        }

        public int calcSeatId(){
            return (Row*8)+Column;
        }
    }
}
