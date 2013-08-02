using System;
/*Write an if statement that examines two integer variables and exchanges their
 * values if the first one is greater than the second one.
*/
class ExchangeValue
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        if (firstNum > secondNum)
        {
            secondNum = firstNum;
        }
        Console.WriteLine("Bigger is: {0}", secondNum);
    }
}