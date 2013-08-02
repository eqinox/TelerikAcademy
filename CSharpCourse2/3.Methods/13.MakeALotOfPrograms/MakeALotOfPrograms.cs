using System;
class MakeALotOfPrograms
{
    static double ReverseDigits2(double num)
    {
        string numAsStr = num.ToString();
        string newstr = "";
        for (int i = 1; i <= numAsStr.Length; i++)
        {
            if (numAsStr[numAsStr.Length - i] == '.')
            {
                continue;
            }
            newstr += numAsStr[numAsStr.Length - i];
        }
        return double.Parse(newstr);
    }
    static int AverageNumbers(int[] nums)
    {
        int sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }
        int average = sum / nums.Length;
        int position = Array.BinarySearch(nums, average);
        if (position >= 0)
        {
            average = nums[position];
        }
        else
        {
            average = nums[~position];
        }
        return average;
    }
    static double LinearEquation(double a, double b)
    {
        return (double)-b / a;
    }

    static void Main()
    {
        Console.WriteLine("1 - for reverse digits");
        Console.WriteLine("2 - for get average number in array");
        Console.WriteLine("3 - for solve linear equation");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            Console.Write("Enter number: ");
            double n = double.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("The number shouldn't be negative");
                return;
            }
            Console.WriteLine("Reversed: {0}", ReverseDigits2(n));
        }
        else if (input == 2)
        {
            Console.Write("length of the array: ");
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            if (numbers.Length <= 0)
            {
                Console.WriteLine("Please enter a valid length");
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}= ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Average number in that array is: {0}", AverageNumbers(numbers));
        }
        else if (input == 3)
        {
            Console.WriteLine("Enter \"A\" ! 0 and \"B\"");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Please type a= something else not equal to 0");
                return;
            }
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Answer: {0}", LinearEquation(a, b));
        }
        else
        {
            Console.WriteLine("Please select valid option");
        }
    }
}