using System;
using System.Globalization;
using System.Collections.Generic;
class GatherNumbers
{
    static int[] GatherNumbers2(int[] first, int[] second)
    {
        if (first.Length == second.Length)
        {
            int[] newArr = new int[first.Length];
            int HaveOneOnMind = 0;
            int positionOFAllArrays = newArr.Length - 1;
            while (positionOFAllArrays >= 0)
            {
                int currentSum = first[positionOFAllArrays] + second[positionOFAllArrays];
                if (currentSum >= 10)
                {
                    currentSum -= 10;
                }
                if (HaveOneOnMind == 1)
                {
                    newArr[positionOFAllArrays] = currentSum + HaveOneOnMind;
                    HaveOneOnMind = 0;
                }
                else
                {
                    newArr[positionOFAllArrays] = currentSum;
                }

                if (first[positionOFAllArrays] + second[positionOFAllArrays] >= 10)
                {
                    HaveOneOnMind++;
                }

                positionOFAllArrays--;
            }
            if (HaveOneOnMind == 1)
            {
                int[] currentArr = (int[])newArr.Clone();
                newArr = new int[currentArr.Length + 1];
                newArr[0] = 1;
                for (int i = 1; i < newArr.Length; i++)
                {
                    newArr[i] = currentArr[i - 1];
                }
            }
            return newArr;
        }
        else
        {
            int[] newArr = new int[second.Length];
            int HaveOneOnMind = 0;
            int positionOfSmallerArray = newArr.Length - 1;
            int positionOfBiggerArray = first.Length - 1;
            while (positionOfSmallerArray >= 0)
            {
                int currentSum = first[positionOfBiggerArray] + second[positionOfSmallerArray];
                if (currentSum >= 10)
                {
                    currentSum -= 10;
                }
                if (HaveOneOnMind == 1)
                {
                    newArr[positionOfSmallerArray] = currentSum + HaveOneOnMind;
                    HaveOneOnMind = 0;
                }
                else
                {
                    newArr[positionOfSmallerArray] = currentSum;
                }

                if (first[positionOfBiggerArray] + second[positionOfSmallerArray] >= 10)
                {
                    HaveOneOnMind++;
                }

                positionOfSmallerArray--;
                positionOfBiggerArray--;
            }
            if (HaveOneOnMind == 1)
            {
                int[] currentArr = (int[])newArr.Clone();
                newArr = new int[first.Length];
                for (int i = first.Length - second.Length - 1; i >= 0; i--)
                {
                    int currentSum = first[i] + HaveOneOnMind;
                    if (currentSum >= 10)
                    {
                        currentSum -= 10;
                    }
                    newArr[i] = currentSum;
                    if (first[i] + HaveOneOnMind == 10)
                    {

                    }
                    else
                    {
                        HaveOneOnMind = 0;
                    }
                }
                for (int i = first.Length - second.Length, j = 0; i < first.Length; i++, j++)
                {
                    newArr[i] = currentArr[j];
                }
                if (HaveOneOnMind == 1)
                {
                    currentArr = (int[])newArr.Clone();
                    newArr = new int[newArr.Length + 1];
                    newArr[0] = 1;
                    for (int i = 1; i < newArr.Length; i++)
                    {
                        newArr[i] = currentArr[i-1];
                    }
                }
            }
            else
            {
                int[] currentArr = (int[])newArr.Clone();
                newArr = new int[first.Length];
                for (int i = 0; i < first.Length - second.Length; i++)
                {
                    newArr[i] = first[i];
                }
                for (int i = first.Length - second.Length, j = 0; i < first.Length; i++, j++)
                {
                    newArr[i] = currentArr[j];
                }
            }
            return newArr;
        }
    }
    static int[] GetValues(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}= ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}", arr[i]);
        }
    }
    static void Main()
    {
        Console.Write("Length of first arr= ");
        int firstLength = int.Parse(Console.ReadLine());
        Console.Write("Length of second arr= ");
        int secondLength = int.Parse(Console.ReadLine());
        if (firstLength < secondLength)
        {
            int curr = firstLength;
            firstLength = secondLength;
            secondLength = curr;
        }
        int[] firstNumbers = new int[firstLength];
        int[] secondNumbers = new int[secondLength];
        Console.WriteLine("Please type only 1 digit every turn");
        GetValues(secondNumbers);
        Console.WriteLine("Other arr: ");
        GetValues(firstNumbers);
        PrintArr(secondNumbers);
        Console.Write(" + ");
        PrintArr(firstNumbers);
        Console.Write(" = ");

        PrintArr(GatherNumbers2(firstNumbers, secondNumbers));
        Console.WriteLine();
    }
}