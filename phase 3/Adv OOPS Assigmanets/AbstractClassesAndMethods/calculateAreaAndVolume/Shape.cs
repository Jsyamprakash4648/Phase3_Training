using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculateAreaAndVolume
{
    public abstract  class Shape
    {
        public abstract double Area  { get; set; }
        public abstract double  Volume { get; set; }

        // Non abstract properties: Radius, Height, Width, Page - a

        public double Radius { get; set; }
        public double Height { get; set; }

         public double Width { get; set; }

         //public int MyProperty { get; set; }

         //public abstract double salary(int dates);//Abstract method-only declaration

         // Abstract methods: CalculateArea, CalculateVolume


         public abstract double CalculateArea();
         public abstract double CalculateVolume();



    }
}