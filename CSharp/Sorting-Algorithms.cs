using System;

internal class SortingAlgorithms
{
    public static void Main(string[] args)
    {
        int[] bubbleSortArray = { 79, 86, 97, 43, 64, 25, 12, 22, 11, 7, 23, 5 };
        Console.WriteLine("Bubble Sort:");
        BubbleSort(bubbleSortArray);
        PrintArray(bubbleSortArray);

        int[] insertionSortArray = new int[8];
        Random ra = new Random();
        for (int i = 0; i < insertionSortArray.Length; i++)
        {
            insertionSortArray[i] = ra.Next(1, 10);
            Console.Write(insertionSortArray[i] + " ");
        }
        Console.WriteLine("\nInsertion Sort:");
        InsertionSort(insertionSortArray);
        PrintArray(insertionSortArray);
    }

    // Bubble Sort Algorithm
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    // Insertion Sort Algorithm
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int temp = arr[i];
            int j = i;
            while (j > 0 && arr[j - 1] > temp)
            {
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = temp;
        }
    }

    // Method to print the array
    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
