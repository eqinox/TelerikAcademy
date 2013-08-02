using System;
class GCDOfTwoNumbers
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        while (firstNum != 0 && secondNum != 0)
        {
            if (firstNum > secondNum)
            {
                firstNum %= secondNum;
            }
            else
            {
                secondNum %= firstNum;
            }
            
        }
        if (firstNum == 0)
        {
            Console.WriteLine("Greatest common divisor is: {0}", secondNum);
        }
        else
        {
            Console.WriteLine("Greatest common divisor is: {0}", firstNum);
        }
    }
}