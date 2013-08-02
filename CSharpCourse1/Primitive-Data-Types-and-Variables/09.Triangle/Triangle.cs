using System;
using System.Text;
class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00A9';
        int counterOfCopyRight = 5;
        int counterOfSpaces = 10;
        for (int i = 0; i < 3; i++)
        {
            Console.Write(new string(' ', counterOfSpaces));
            for (int j = 0; j < counterOfCopyRight; j++)
            {
                Console.Write(copyRight);
            }
            counterOfSpaces ++;
            counterOfCopyRight -= 2;
            Console.WriteLine();
        }
    }
}
