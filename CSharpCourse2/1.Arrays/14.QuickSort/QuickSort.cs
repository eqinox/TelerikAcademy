using System;
using System.Collections.Generic;
using System.Linq;
class QuickSort
{

    static void QuickSort2(int[] arr, int start, int end)
    {
        if (end - start <= 1)
        {
            return;
        }

        int pivotIndex = start;

        for (int i = start + 1; i < end; i++)
        {
            if (arr[i] < arr[pivotIndex])
            {
                int razmqna = arr[pivotIndex];
                arr[pivotIndex] = arr[i];
                arr[i] = razmqna;

                int currentStoinost = arr[pivotIndex + 1];
                arr[pivotIndex + 1] = arr[i];
                arr[i] = currentStoinost;

                pivotIndex++;
            }
        }

        QuickSort2(arr, 0, pivotIndex);
        QuickSort2(arr, pivotIndex + 1, end);

    }

    static void Main()
    {
        int[] numbers = {12, 26, 6, 1, 17, 7, 10, 21, 30, 6 };

        QuickSort2(numbers, 0, numbers.Length);

        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}