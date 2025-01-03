using System;

public class FrequencyCalculation
{
    public static void Main()
    {
        Random r = new Random();
        int[] T = new int[40];
        int[] L = new int[100];
        
        // Populate array with random numbers
        for (int i = 0; i < 40; i++)
        {
            T[i] = r.Next(10, 100);
            L[T[i]]++;
        }

        // Calculate sum of elements that appear exactly twice
        int sum = 0;
        for (int j = 0; j < 100; j++)
        {
            if (L[j] == 2)
            {
                sum += 2 * j;
            }
        }

        Console.WriteLine("Sum of elements that appeared exactly twice: " + sum);
    }
}
