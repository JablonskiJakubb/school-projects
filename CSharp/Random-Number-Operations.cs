using System;

public class RandomNumberOperations
{
    public static void Main()
    {
        Random r = new Random();
        int[] T = new int[20];
        int count = 0;

        // Generate 20 numbers that are even and not prime
        while (count < 20)
        {
            int number = r.Next(100, 1000);
            if (number % 2 == 0 && !PrimeAndDivisors.IsPrime(number))
            {
                T[count] = number;
                count++;
            }
        }

        Console.WriteLine("Generated numbers (even, not prime): ");
        foreach (var num in T)
        {
            Console.Write(num + " ");
        }
    }
}
