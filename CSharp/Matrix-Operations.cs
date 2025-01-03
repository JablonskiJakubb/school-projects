using System;

public class MatrixOperations
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random r = new Random();
        int[,] M = new int[n, n];
        int sum = 0;

        // Fill matrix with random numbers and calculate the sum of diagonal elements
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                M[i, j] = r.Next(1, 10); // Fill with random numbers
                if (i - j == 0 || i + j == n - 1) // Diagonal condition
                {
                    sum += M[i, j];
                }
            }
        }

        Console.WriteLine("Sum of diagonal elements: " + sum);
    }
}
