﻿using System;



class RectangleArea
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double rectangleArea = width * height;

        Console.WriteLine("{0:f2}", rectangleArea);
    }
}

