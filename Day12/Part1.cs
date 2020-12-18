using System;
using System.Collections.Generic;

namespace Day12
{
    class Part1
    {
        public List<List<string>> List {get; set;}

        public int X { get; set; }
        public int Y { get; set; }

        public int Direction {get; set; }
        
        public Part1(List<List<string>>  list)
        {
            this.List = list;
            this.Direction = 0;
            X = 0;
            Y = 0;
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
                switch (this.Direction){
                    case 0:
                        direction = "E";
                        break;
                    case 90:
                        direction = "S";
                        break;
                    case 180:
                        direction = "W";
                        break;
                    case 270:
                        direction = "N";
                        break;
                    default:
                        throw new Exception("Invalid Direction");
                }
            }
            if (direction == "N"){
                Y += value;
            }
            else if (direction == "S"){
                Y -= value;
            }
            else if (direction == "E"){
                X += value;
            }
            else if (direction == "W"){
                X -= value;
            }
            else if (direction == "L"){
                Direction = (Direction + 360 - value) % 360;
            }
            else if (direction == "R"){
                Direction = (Direction + value) % 360;
            }
            else {
                throw new Exception("invalid instruction.");
            }

            Console.WriteLine($"{direction}{value} -- East: {X}, North {Y}");
        }

        public override string ToString()
        {
            int manhattan = Math.Abs(X) + Math.Abs(Y);
            return $"East: {X}, North {Y} : {manhattan}";
        }

    }
}
