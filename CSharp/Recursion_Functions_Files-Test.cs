// Topics for the test

// 1. Functions

// 1.1 - Write a function that returns the sum of the digits of a given number

int n = int.Parse(Console.ReadLine());
int SumOfDigits(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n = n / 10;
    }
    return sum;
}
Console.WriteLine(SumOfDigits(n));

// 1.2 - Write a function that returns the reversed input string

string text = Console.ReadLine();
char[] array = text.ToCharArray();
Array.Reverse(array);
Console.WriteLine(new String(array));

// 1.3 - Write a function that prints a chain of halves of the entered number, until it reaches 1. For example, inputting 30 should give 30-15-7-3-1. Do you understand? :)

int n = int.Parse(Console.ReadLine());
string result = "";
result += n;
while (n > 1)
{
    n = n / 2;
    result += "-" + n;
}
Console.WriteLine(result);

// 2. Recursion

// 2.1 - Write recursively the first n numbers: 3, 5, 7, 9, 11...

int a = int.Parse(Console.ReadLine());
int RecursionA(int n)
{
    if (n == 1)
    {
        return 3;
    }
    return RecursionA(n - 1) + 2;
}
for (int i = 1; i <= a; i++)
{
    Console.WriteLine(RecursionA(i));
}

// 2.2 - Write recursively the first n numbers: 6, 12, 24, 48, 96...

int a = int.Parse(Console.ReadLine());
int RecursionB(int n)
{
    if (n == 1)
    {
        return 6;
    }
    return RecursionB(n - 1) * 2;
}
for (int i = 1; i <= a; i++)
{
    Console.WriteLine(RecursionB(i));
}

// 2.3 - Write recursively the first n numbers: 1, 1, 3, 5, 11, 21...

int c = int.Parse(Console.ReadLine());
int RecursionC(int n)
{
    if (n < 3) return 1;
    return 2 * RecursionC(n - 2) + RecursionC(n - 1);
}
for (int i = 1; i <= c; i++)
{
    Console.WriteLine(RecursionC(i));
}

// 2.4 - Write recursively the first n numbers: 1, 2, -1, 3, -4, 7, -11, 18...

int d = int.Parse(Console.ReadLine());
int RecursionD(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 2;
    return RecursionD(n - 2) - RecursionD(n - 1);
}
for (int i = 1; i <= d; i++)
{
    Console.WriteLine(RecursionD(i));
}

// 2.5 - Write recursively the first n numbers: 1, 2, 3, 0, 6, 3, -3, 21...

int e = int.Parse(Console.ReadLine());
int RecursionE(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 2;
    if (n == 3) return 3;
    return 3 * RecursionE(n - 3) - RecursionE(n - 1);
}
for (int i = 1; i <= e; i++)
{
    Console.WriteLine(RecursionE(i));
}

// 3. File

// 3.1 - Create a file with today's date

StreamWriter sw1 = new StreamWriter(@"C:\poligon\file1.txt");
sw1.WriteLine(DateTime.Now);
sw1.Flush();
sw1.Close();

// 3.2 - Save 10 random two-digit numbers to a file. Read the file and print the largest of the numbers

StreamWriter sw2 = new StreamWriter(@"C:\poligon\file2.txt");
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    sw2.WriteLine(random.Next(10, 99));
}
sw2.Close();
string[] lines = System.IO.File.ReadAllLines(@"C:\poligon\file2.txt");
int[] T = new int[10];
for (int i = 0; i < 10; i++)
{
    T[i] = int.Parse(lines[i]);
}
Console.WriteLine(T.Max());

// 3.3 - Save 100 random three-digit numbers to a file. Read the file and print all palindrome numbers, e.g., 242 etc.

StreamWriter sw3 = new StreamWriter(@"C:\poligon\file3.txt");
for (int i = 0; i < 100; i++)
{
    sw3.WriteLine(random.Next(100, 999));
}
sw3.Close();
lines = System.IO.File.ReadAllLines(@"C:\poligon\file3.txt");
T = new int[100];
for (int i = 0; i < 100; i++)
{
    T[i] = int.Parse(lines[i]);
    if (T[i] / 100 == T[i] % 10)
    {
        Console.Write(T[i] + " ");
    }
}

long n = 3;
long Factorial(long n)
{
    if (n <= 1)
        return 1;
    return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(n));
