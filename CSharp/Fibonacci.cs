using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fibo(n);
            

        }
        static void fibo(int n)
        {
            int f = 0;
            int x = 1;
            for (int i = 0; i < n; i++)
            {
                if (czyPierwsza(f))
                {
                    Console.WriteLine(x + "[PIERWSZA]");
                }
                else
                {
                    Console.WriteLine(x);
                }
                int temp = f + x;
                f = x;
                x = temp;

            }
        }
        static bool czyPierwsza(int n)
        {
            int dzielniki = 0;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    dzielniki++;
                }
            }
            if (dzielniki > 0)
            {
                return false;
            }
            return true;
        }
    }
}
czas 30 minut
