using System;
class SpiralMatrix
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        int[,] spiralMatrix = new int[userInput, userInput];
        int row = 0;
        int col = 0;
        bool directionRight = true;
        bool directionLeft = false;
        bool directionUp = false;
        bool directionDown = false;
        int helpForMovingForRightDownUp = 1;
        int helpForMovingForLeft = 0;
        for (int i = 1; i <= userInput * userInput; i++)
        {
            if (directionRight)
            {
                spiralMatrix[row, col] = i;
                if (col == userInput - helpForMovingForRightDownUp)
                {
                    directionRight = false;
                    directionDown = true;
                    row++;
                    continue;
                }
                col++;
            }
            if (directionDown)
            {
                spiralMatrix[row, col] = i;
                if (row == userInput - helpForMovingForRightDownUp)
                {
                    directionDown = false;
                    directionLeft = true;
                    col--;
                    continue;
                }
                row++;
            }
            if (directionLeft)
            {
                spiralMatrix[row, col] = i;
                if (col == helpForMovingForLeft)
                {
                    directionLeft = false;
                    directionUp = true;
                    helpForMovingForLeft++;
                    row--;
                    continue;
                }
                col--;
            }
            if (directionUp)
            {
                spiralMatrix[row, col] = i;
                if (row == helpForMovingForRightDownUp)
                {
                    directionUp = false;
                    directionRight = true;
                    col++;
                    helpForMovingForRightDownUp++;
                    continue;
                }
                row--;
            }
        }
        row = 0;
        col = 0;
        for (int i = 0; i < userInput * userInput; i++)
        {
            Console.Write("{0,-3}",spiralMatrix[row, col]);
            if (col == userInput - 1)
            {
                Console.WriteLine();
                col = 0;
                row++;
                continue;
            }
            col++;
        }
    }
}