using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee//abstract class
    {
        //abstract class -partial abstraction.
        //Class fields properties,methods,constructor,indexers,events.
        // can have both abstract declaration and normal definations
        //con only used with an inherited class
        //Not support multiple inhertnace
        //it Cannot be static class
        protected string _name ;//normal fields

        public abstract string  Name { get; set; }//Abstract property

        public double Amount { get; set; }//normal property

        public string Dispaly()//Normal Method
        {
            return _name;
        }

        public abstract double salary(int dates);//Abstract method-only declaration

        
        
    }
}