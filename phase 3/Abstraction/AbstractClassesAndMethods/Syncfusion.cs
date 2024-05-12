using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public class Syncfusion:Employee
    {
        //abstract property defination
        public  override string  Name{get {return _name;} set {_name=value;}}
        //Abstract method defination
        public override double salary(int dates)
        {
            Amount=(double)dates*500;
            return Amount;

        }

    }
}