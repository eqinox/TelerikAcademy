/*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and
 * print the index of each of its letters in the array.
*/
using System;
class AlphabetIndexs
{
    static void Main()
    {
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", 
                                "S", "T", "U","V", "W", "X","Y", "Z"};
        Console.Write("Write a word only with CAPITAL letters: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (alphabet[j] == word[i].ToString())
                {
                    Console.WriteLine("{0} has index: {1}", alphabet[j], j + 65);
                }
            }
        }
    }
}