using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public class Zoho:Employee
    {
        public override string Name{get{return _name;} set {_name=value;}}
        //method override defination

        public override double salary(int dates)
        {
            Amount=(double)dates*1000;
            return Amount;
        }

    }
}