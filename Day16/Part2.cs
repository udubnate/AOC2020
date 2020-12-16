using System;
using System.Collections.Generic;

namespace Day16
{
    class Part2
    {
        public Document Doc { get; set; }

        public Part2(Document doc)
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
            List<Ticket> ticketsToRemove = new List<Ticket>();

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
                        ticketsToRemove.Add(nearby);
                    }
                }
            }

            // remove invalid tickets
            foreach (var ticket in ticketsToRemove){
                Doc.nearbyTickets.Remove(ticket);
            }

            int TicketRange = Doc.nearbyTickets[0].Values.Count;
            var classdict = new Dictionary<string, int>();
            //Test which group of numbers match which Rule
            foreach(var rule in Doc.ruleList){
               
                for (int i = 0; i < TicketRange; i++)
                {
                    bool InRange = false;
                     List<bool> rangelist = new List<bool>();

                    foreach (var ticket in Doc.nearbyTickets){
                        
                        if (rule.ranges[0][0] <= ticket.Values[i] && rule.ranges[0][1] >= ticket.Values[i]){
                            InRange = true;
                            rangelist.Add(InRange);
                        }
                        else if (rule.ranges[1][0] <= ticket.Values[i] && rule.ranges[1][1] >= ticket.Values[i]){
                            InRange = true;
                            rangelist.Add(InRange);
                        }
                    } 

                     if (rangelist.Count == Doc.nearbyTickets.Count){
                        Console.WriteLine(rule.Name + " :  "+  i);
                        classdict.Add(rule.Name, i);
                        break;
                    }   
                }
               
            }
            int calc = 0;
            int stopAt = 6;
            int count = 0;
            foreach (var rule in Doc.ruleList){
                if (classdict.ContainsKey(rule.Name)){
                    int pos = classdict[rule.Name];
                    Console.WriteLine(rule.Name + " : " + pos);
                    Console.WriteLine(Doc.yourTicket.Values[pos]);
                    calc += Doc.yourTicket.Values[pos];
                    count++;

                    if (count == stopAt) break;
                   // Doc.yourTicket.Values[classdict[rule.name]];
                }
            }
            // now associate your ticket with 
            return calc;
            throw new Exception("Not implemented yet");
        }

    }
}