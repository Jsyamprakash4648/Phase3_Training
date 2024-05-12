using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    using MathsLib;
    public class CircleArea:Maths
    {

         protected   double radius;
         internal double area;
         public double Radius{get{return radius;} set{radius=value;}}

         public double CalculateArea()
         {
            return PI*radius*radius;
            
         }

        
    }
}