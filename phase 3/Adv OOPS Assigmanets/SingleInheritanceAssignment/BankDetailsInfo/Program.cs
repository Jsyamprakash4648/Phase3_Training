using System;

namespace BankDetailsInfo;

class Program 
{

    public static void Main(string[] args)
    {
//0bject creation

PersonalInfo person=new PersonalInfo("syam","jayaprakash","1234567890","mailaaaa@id",new DateTime(02/01/2001),Gender.Male);
PersonalInfo person1=new PersonalInfo("satya","jayaprakash","8888888888","mailccccccc@id", new DateTime(05/02/2001),Gender.Female);
PersonalInfo person2=new PersonalInfo("sukumar","sundhari","77777777777","mailvvvvvvv@id", new DateTime(10/03/2002),Gender.Female);


AccountInfo account1=new AccountInfo(person.Name,person.FatherName,person.Phone,person.Mail,person.Dob,person.Gender,"Tnagar","HDFC101",10000000);
AccountInfo account2=new AccountInfo(person1.Name,person1.FatherName,person1.Phone,person1.Mail,person1.Dob,person1.Gender,"Tnagar","HDFC101",1000);
AccountInfo account3=new AccountInfo(person2.Name,person2.FatherName,person2.Phone,person2.Mail,person2.Dob,person2.Gender,"Tnagar","HDFC101",2000);

account1.ShowAccountInfo();
account1.Deposit(20000);
account1.Withdraw(500);

Console.WriteLine("____________________________________________________________");

account2.ShowAccountInfo();
account2.Deposit(20000);
account2.Withdraw(500);
Console.WriteLine("____________________________________________________________");

account3.ShowAccountInfo();
account3.Deposit(20000);
account3.Withdraw(500);
Console.WriteLine("____________________________________________________________");

    }
}