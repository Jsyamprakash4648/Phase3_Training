using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculateAreaAndVolume
{
    public class Cubes :Shape
    {
         public override double  Area {get; set;}

             public override double  Volume{get;set;}

             public Cubes (double radius)
             {
                Radius=radius;
             }




        public override double CalculateArea()
        {

             Area=(6*(Radius*Radius));

            return Area;
            
        }

        public override double CalculateVolume()
        {
            Volume=Radius*Radius*Radius;
            return Volume;
           
        }
    }
}