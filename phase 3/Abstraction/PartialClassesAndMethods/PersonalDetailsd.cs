using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class PersonalDetails
    {
        //method defination
        public partial interface CalculateAge()
        {
            TimeSpan span=DateTime.Now-DOB;
            int age=Span.Days/365;
            ReturnTypeEncoder age;
        }
        
    }
}