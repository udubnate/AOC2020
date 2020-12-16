using System;
using System.Collections.Generic;

namespace Day16
{
    class Part1
    {
        public Document Doc { get; set; }

        public Part1(Document doc)
        {
            this.Doc = doc;
        }

        public long Execute()
        {
            List<int> exceptionList = new List<int>();
            List<int> greaterThan = new List<int>();
            List<int> lessThan = new List<int>();
            int stopCalc = 0;
            // add Rules to a validate list
            foreach (var rule in Doc.ruleList)
            {
                foreach (var range in rule.ranges)
                {
                    greaterThan.Add(range[0]);
                    lessThan.Add(range[1]);
                }
            }

            List<int> nearbyStops = new List<int>();

            foreach (var nearby in Doc.nearbyTickets)
            {
                foreach (int stop in nearby.Values)
                {
                    bool InRange = false;
                    for (int i = 0; i < greaterThan.Count; i++)
                    {
                        if (stop >= greaterThan[i] && stop <= lessThan[i])
                        {
                            InRange = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!InRange)
                    {
                        exceptionList.Add(stop);
                        stopCalc += stop;
                    }
                }
            }

            return stopCalc;
            throw new Exception("Not implemented yet");
        }

    }
}