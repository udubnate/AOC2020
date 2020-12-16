using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day16
{
    class Input
    {

        public string FilePath { get; set; }

        public Input(string filePath)
        {
            this.FilePath = filePath;
        }

        public Document Parse()
        {
            //using statement to close out streamReader after use
            using (StreamReader sr = new StreamReader(this.FilePath))
            {
                var list = new List<int>();
                var ruleList = new List<Rule>();
                Ticket yourTicket = null;
                var nearbyTickets = new List<Ticket>();

                int group = 0;
                while (true)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        if (group > 3) break;

                        group++;
                        // advance another line to skip your ticket or friend tickets
                        sr.ReadLine(); 
                        continue;                  
                    }

                    //custom processing
                    // process first group, Rules
                    switch (group){
                        case 0:
                            var rule = ParseRule(line);
                            ruleList.Add(rule);
                            break;
                        case 1:
                            yourTicket = ParseTicket(line);
                            break;
                        case 2:
                            nearbyTickets.Add(ParseTicket(line));
                            break;

                        default: 
                            throw new Exception("Parse related error");
                    }
                    
                    //end with EOF

                }
                return new Document(ruleList, yourTicket, nearbyTickets);
            }
        }

        public Rule ParseRule(string line)
        {
            var ruleList = new List<Rule>();

            Regex expression = new Regex(@"(^.*):\s(\d*)-(\d*)\sor\s(\d*)-(\d*)");
            Match match = expression.Match(line);
            if (match.Success)
            {
                string name = match.Groups[1].Value;
                var ranges = new List<List<int>>();

                for (int i = 2; i < match.Groups.Count; i += 2)
                {
                    var range = new List<int>();
                    range.Add(Convert.ToInt32(match.Groups[i].Value));
                    range.Add(Convert.ToInt32(match.Groups[i + 1].Value));
                    ranges.Add(range);
                }
                return new Rule(name, ranges);
            }
            throw new Exception("Parse Error couldn't parse rule.");

        }

        public Ticket ParseTicket(string line){
            string[] strlist = line.Split(',');
            int[] ints = Array.ConvertAll(strlist, s => int.Parse(s));
            var list = ints.ToList();
            return new Ticket(list);
            //throw new Exception("Parse Error couldn't parse rule.");
        }
    }


}
