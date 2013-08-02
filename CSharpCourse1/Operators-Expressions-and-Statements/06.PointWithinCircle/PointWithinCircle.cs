using System;
class PointWithinCircle
{
    static void Main()
    {
        int pointX = 4;
        int pointY = 2;
        int radius = 5;
        int pointXPlusY = (pointX * pointX) + (pointY * pointY);
        bool pointWithinCircle = pointXPlusY < (radius * radius);
        Console.WriteLine(pointWithinCircle);
    }
}