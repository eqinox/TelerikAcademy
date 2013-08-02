using System;
using System.Numerics;
class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger firstNum = 0;
        BigInteger secondNum = 0;
        BigInteger thirdNum = 1;
        for (int i = 0; i < n; i++)
        {
            secondNum = firstNum + secondNum;
            Console.WriteLine(secondNum);
            thirdNum = secondNum + thirdNum;
            Console.WriteLine(thirdNum);
            firstNum = secondNum;
            secondNum = thirdNum;
        }
    }
}