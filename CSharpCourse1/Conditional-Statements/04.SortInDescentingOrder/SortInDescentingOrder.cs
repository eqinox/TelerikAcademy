using System;
/*Sort 3 real values in descending order using nested if statements.
*/
class SortInDescentingOrder
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            firstNumber ^= secondNumber;
            secondNumber ^= firstNumber;
            firstNumber ^= secondNumber;
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }
        else if (secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
        }
    }
}