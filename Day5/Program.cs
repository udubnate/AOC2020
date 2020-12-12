using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "Day5input.txt";
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            int topSeatId = 0;
            int maxCol = Convert.ToInt32(Math.Pow(2,3));
            int maxRow = Convert.ToInt32(Math.Pow(2,7));

            //parttwo
            SeatMap seatmap1 = new SeatMap(maxRow, maxCol);
            

            foreach (string line in lines)
            {
                Seat s1 = new Seat(line);
                Console.WriteLine("Seat Row: " + s1.Row + " Col: " + s1.Column + " SeatId: " + s1.SeatId);
                seatmap1.RemoveAt(s1.Row, s1.Column);
                topSeatId = Math.Max(topSeatId, s1.SeatId);
            }
            Console.WriteLine("Top SeatId: " + topSeatId);

            seatmap1.printAvailable();
                     
        }
    }
}
