/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
*/
using System;
class SurfaceTriangle
{
    static void SOfTriangle1(int a, int ha)
    {
        double s = a * ha / 2.0;
        Console.WriteLine("The surface of the triangle is {0}", s);
    }
    static void SOfTriangle2(int a, int b, int c)
    {
        double p = (a + b + c) / 2.0;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("The surface of the triangle is {0}", s);//neto4nost (5,2,6)
    }
    static void SOfTriangle3(int a, int b, double c)
    {
        double angle = Math.PI * c / 180.0;
        double s = a * b * Math.Sin(angle) / 2;
        Console.WriteLine("The surface of the triangle is {0}", s);
    }

    static void Main()
    {
        Console.WriteLine("What do we have? \n a)Side and an altitude to it \n b)Three sides \n c)Two sides and an angle between them");
        string choise = Console.ReadLine();
        if (choise == "a")
        {
            Console.WriteLine("the side is:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("the altitude to it is:");
            int ha = int.Parse(Console.ReadLine());
            SOfTriangle1(a, ha);
        }
        else if (choise == "b")
        {
            Console.WriteLine("the first side is:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("the second side is:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("the third side is:");
            int c = int.Parse(Console.ReadLine());
            SOfTriangle2(a, b, c);
        }
        else if (choise == "c")
        {
            Console.WriteLine("the first side is:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("the second side is:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("the angle between them is:");
            double c = double.Parse(Console.ReadLine());
            SOfTriangle3(a, b, c);
        }
        else Console.WriteLine(" Invalid option!");
    }
}