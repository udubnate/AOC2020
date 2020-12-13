using System;
using System.Collections.Generic;

namespace Day7
{
    class Luggage
    {
       public int Quantity;
       public string Color;
       public List<Luggage> Contains;

       public Luggage(int number, string description){
           Quantity = number;
           Color = description;
           Contains = new List<Luggage>();
       }
    }
}
