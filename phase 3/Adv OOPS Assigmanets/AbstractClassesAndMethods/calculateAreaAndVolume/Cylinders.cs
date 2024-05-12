using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculateAreaAndVolume
{
    public class Cylinders:Shape
    {

            public override double  Area{get;set;}

             public override double  Volume{get{return Volume;} set { Volume=value;}}

            // public override string Name{get{return _name;} set {_name=value;}}
        // Overridden methods: CalculateArea - 2 π r(r+h) , CalculateVolume π r2 h
        //(int)(Math.PI*Math.Pow(_number,2))
        public Cylinders(double radius,double height)
        {
            Radius=radius;
            Height=height;

        }
        public override double CalculateArea()
        {

             Area=2*Math.PI*Radius*Radius+Height;

            return Area;
            
        }

        public override double CalculateVolume()
        {
           double  volume=Math.PI*Radius*Radius*Height;
            return volume;
           
        }

    }
}