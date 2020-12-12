using System;

namespace Day5
{
    class SeatMap
    {
        public int[,] seats;
        
        protected int row { get; set; }
        protected int col { get; set; }
        public SeatMap(int row, int col)
        {
            this.row = row;
            this.col = col;

            this.seats = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    seats[i, j] = 1;
                }
            }
        }

        public void RemoveAt(int row, int col){
            seats[row, col] = 0;
        }

        public void print(){
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("seat[" + i + "," + j + "] = " + seats[i,j]);
                }
            }
        }

        public void printAvailable(){
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (seats[i,j] == 1 && seats[i,Math.Abs(j-1 % col)] == 0 && seats[i,Math.Abs(j-1 % col)] == 0){
                        int seatId = (i * 8) + j;
                    Console.WriteLine("seat[" + i + "," + j + "] = " + seats[i,j] + "SeatId: " + seatId);
                    }
                }
            }
        }
    }

}