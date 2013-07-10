/** Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
*/
using System;
using System.Text;
class MergeSort
{
    static int[] Splits(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }
        int middle = arr.Length / 2;
        int[] leftArr = new int[middle];
        int[] rightArr = new int[arr.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArr[i] = arr[i];
        }

        for (int i = middle, j = 0; i < arr.Length; i++, j++)
        {
            rightArr[j] = arr[i];
        }

        leftArr = Splits(leftArr);
        rightArr = Splits(rightArr);

        return Merge(leftArr, rightArr);
    }

    static int[] Merge(int[] left, int[] right)
    {
        int leftIncrease = 0;
        int rightIncrease = 0;
        int[] arr = new int[left.Length + right.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                arr[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (left[leftIncrease] >= right[rightIncrease])))
            {
                arr[i] = right[rightIncrease];
                rightIncrease++;
            }
            
        }
        return arr;
    }
    static void Main()
    {
        int[] numbers = {2, 5, 3, 11, 22, 13, 5, 7, 8, 2, 1};
        numbers = Splits(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
    }
}