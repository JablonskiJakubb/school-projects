using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] T;
            int n = WczytajIlosc();
            T = new int[n];
            Console.WriteLine("Podaj Liczby");
            for (int i = 0; i < n;)
            {

                if (int.TryParse(Console.ReadLine(), out int x) && x > 0 && x < 10000)
                {
                    T[i] = x;
                    i++;
                }
                else
                {
                    Console.WriteLine("Podawaj jedynie LICZBY w zakresie 1-9999");
                }
            }
            T = Sortuj(T);
            Console.WriteLine("Posortowane liczby wg sumy cyfr:");
            foreach (int elem in T)
            {
                Console.WriteLine(elem);
            }

        }
        static int WczytajIlosc()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Podaj ilość liczb");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n > 2 && n < 21)
                    {
                        return n;
                    }
                }
                Console.WriteLine("Liczba musi być w zakresie 3-20");
            }
        }
        static int[] Sortuj(int[] T)
        {
            for (int i = 0; i < T.Length-1; i++)
            {
                for (int j = 0; j < T.Length-1; j++)
                {
                    if (SumaCyfr(T[j]) >= SumaCyfr(T[j + 1]))
                    {
                        int temp = T[j];
                        T[j] = T[j + 1];
                        T[j + 1] = temp;

                    }
                }
            }
            return T;
        }
        static int SumaCyfr(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }

    }
}


// Ile czasu: 1H
// Pomoc z zewnątrz: 20% (przypominanie i znajdywane błedów)
// Czego nauczyłeś się wykonując to zadanie?: przypomnialem sobie bąbelkowe
// wynik na egzaminie: 35/100 (pozapominalem wiele przez swieta)

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
            do
            {
                Console.WriteLine("Podaj liczbę: ");
                int n = int.Parse(Console.ReadLine());
                fibo(n);
                Console.WriteLine("Czy chcesz wygenerowac kolejny ciąg? Y/N");
                string input = Console.ReadLine();
                if (input == "n" || input == "N")
                {
                    break;
                }
            } while (true);
            


        }
        static void fibo(int n)
        {
            Console.WriteLine("=== FIBONACCI I LICZBY PIERWSZE ===");
            int suma = 0;
            int f = 0;
            int x = 1;
            for (int i = 0; i < n; i++)
            {
                if (czyPierwsza(x))
                {
                    Console.WriteLine(x + "[PIERWSZA]");
                    suma += 1;
                }
                else
                {
                    Console.WriteLine(x);
                }
                int temp = f + x;
                f = x;
                x = temp;
                
                

            }
            Console.WriteLine("=== STATYSTYKI ===");
            Console.WriteLine($"liczb pierwszych jest: {suma} / {n} ({suma *100/ n}%)");
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

// Ile czasu: 1H
// Pomoc z zewnątrz: 20% (znajdywane błedów)
// Czego nauczyłeś się wykonując to zadanie?: nic nowego
// wynik na egzaminie: 50/100 (pozapominalem wiele przez swieta)
