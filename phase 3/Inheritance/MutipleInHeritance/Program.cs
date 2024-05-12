using System;

namespace MutipleInHeritance;

class Program 
{
    public static void Main(string[] args)
    {
        RegisterPerson person1=new RegisterPerson();
        person1.Name="syam";
        person1.MotherName="sundhari";
        person1.DateOfRegistration=DateTime.Today;

        person1.DOB=new DateTime(2000,02,02);
        person1.Gender=Gender.Male;
        person1.HouseAddress="chennai";
        person1.Maritaldetails=Maritaldetails.single;
        person1.FatherName="jayaprakash";
        person1.Mobile="7410852963";
        person1.NoOfSiblings=2;
        person1.RegistrationNumber=4100;
        person1.ShowInfo();

    }
}
