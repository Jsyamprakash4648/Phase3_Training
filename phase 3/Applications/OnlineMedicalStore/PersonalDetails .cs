using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class PersonalDetails 
    {
        public string Name { get; set; }

        public int Age  { get; set; }
        public string City { get; set; }
        public string PhoneNUmber { get; set; }

        public PersonalDetails(string name,int age ,string city,string phoneNUmber)

        {
            Name=name;
            Age=age;;
            City=city;
            PhoneNUmber=phoneNUmber;

            

        }
    }
}