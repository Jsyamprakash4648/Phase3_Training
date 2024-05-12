using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class BookInfo:RackInfo
    {
        // Class BookInfo: Inherit RackInfo
// Properties: BookID, BookName, AuthorName, Price
// Method: Display info 
         public int BookID { get; set; }
         public string BookName { get; set; }
         public string AuthorName { get; set; }
         public int Price { get; set; }


         public void Displayinfo()
         {

            Console.WriteLine($"Book ID: {BookID} BookName: {BookName}  AuthorName: {AuthorName} Price: {Price} RackNumber: {RackNumber} ColumnNumber: {ColumnNumber} DepartmentName: {DepartmentName} Degre: {Degree}");

         }






    }
}