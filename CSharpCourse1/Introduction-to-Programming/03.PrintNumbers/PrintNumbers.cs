using System;

class PrintNumbers
{
    static void Main()
    {
        int TheNumber = 1;
        int MoveTheNumber = 3;
        for (int i = 0; i < MoveTheNumber; i++)
        {
            if (i == 0)
            {
                Console.WriteLine(Convert.ToString((TheNumber << i), 2));
            }
            else
            {
                Console.WriteLine(Convert.ToString((TheNumber << i), 2) + "1");
            }
        }
    }
}
