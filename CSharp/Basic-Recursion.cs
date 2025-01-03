using System;

class Program
{
    // Task 1: Factorial
    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    // Task 2: Fibonacci
    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Task 3: Sum of digits
    static int SumOfDigits(int n)
    {
        if (n == 0) return 0;
        return SumOfDigits(n / 10) + n % 10;
    }

    // Task 4: GCD (Greatest Common Divisor)
    static int GCD(int a, int b)
    {
        if (b == 0) return a;
        return GCD(b, a % b);
    }

    // Task 5: Power of a number
    static int Power(int baseNum, int exponent)
    {
        if (exponent == 0) return 1;
        return baseNum * Power(baseNum, exponent - 1);
    }

    // Task 6: Iterative Fibonacci
    static int IterativeFibonacci(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, c;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return b;
    }

    // Task 7: Recursive version for finding minimum in an array
    static int FindMinIndex(int[] a, int i)
    {
        if (i == a.Length - 1) return i;
        int j = FindMinIndex(a, i + 1);
        return (a[i] < a[j]) ? i : j;
    }

    // Task 8: Iterative version for finding minimum in an array
    static int IterativeFindMin(int[] a, int startIndex)
    {
        int min = startIndex;
        for (int i = startIndex + 1; i < a.Length; i++)
        {
            if (a[i] < a[min]) min = i;
        }
        return min;
    }

    static void Main(string[] args)
    {
        // Testing Task 1: Factorial
        Console.WriteLine($"Factorial of 5: {Factorial(5)}");

        // Testing Task 2: Fibonacci
        Console.WriteLine($"Fibonacci of 5: {Fibonacci(5)}");

        // Testing Task 3: Sum of digits
        Console.WriteLine($"Sum of digits of 123: {SumOfDigits(123)}");

        // Testing Task 4: GCD
        Console.WriteLine($"GCD of 48 and 18: {GCD(48, 18)}");

        // Testing Task 5: Power
        Console.WriteLine($"2 to the power of 3: {Power(2, 3)}");

        // Testing Task 6: Iterative Fibonacci
        Console.WriteLine($"Iterative Fibonacci of 5: {IterativeFibonacci(5)}");

        // Testing Task 7: Recursive Find Min Index
        int[] arr = { 5, 1, 8, 9, 7, 2, 3, 11, 20, 15 };
        Console.WriteLine($"Minimum index (recursive): {FindMinIndex(arr, 0)}");

        // Testing Task 8: Iterative Find Min
        Console.WriteLine($"Minimum index (iterative): {IterativeFindMin(arr, 0)}");
    }
}
