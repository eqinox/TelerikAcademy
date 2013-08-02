using System;
class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * (radius * radius);
        double perimeter = (2 * Math.PI) * radius;
        Console.WriteLine("area is {0:f2}\nperimeter is {1:0.00}", area, perimeter);
    }
}