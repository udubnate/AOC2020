using System;
using System.Collections.Generic;

namespace Day16
{
    class Document
    {
        public List<Rule> ruleList { get; set; }
        public Ticket yourTicket {get; set; }
        public List<Ticket> nearbyTickets { get; set; }

         public Document(List<Rule> ruleList, Ticket yourTicket, List<Ticket> nearbyTickets)
        {
         this.ruleList = ruleList;
         this.yourTicket = yourTicket;
         this.nearbyTickets = nearbyTickets;
        }
        
    }
}
