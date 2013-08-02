using System;
class CalculateTheSum
{
    static void Main()
    {
        double sum = 1;
        for (int i = 2; i < 50; i++)
        {
            if ((i & 1) == 0)
            {
                sum = sum + (1.0 / i);
            }
            else
            {
                sum = sum - (1.0 / i);
            }
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}