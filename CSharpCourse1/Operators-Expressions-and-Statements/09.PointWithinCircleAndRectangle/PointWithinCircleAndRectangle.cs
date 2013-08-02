using System;
class PointWithinCircleAndRectangle
{
    static void Main()
    {
        double pointX = -1;
        double pointY = 0;
        double center = 1.1;
        double radius = 3;
        double pointInTheCircle = (pointX - center) * (pointX - center) + (pointY - center) * (pointY - center);
        bool resultForTheCircle = pointInTheCircle < radius * radius;
        // for rectangle
        int top = 1; // top 1
        int bottom = -1; // height 2
        int left = -1; // left -1
        int right = 5; // width 6
        if (resultForTheCircle)
        {
            if (left <= pointX && right >= pointX)
            {
                if (top >= pointY && bottom <= pointY)
                {
                    Console.WriteLine("FALSE \npoint is in the circle and IN the rectangle");
                }
                else
                {
                    Console.WriteLine("point is in the circle and out of the rectangle");
                }
            }
            else
            {
                Console.WriteLine("point is in the circle and out of the rectangle");
            }
        }
        else
        {
            Console.WriteLine("the point is out of the circle");
        }
        
    }
}