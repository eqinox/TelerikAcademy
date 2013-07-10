/*Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;
class CompareCharArrays
{
    static void Main()
    {
        char[] firstCharArray = {'g', 'f', 'e', 'd', 'c', 'b', 'a'};
        char[] secondCharArray = {'a', 'b', 'c', 'd', 'e', 'f', 'g' };
        for (int i = 0; i < firstCharArray.Length; i++)
        {
            if (firstCharArray[i] > secondCharArray[i])
            {
                Console.WriteLine("element of first char array - {0, 3} > {1, -4} - element of second char array", firstCharArray[i], secondCharArray[i]);
            }
            else
            {
                Console.WriteLine("element of first char array - {0, 3} < {1, -4} - element of second char array", firstCharArray[i], secondCharArray[i]);
            }
        }
    }
}