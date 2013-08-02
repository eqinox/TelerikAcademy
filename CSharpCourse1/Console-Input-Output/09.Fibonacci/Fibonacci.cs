using System;
using System.Numerics;
class Fibonacci
{
    static void Main()
    {
        BigInteger firstNum = 0;
        BigInteger secondNum = 0;
        BigInteger thirdNum = 1;
        for (int i = 0; i < 100; i++)
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