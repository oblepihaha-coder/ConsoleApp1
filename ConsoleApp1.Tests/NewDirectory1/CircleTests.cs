using System;
using Xunit;
using ConsoleApp1.NewDirectory1;

namespace CircleTests
{
    public class CircleUnitTests
    {
        [Fact]
        public void GetArea_PositiveRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;
            double actualArea = circle.GetArea();
            Assert.Equal(expectedArea, actualArea, 5); 
        }
        [Fact]
        public void Constructor_NegativeRadius_ThrowsArgumentException()
        {
            double radius = -3;
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
        [Fact]
        public void GetCircumference_ZeroRadius_ReturnsZero()
        {
            double radius = 0;
            Circle circle = new Circle(radius);
            double circumference = circle.GetCircumference();
            Assert.Equal(0, circumference);
        }
    }
}