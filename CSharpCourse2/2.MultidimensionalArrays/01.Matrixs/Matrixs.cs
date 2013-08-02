/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
*/
using System;
class Matrixs
{
    static void Print(int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write("{0,-3}", arr[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("n= ");
        int size = int.Parse(Console.ReadLine());
        int[,] aMatrix = new int[size, size];
        int[,] bMatrix = new int[size, size];
        int[,] cMatrix = new int[size, size];
        int[,] dMatrix = new int[size, size];

        int index = 1;
        // a)

        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                aMatrix[row, col] = index;
                index++;
            }
        }
        Console.WriteLine("Matrix A:\n");
        Print(aMatrix);

        // b)

        int currentPosition = 0;
        index = 1;
        for (int col = 0; col < size; col++)
        {
            if (currentPosition == 0)
            {
                for (int row = 0; row < size; row++)
                {
                    bMatrix[row, col] = index;
                    index++;
                }
                currentPosition = size;
            }
            else
            {
                for (int row = size - 1; row >= 0; row--)
                {
                    bMatrix[row, col] = index;
                    index++;
                }
                currentPosition = 0;
            }  
        }
        Console.WriteLine("Matrix B:\n");
        Print(bMatrix);

        // c)

        int cols = 0;
        int rows = size - 1;
        int startRows = size - 2;
        int startCols = 0;
        for (int i = 1; i <= size * size; i++)
        {
            cMatrix[rows++, cols++] = i;

            if (rows == size || cols == size)
            {
                rows = startRows;
                if (startRows != 0)
                {
                    startRows--;
                    cols = startCols;
                }
                else
                {
                    cols = startCols;
                    startCols++;
                }
            }
        }
        Console.WriteLine("Matrix C:\n");
        Print(cMatrix);

        // d)

        string direction = "down";
        rows = 0;
        cols = 0;
        int endForBottomAndRight = size;
        int endForTopAndLeft = -1;
        for (int i = 1; i <= size * size; i++)
        {

            if (direction == "down")
            {
                dMatrix[rows, cols] = i;
                rows++;
                if (rows == endForBottomAndRight)
                {
                    rows--;
                    cols++;
                    direction = "right";
                    continue;
                }
            }
            if (direction == "right")
            {
                dMatrix[rows, cols] = i;
                cols++;
                if (cols == endForBottomAndRight)
                {
                    cols--;
                    rows--;
                    direction = "up";
                    endForBottomAndRight--;
                    continue;
                }
            }
            if (direction == "up")
            {
                dMatrix[rows, cols] = i;
                rows--;
                if (rows == endForTopAndLeft)
                {
                    rows++;
                    cols--;
                    direction = "left";
                    endForTopAndLeft++;
                    continue;
                }
            }
            if (direction == "left")
            {
                dMatrix[rows, cols] = i;
                cols--;
                if (cols == endForTopAndLeft)
                {
                    cols++;
                    rows++;
                    direction = "down";
                    continue;
                }
            }
        }
        Console.WriteLine("Matrix D:\n");
        Print(dMatrix);
    }
}