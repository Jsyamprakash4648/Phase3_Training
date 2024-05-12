using System;

namespace Library;

class Program 
{
    public static void Main(string[] args)
    {
// Online Library Create and store 3 bookInfo details.
// Class DepartmentDetails:
// Properties: DepartmentName, Degree
// Class RackInfo: DepartmentDetails
// Properties: RackNumber, ColumnNumber
// Class BookInfo: Inherit RackInfo
// Properties: BookID, BookName, AuthorName, Price
// Method: Display info  

        BookInfo book1=new BookInfo();
        book1.BookName="syam";
        book1.BookID=123;
        book1.AuthorName="asdf";
        book1.ColumnNumber=12;
        book1.Degree="eee";
        book1.DepartmentName="cccc";
        book1.Price=1234;
        book1.RackNumber=10;

        BookInfo book2=new BookInfo();
        book2.BookName="prakash";
        book2.BookID=153;
        book2.AuthorName="abcd";
        book2.ColumnNumber=10;
        book2.Degree="ssss";
        book2.DepartmentName="rrrr";
        book2.Price=143;
        book2.RackNumber=100;

        BookInfo book3=new BookInfo();
        book3.BookName="aaaaaaa";
        book3.BookID=455;
        book3.AuthorName="ttttt";
        book3.ColumnNumber=123;
        book3.Degree="eeeghhhhhhh";
        book3.DepartmentName="pppp";
        book3.Price=123445;
        book3.RackNumber=102;

        book1.Displayinfo();
        book2.Displayinfo();
        book3.Displayinfo();






    }
}