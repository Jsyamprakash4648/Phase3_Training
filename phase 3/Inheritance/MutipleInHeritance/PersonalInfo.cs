using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutipleInHeritance
{
    public enum Gender{Select,Male,Female}
    public enum Maritaldetails{Select,Married,single}
    public class PersonalInfo:IShowData
    {
        //Properties: Name, Gender,DOB, phone, mobile, Marital details – Married/single
        public string Name  { get; set; }
        

        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public Maritaldetails  Maritaldetails { get; set; }

        public  void Showinfo()
        {

        }
    }
}