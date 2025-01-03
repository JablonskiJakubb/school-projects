using System;
using System.Collections;

public class PrimeAndDivisors
{
    // Method to check if a number is prime
    public static bool IsPrime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // Method to find divisors of a number
    public static ArrayList FindDivisors(int n)
    {
        ArrayList divisors = new ArrayList();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                divisors.Add(i);
            }
        }
        return divisors;
    }

    public static void Main()
    {
        // Example: Finding divisors of a number
        int n = 28;
        ArrayList divisors = FindDivisors(n);
        Console.WriteLine("Divisors of " + n + ": " + string.Join(", ", divisors));

        // Example: Checking if a number is prime
        int number = 29;
        Console.WriteLine($"{number} is prime: {IsPrime(number)}");
    }
}
