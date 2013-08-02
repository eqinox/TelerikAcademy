/*You are given a sequence of positive integer values written into a string, separated by spaces. Write a function 
 * that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461
*/
using System;
class StringOfNumbers
{
    static void Main()
    {
        string input = "43 68 9 23 318";
        int sum = 0;
        input += " ";
        string strSummer = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                sum += int.Parse(strSummer);
                strSummer = "";
            }
            strSummer += input[i];
        }
        Console.WriteLine("Sum of all these numbers is: {0}", sum);
    }
}