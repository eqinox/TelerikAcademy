using System;
/*Write a program that shows the sign (+ or -) of the product of three real numbers
 * without calculating it. Use a sequence of if statements.
*/
class PlusOrMinus
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("first number * second * third are with sign: ");
        if (firstNumber > 0)
        {
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("+");
                }
            }
            else if (thirdNumber > 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        else if (secondNumber > 0)
        {
            if (thirdNumber > 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        else if (thirdNumber > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
        Console.WriteLine("is that true? {0} * {1} * {2} = {3}", firstNumber, secondNumber, thirdNumber, firstNumber * secondNumber * thirdNumber);
    }
}