// RANDOM ARRAY GENERATION (BASE CODE)
Random r = new Random();
int[] T = new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1, 21);
}
for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
}

// FINDING MAXIMUM IN ARRAY
int maxNumber = int.MinValue;
int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] > maxNumber)
    {
        maxNumber = W[i];
    }
}
Console.WriteLine(maxNumber);

// MAXIMUM FROM RANDOM NUMBERS
Random r = new Random();
int maxNumber = int.MinValue;
int[] W = new int[20];
for (int i = 0; i < W.Length; i++)
{
    W[i] = r.Next(1, 21);
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] > maxNumber)
    {
        maxNumber = W[i];
    }
}
for (int i = 0; i < W.Length; i++)
{
    Console.Write(W[i] + " ");
}  
Console.WriteLine("\n\n" + maxNumber);

// FINDING MINIMUM VALUE
Random r = new Random();
int minNumber = int.MaxValue;
int[] W = new int[20];
for (int i = 0; i < W.Length; i++)
{
    W[i] = r.Next(1, 21);
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] < minNumber)
    {
        minNumber = W[i];
    }
}
for (int i = 0; i < W.Length; i++)
{
    Console.Write(W[i] + " ");
}
Console.WriteLine("\n\n" + minNumber);

// FIND MAX, MIN, AND DIFFERENCE BETWEEN THEM
Random r = new Random();
int maxNumber = int.MinValue;
int minNumber = int.MaxValue;
int[] W = new int[20];
for (int i = 0; i < W.Length; i++)
{
    W[i] = r.Next(1, 21);
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] < minNumber)
    {
        minNumber = W[i];
    }
    if (W[i] > maxNumber) 
    {
        maxNumber = W[i];
    }
}
for (int i = 0; i < W.Length; i++)
{
    Console.Write(W[i] + " ");
}
Console.WriteLine("\n" + minNumber);
Console.WriteLine("\n" + maxNumber);
Console.WriteLine();
Console.WriteLine(maxNumber - minNumber);

// CALCULATING THE SUM OF AN ARRAY
Random r = new Random();
int sum = 0;
int[] T = new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(1,200);
}
for (int i = 0; i < T.Length; i++)
{
    sum += T[i];
}
Console.WriteLine(sum);

// FINDING MAXIMUM IN ARRAY WITH COUNT OF OCCURRENCES
Random r = new Random();
int maxNumber = int.MinValue;
int occurrences = 1;
int[] W = new int[20];
for (int i = 0; i < W.Length; i++)
{
    W[i] = r.Next(1, 21);
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] > maxNumber)
    {
        maxNumber = W[i];
    }
}
for (int i = 0; i < W.Length; i++)
{
    Console.Write(W[i] + " ");
}
Console.WriteLine("\n\n" + maxNumber);

// FINDING MAXIMUM AND COUNTING OCCURRENCES OF MAXIMUM
int maxNumber = T[0];
int count = 1;
foreach (int x in T)
{
    if (x > maxNumber)
    {
        maxNumber = x;
        count = 1;
    }
    else if (x == maxNumber)
    {
        count += 1;
    }
}
Console.WriteLine();
Console.WriteLine(maxNumber + " - " + count);
