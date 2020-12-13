using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Day7
{
    class ParseInput
    {
        internal static List<Luggage> Parse(string filepath){
            var result = new List<Luggage>();
            
            var containRegex = new Regex(@"^(?<container>.*) bags contain (?<containees>.*)\.$");
            var containeesRegex = new Regex(@"(?<number>\d*) (?<description>.+) bag");

            foreach(var line in File.ReadAllLines(filepath)){
                var containResult= containRegex.Match(line);
                //parent luggage
                var luggage = new Luggage(1, containResult.Groups["container"].Value);
                var containees = containResult.Groups["containees"].Value;

                if (containees == "no other bags"){
                    result.Add(luggage);
                    continue;
                }

                var parts = containees.Split(", ");
                foreach (var part in parts){

                    var containeeResult = containeesRegex.Match(part);
                    var containeeNumber = int.Parse(containeeResult.Groups["number"].Value);
                    var containeeDescription = containeeResult.Groups["description"].Value;

                    var containee = new Luggage(containeeNumber, containeeDescription);

                    luggage.Contains.Add(containee);
                }
                result.Add(luggage);
            }

            return result;
        }
    }
}
