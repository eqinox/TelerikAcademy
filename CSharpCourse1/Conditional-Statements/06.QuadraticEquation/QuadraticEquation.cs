using System;
/*Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
*/
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c=");
        int c = int.Parse(Console.ReadLine());
        int D = b * b - 4 * a * c;
        Console.WriteLine("D = {0}", D);
        if (D > 0)
        {
            Console.WriteLine("x1 = {0}", (int)(-b + Math.Sqrt(D)) / 2);
            Console.WriteLine("x2 = {0}", (int)(-b - Math.Sqrt(D)) / 2);
        }
        else
        {
            Console.WriteLine("quadratic equation haven't real roots");
        }
    }
}
