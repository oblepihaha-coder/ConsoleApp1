using System;
using ConsoleApp1.NewDirectory1;

class Program
{
    static void Main()
    {
        Console.Write("Введіть радіус кола: ");
        double radius = double.Parse(Console.ReadLine());

        Circle circle = new Circle(radius);

        Console.WriteLine("Площа кола: " + circle.GetArea());
        Console.WriteLine("Довжина кола: " + circle.GetCircumference());
    }
}