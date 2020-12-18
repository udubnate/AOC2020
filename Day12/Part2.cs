using System;
using System.Collections.Generic;

namespace Day12
{
    class Part2
    {
        public List<List<string>> List {get; set;}

        public int X { get; set; }
        public int Y { get; set; }

        public int refX {get; set;}
        public int refY  {get; set;}

        public int Direction {get; set; }
        
        public Part2(List<List<string>>  list)
        {
            this.List = list;
            this.Direction = 0;
            X = 0;
            Y = 0;
            refX = 10;
            refY = 1;
        }

        public void Execute(){

            foreach (var command in this.List){
                var direction = command[0];
                var value = Convert.ToInt32(command[1]);

                MoveShip(direction, value);

            }
        }

        public void MoveShip(string direction, int value){
            
            if (direction == "F"){
                this.X += refX * value;
                this.Y += refY * value;
            }
            else if (direction == "N"){
                refY += value;
            }
            else if (direction == "S"){
                refY -= value;
            }
            else if (direction == "E"){
                refX += value;
            }
            else if (direction == "W"){
                refX -= value;
            }
            else if (direction == "L"){
                for (var rotate = 0; rotate < (value / 90); rotate++){
                   (refX, refY) = (-refY, refX);
               }
            }
            else if (direction == "R"){
               for (var rotate = 0; rotate < (value / 90); rotate++){
                   (refX, refY) = (refY, -refX);
               }
            }
            else {
                throw new Exception("invalid instruction.");
            }

            Console.WriteLine($"{direction}{value} -- East: {X}, North {Y}, WayPoint: East {refX}, North: {refY}");
        }

        public override string ToString()
        {
            int manhattan = Math.Abs(X) + Math.Abs(Y);
            return $"East: {X}, North {Y} : {manhattan}";
        }

    }
}
