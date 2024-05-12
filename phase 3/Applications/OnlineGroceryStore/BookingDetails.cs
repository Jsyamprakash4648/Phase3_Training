using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        
//Properties: BookingID {Auto Increment – BID3000}, CustomerID, TotalPrice, DateOfBooking, Booking Status – Default, Initiated, Booked, Cancelled.   public string BookingID { get; set; }
   private int s_bookingID=3000;
   public string  BookingID { get; set; }
   public string  CustomerID { get; set; }
   public double TotalPrice { get; set; }

   public DateTime DateOfBooking { get; set; }
   public BookingStatus BookingStatus { get; set; }

   public BookingDetails(string customerID,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus )
   {
    s_bookingID++;
    BookingID="BID"+s_bookingID;
    CustomerID=customerID;
    TotalPrice=totalPrice;
    DateOfBooking=dateOfBooking;
    BookingStatus=bookingStatus;
  }

  public void  ShowBookingDetails()
  {
    Console.WriteLine($"{BookingID}	{CustomerID}	{TotalPrice}	{DateOfBooking}	{BookingStatus}");

  }







    }
}