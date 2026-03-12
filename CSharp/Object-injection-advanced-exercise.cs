//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace 注射
//{
//    interface I記錄者 // kronikarz
//    {
//        void 保存(string s); // zapisz
//    }

//    class 在屏幕上 : I記錄者 // na ekran
//    {
//        public void 保存(string s)
//        {
//            Console.WriteLine(s);
//        }
//    }

//    class 加倍 : I記錄者 // do pliku
//    {
//        public void 保存(string s)
//        {
//            File.AppendAllText("結果.txt", s + "\n");
//        }
//    }

//    interface I檔案管理員 // archiwista
//    {
//        void 存檔(string s);
//    }

//    class 待辦清單 : I檔案管理員 // do listy
//    {
//        private List<string> 羊皮紙 = new List<string>();

//        public void 存檔(string s)
//        {
//            羊皮紙.Add(s);
//        }
//    }

//    class 作家
//    {
//        I記錄者 kronika;
//        I檔案管理員 archiwum;

//        public 作家(I記錄者 k, I檔案管理員 a)
//        {
//            kronika = k;
//            archiwum = a;
//        }
//        public 作家(I記錄者 k)
//        {
//            kronika = k;
//        }

//        public void 寫(string 文本)
//        {
//            kronika.保存(文本);
//        }
//        public void 存檔(string 文本)
//        {
//            archiwum.存檔(文本);
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            待辦清單 lista = new 待辦清單();
//            在屏幕上 ekran = new 在屏幕上();
//            作家 p1 = new 作家(ekran);
//            p1.寫("Ala ma kota");


//            加倍 plik = new 加倍();
//            作家 p2 = new 作家(plik, lista);
//            p2.寫("Kot ma Alę");
//            p1.存檔("Ala ma kota");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 注射
{
    interface IKronikarz
    {
        void Zapisz(string s);
    }

    class NaEkran : IKronikarz
    {
        public void Zapisz(string s)
        {
            Console.WriteLine(s);
        }
    }

    class DoPliku : IKronikarz
    {
        public void Zapisz(string s)
        {
            File.AppendAllText("wynik.txt", s + "\n");
        }
    }

    interface IArchiwista
    {
        void Archiwizuj(string s);
    }

    class DoListy : IArchiwista
    {
        private List<string> pergamin = new List<string>();

        public void Archiwizuj(string s)
        {
            pergamin.Add(s);
        }
    }

    class Pisarz
    {
        IKronikarz kronika;
        IArchiwista archiwum;

        public Pisarz(IKronikarz k, IArchiwista a)
        {
            kronika = k;
            archiwum = a;
        }
        public Pisarz(IKronikarz k)
        {
            kronika = k;
        }


        public void Napisz(string tekst)
        {
            kronika.Zapisz(tekst);
        }
        public void Archiwizuj(string tekst)
        {
            archiwum.Archiwizuj(tekst);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DoListy lista = new DoListy();
            NaEkran ekran = new NaEkran();
            Pisarz p1 = new Pisarz(ekran);
            p1.Napisz("Je suis Jacob");
            p1.Archiwizuj("Pierre Dolle");

            DoPliku plik = new DoPliku();
            Pisarz p2 = new Pisarz(plik, lista);
            p2.Napisz("Je T'aime");
        }
    }
}
