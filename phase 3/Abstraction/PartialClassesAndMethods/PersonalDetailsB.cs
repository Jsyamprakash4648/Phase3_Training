using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class PersonalDetails
    {
        //Methods
        public int CalculateAge()
        {
            TimeSpan span=DateTime.Now-DOB;
            int age=span.Days/365;
            return age;

        }
        
    }
}