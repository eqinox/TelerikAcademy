/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has 
 * maximal sum of its elements.
*/
using System;
class MaximalSumInMatrix
{
    static void Main()
    {
        Console.Write("Height: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Width: ");
        int width = int.Parse(Console.ReadLine());
        int maxSum = 0;
        int[,] matrix = new int[width,height];

        // fill the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        // draw matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        // calculate the sum
        for (int row = 0; row < matrix.GetLength(0) - 3; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 3; col++)
            {
                int currentSum = 0;
                for (int i = row; i < row + 3; i++)
                {
                    for (int j = col; j < col + 3; j++)
                    {
                        currentSum += matrix[i, j];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}
