using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutipleInHeritance
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        //Properties: RegistrationNumber(Auto), DateOfRegistration,
        public int RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }
         public string HouseAddress { get; set; }
         public int  NoOfSiblings  { get; set; }


         public void ShowInfo()
         {

            Console.WriteLine($"name: {Name} gender: {Gender}  phone: {Mobile}  mairital status: {Maritaldetails}  fathername : {FatherName}  mother Name: {MotherName}  HouseAddress:  {HouseAddress} NoOfSiblings : {NoOfSiblings} ");

         }


        
    }
}