/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
 * neighbor elements located on the same line, column or diagonal. Write a program that finds the longest
 * sequence of equal strings in the matrix. Example:
*/
using System;
class LongestSequenceStrings
{
    static void Main()
    {

        Console.Write("Width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Height: ");
        int height = int.Parse(Console.ReadLine());
        string[,] matrix = new string[width, height];
        int maxLength = 1;
        string theElement = "";


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-5}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentMaxLength = 1;
                if (col != matrix.GetLength(1) - 1)// toest ako ne sme na poslednata kolona
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        for (int straight = col; straight < matrix.GetLength(1); straight++)
                        {
                            if (matrix[row, straight] == matrix[row, col])
                            {
                                currentMaxLength++;
                                if (currentMaxLength > maxLength)
                                {
                                    maxLength = currentMaxLength;
                                    theElement = matrix[row, col];
                                }
                            }
                            else
                            {
                                if (currentMaxLength > maxLength)
                                {
                                    maxLength = currentMaxLength;
                                    theElement = matrix[row, col];
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (row != matrix.GetLength(0) - 1) // toest ako ne sme na posledniq red, poslednata kolona
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentMaxLength = 1;
                        for (int down = row; down < matrix.GetLength(0); down++)
                        {
                            if (matrix[row, col] == matrix[down, col])
                            {
                                currentMaxLength++;
                                if (currentMaxLength > maxLength)
                                {
                                    maxLength = currentMaxLength;
                                    theElement = matrix[row, col];
                                }
                            }
                            else
                            {
                                if (currentMaxLength > maxLength)
                                {
                                    maxLength = currentMaxLength;
                                    theElement = matrix[row, col];
                                    break;
                                }
                            }
                        }
                    }
                }
                if (row != matrix.GetLength(0) - 1 && col != matrix.GetLength(1) - 1)//vurvim po diagonala na dolo
                {
                    if (matrix[row + 1, col + 1] == matrix[row, col])
                    {
                        int increassingCol = 0;
                        currentMaxLength = 1;
                        for (int rowDiagonally = row; rowDiagonally < matrix.GetLength(0); rowDiagonally++)
                        {
                            for (int colDiagonally = col + increassingCol; colDiagonally < matrix.GetLength(1); colDiagonally++)
                            {
                                if (matrix[row, col] == matrix[rowDiagonally, colDiagonally])
                                {
                                    currentMaxLength++;
                                    increassingCol++;
                                    if (currentMaxLength > maxLength)
                                    {
                                        maxLength = currentMaxLength;
                                        theElement = matrix[row, col];
                                    }
                                    break;
                                }
                                else
                                {
                                    if (currentMaxLength > maxLength)
                                    {
                                        maxLength = currentMaxLength;
                                        theElement = matrix[row, col];
                                        rowDiagonally = matrix.GetLength(0);
                                        break;
                                    }
                                }
                                
                            }
                        }
                    }
                }
                if (row != 0 && col != matrix.GetLength(1) - 1)// vurvi po diagonala na gore
                {
                    if (matrix[row, col] == matrix[row - 1, col + 1])
                    {
                        currentMaxLength = 1;
                        int increassingCol = 0;
                        for (int rowDiagonally = row; rowDiagonally >= 0; rowDiagonally--)
                        {
                            for (int colDiagonally = col + increassingCol; colDiagonally < matrix.GetLength(1); colDiagonally++)
                            {
                                if (matrix[row, col] == matrix[rowDiagonally, colDiagonally])
                                {
                                    currentMaxLength++;
                                    increassingCol++;
                                    if (currentMaxLength > maxLength)
                                    {
                                        maxLength = currentMaxLength;
                                        theElement = matrix[row, col];
                                    }
                                    break;
                                }
                                else
                                {
                                    if (currentMaxLength > maxLength)
                                    {
                                        maxLength = currentMaxLength;
                                        theElement = matrix[row, col];
                                        rowDiagonally = -1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (row != matrix.GetLength(0) - 1) // vurvim pravo na dolo
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentMaxLength = 1;
                        for (int currentRow = row; currentRow < matrix.GetLength(0); currentRow++)
                        {
                            if (matrix[row, col] == matrix[currentRow, col])
                            {
                                currentMaxLength++;
                                if (currentMaxLength > maxLength)
                                {
                                    maxLength = currentMaxLength;
                                    theElement = matrix[row, col];
                                }
                            }
                            else
                            {
                                if (currentMaxLength > maxLength)
                                {
                                    maxLength = currentMaxLength;
                                    theElement = matrix[row, col];
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine();
        Console.Write("{0} --> ", maxLength - 1);
        for (int i = 0; i < maxLength - 1; i++)
        {
            Console.Write("{0,-4}",theElement);
        }
        Console.WriteLine();
    }
}