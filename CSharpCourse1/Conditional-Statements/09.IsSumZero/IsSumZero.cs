using System;
/*We are given 5 integer numbers. Write a program that checks if the sum of 
 * some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
  */
class IsSumZero
{
    static void Main()
    {
        Console.Write("Enter the sum that you want to get: ");
        int wantedSum = int.Parse(Console.ReadLine());
        Console.Write("Enter how many numbers do you want to write: ");
        int howManyNumbers = int.Parse(Console.ReadLine());
        int[] theNumber = new int[howManyNumbers];
        long maxRotationOfCycle = (long)Math.Pow(2, howManyNumbers);
        int counterOfWantedSum = 0;
        for (int i = 0; i < howManyNumbers; i++)
        {
            theNumber[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 1; i < maxRotationOfCycle; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < howManyNumbers; j++)
            {
                int mask = 1 << j;
                int nAndMask = mask & i;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum += theNumber[j];
                }
            }
            if (currentSum == wantedSum)
            {
                counterOfWantedSum++;
                for (int j = 0; j < howManyNumbers; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = mask & i;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        string resultAsString = theNumber[j] > 0 ? "+ " : "";
                        Console.Write(resultAsString);
                        Console.Write("{0} ", theNumber[j]);
                    }
                }
                Console.Write("= {0}", wantedSum);
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine("There have {0} subsets that makes {1}", counterOfWantedSum, wantedSum);
    }
}