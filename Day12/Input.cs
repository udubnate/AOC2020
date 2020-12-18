using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Day12
{
    class Input
    {

        public string FilePath { get; set; }

        public Input(string filePath)
        {
            this.FilePath = filePath;
        }

        public List<List<string>> Parse()
        {
            //using statement to close out streamReader after use
            using (StreamReader sr = new StreamReader(this.FilePath))
            {
                var list = new List<List<string>>();

                while (true)
                {
                    string line = sr.ReadLine();
                    //end with EOF
                    if (string.IsNullOrEmpty(line)) break;

                    Regex expression = new Regex(@"(\D)(\d*)");
                    Match match = expression.Match(line);
                    if (match.Success)
                    {
                        var commands = new List<string>();
                        string direction = match.Groups[1].Value;
                        string value = match.Groups[2].Value;
                        commands.Add(direction);
                        commands.Add(value);
                        list.Add(commands);
                    
                    }
                }
                return list;
            }
        }
    }
}
