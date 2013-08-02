using System;
class Matrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            for (int j = i + 1; j < number + i + 1; j++)
            {
                Console.Write("{0,-3}", j);
            }
            Console.WriteLine();
        }
    }
}