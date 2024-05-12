using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TicketFairDetails
    {
// Properties:
// •	TicketID (Auto Generated – MR3001)
// •	FromLocation
// •	ToLocation
// •	TicketPrice
            //getting dettails for trvael details
        private static int s_ticketID=3000;
        public string TicketID  { get; set; }

        public string  FromLocation { get; set; }

        public string ToLocation { get; set; }
        public double TicketPrice { get; set; }

        public TicketFairDetails(string fromLocation,string toLocation,double ticketPrice )
        {
            s_ticketID++;
            TicketID="MR"+s_ticketID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;



        }

        public  TicketFairDetails(string ticketId,string fromLocation,string toLocation,double ticketPrice )
        {
            TicketID=ticketId;
            s_ticketID=int.Parse(ticketId.Remove(0,2));
             FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;

        }
    }
}