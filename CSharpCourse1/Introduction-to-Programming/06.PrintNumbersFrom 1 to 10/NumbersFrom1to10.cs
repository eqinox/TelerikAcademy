using System;

class NumbersFrom1to10
{
    static void Main()
    {
        int PlusCounter = 2;
        int MinusCounter = -3;
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(PlusCounter + ", ");
                PlusCounter += 2;
            }
            else
            {
                Console.Write(MinusCounter + ", ");
                MinusCounter -= 2;
            }
        }
    }
}
