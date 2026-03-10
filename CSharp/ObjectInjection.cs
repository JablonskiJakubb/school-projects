using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    interface IWyjscie
    {
        void Zapisz(string s);
    }
    class naEkran : IWyjscie
    {
        public void Zapisz(string s)
        {
            Console.WriteLine(s);
        }
    }

    class DoPliku : IWyjscie
    {
        public void Zapisz(string s)
        {
            File.AppendAllText("../../wynik.txt", s+"\n");
        }
    }

    class Kalk
    {
        IWyjscie wyjscie;
        
        public Kalk(IWyjscie w)
        {
            wyjscie = w;
        }

        public void dodaj(int a, int b)
        {
            
            int w = a + b;
            Console.WriteLine(w);
            wyjscie.Zapisz(w.ToString());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            naEkran na = new naEkran();
            Kalk kalk = new Kalk(na);
            kalk.dodaj(1, 2);

            DoPliku DP = new DoPliku();
            Kalk kalk2 = new Kalk(DP);
            kalk2.dodaj(1, 2);
        }
    }
}
