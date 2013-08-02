/*You are given an array of strings. Write a method that sorts the array by the length of its elements
 * (the number of characters composing them).
*/
using System;
class SortStrings
{
    static void Main()
    {
        string[] strings = { "aa", "a", "aaaaaaaaaaa", "aaaaaaa", "aaaaa", "aaa"};
        for (int i = 0; i < strings.Length; i++)
        {
            int currentLength = strings[i].Length;
            for (int j = i + 1; j < strings.Length; j++)
            {
                if (currentLength > strings[j].Length)
                {
                    string cur = strings[i];
                    strings[i] = strings[j];
                    strings[j] = cur;
                }
            }
        }
        foreach (var item in strings)
        {
            Console.Write("{0} ", item);
        }
    }
}