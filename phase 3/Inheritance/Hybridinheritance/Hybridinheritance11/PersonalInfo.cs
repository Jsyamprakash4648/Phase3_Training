using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybridinheritance11
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        //Properties: RegistationNumber, Name, FatherName, Phone, DOB, Gender

       //private static int s_registationNumber;
       public string RegistationNumber { get; set; }
        public string Name  { get; set; }
        public string FatherName { get; set; }

        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }

       
       
    }
}