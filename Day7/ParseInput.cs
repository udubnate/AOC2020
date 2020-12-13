using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day7
{
    static class ParseInput
    {
        public static IEnumerable<string> Words(this string input)
        {
            return input.Split(new string[] { " ", "\t", Environment.NewLine, ",", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static (string Bag, Dictionary<string, int> Contents) Parse(string line){
            
            var words = ParseInput.Words(line).ToList();

            var bag = $"{words[0]} {words[1]}";
            var contents = new Dictionary<string, int>();

            for (var i = 4; i < words.Count; i += 4)
            {
                if (words[i] != "no")
                {
                    contents.Add($"{words[i + 1]} {words[i + 2]}", int.Parse(words[i]));
                }
            }

            return (bag, contents);
        }

         
    }
}
