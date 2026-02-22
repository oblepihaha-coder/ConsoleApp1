using System;

namespace ConsoleApp1.NewDirectory1;

public class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }
}