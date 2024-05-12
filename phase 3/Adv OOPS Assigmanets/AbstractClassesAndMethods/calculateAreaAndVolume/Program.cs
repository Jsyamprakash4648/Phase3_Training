using System;
using calculateAreaAndVolume;

namespace CalculateAreaAndVolume;

class Program 
{
    public static void Main(string[] args)
    {

        Cylinders cy1=new Cylinders(12,56);
         Console.WriteLine(cy1.CalculateArea());

         Console.WriteLine(cy1.CalculateVolume());


        Cubes cubes1=new Cubes(56);
        Console.WriteLine(cubes1.CalculateArea());
        Console.WriteLine( cubes1.CalculateVolume());
       
        
    }
}


// ﻿﻿Create application for calculate area and volume of different shapes
// Abstract class Shape
// Abstract Properties: Area, Volume
// Non abstract properties: Radius, Height, Width, Page - a
// Abstract methods: CalculateArea, CalculateVolume
// Class Cylinders inherit Shape
// Overridden methods: CalculateArea - 2 π r(r+h) , CalculateVolume π r2 h
// Class Cubes inherit Shape
// Overridden methods: CalculateArea -  6a2 , CalculateVolume - a3
// Create objects for cylinder and cube and calculate area and volume of both.