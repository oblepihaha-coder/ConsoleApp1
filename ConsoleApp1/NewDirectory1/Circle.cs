using System;

namespace ConsoleApp1.NewDirectory1
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius cannot be negative", nameof(radius));

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
}