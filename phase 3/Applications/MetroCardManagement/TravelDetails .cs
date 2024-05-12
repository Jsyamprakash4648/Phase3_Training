using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TravelDetails 
    {
// Properties:
// a.	TravelId (Auto Generated -TID2001)
// b.	Card Number
// c.	FromLocation
// d.	ToLocation
// e.	Date
// f.	Travel Cost
    private static int s_travelId=2000;
     public string  TravelId { get; set; }

     public string  CardNumber { get; set; }

     public string  FromLocation { get; set; }

     public string  ToLocation { get; set; }

     public DateTime Date { get; set; }
     public double  TravelCost { get; set; }


     public TravelDetails(string cardnumber,string fromLocation,string toLocation,DateTime date,double  travelCost)
     {
        s_travelId++;
        TravelId="TID"+s_travelId;
        CardNumber=cardnumber;
        FromLocation=fromLocation;
        ToLocation=toLocation;
        Date=date;
        TravelCost=travelCost;

    }

    public TravelDetails(string travelID,string cardnumber,string fromLocation,string toLocation,DateTime date,double  travelCost)
    {
        TravelId=travelID;
        s_travelId=int.Parse(travelID.Remove(0,3));
        CardNumber=cardnumber;
        FromLocation=fromLocation;
        ToLocation=toLocation;
        Date=date;
        TravelCost=travelCost;

    }



     
    }
}