/** Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. Example:
*/
using System;
class DfsAlgorithm
{
    static int[,] matrix = {
                            {1, 3, 2, 2, 2, 4},
                            {3, 3, 3, 2, 4, 4},
                            {4, 3, 1, 2, 3, 3},
                            {4, 3, 1, 3, 3, 1},
                            {4, 3, 3, 3, 1, 1},
                            };
    static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
    static int maxLength = 1;
    static int currentLength = 1;
    static int wantedElement = 0;
    static void CheckNeightbours(int row, int col)
    {
        //UP
        if (row != 0)
        {
            if (visited[row - 1, col])
            {

            }
            else if (matrix[row - 1, col] == matrix[row, col])
            {
                currentLength++;
                visited[row - 1, col] = true;
                CheckNeightbours(row - 1, col);
            }
        }
        //Up Right
        if (row != 0 && col != matrix.GetLength(1) - 1)
        {
            if (visited[row - 1, col + 1])
            {

            }
            else if (matrix[row - 1, col + 1] == matrix[row, col])
            {
                currentLength++;
                visited[row - 1, col + 1] = true;
                CheckNeightbours(row - 1, col + 1);
            }
        }
        //Right
        if (col != matrix.GetLength(1) - 1)
        {
            if (visited[row, col + 1])
            {

            }
            else if (matrix[row, col + 1] == matrix[row, col])
            {
                currentLength++;
                visited[row, col + 1] = true;
                CheckNeightbours(row, col + 1);
            }
        }
        //Down Right
        if (row != matrix.GetLength(0) - 1 && col != matrix.GetLength(1) - 1)
        {
            if (visited[row + 1, col + 1])
            {

            }
            else if (matrix[row + 1, col + 1] == matrix[row, col])
            {
                currentLength++;
                visited[row + 1, col + 1] = true;
                CheckNeightbours(row + 1, col + 1);
            }
        }
        //Down
        if (row != matrix.GetLength(0) - 1)
        {
            if (visited[row + 1, col])
            {

            }
            else if (matrix[row + 1, col] == matrix[row, col])
            {
                currentLength++;
                visited[row + 1, col] = true;
                CheckNeightbours(row + 1, col);
            }
        }
        //Down Left
        if (row != matrix.GetLength(0) - 1 && col != 0)
        {
            if (visited[row + 1, col - 1])
            {

            }
            else if (matrix[row + 1, col - 1] == matrix[row, col])
            {
                currentLength++;
                visited[row + 1, col - 1] = true;
                CheckNeightbours(row + 1, col - 1);
            }
        }
        //Left
        if (col != 0)
        {
            if (visited[row, col - 1])
            {

            }
            else if (matrix[row, col - 1] == matrix[row, col])
            {
                currentLength++;
                visited[row, col - 1] = true;
                CheckNeightbours(row, col - 1);
            }
        }
        //Up Left
        if (col != 0 && row != 0)
        {
            if (visited[row - 1, col - 1])
            {

            }
            else if (matrix[row - 1, col - 1] == matrix[row, col])
            {
                currentLength++;
                visited[row - 1, col - 1] = true;
                CheckNeightbours(row - 1, col - 1);
            }
        }
        else
        {
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                wantedElement = matrix[row, col];
            }
            return;
        }
    }
    static void PrintMatrix()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                visited[row, col] = true;
                currentLength = 1;
                CheckNeightbours(row, col);
            }
        }
        PrintMatrix();
        Console.WriteLine("number: {0}, {1} times", wantedElement, maxLength);
    }
}