using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//drużyna sportowa do ktorej wsztrzykujemy trenera
//implementacja dodaje stadion

//interfejs trener
//implementacja interfejsu - TrenerKrajowy
//implementacja interfejsu - Zagraniczny
//Durzyna to wiadomo przyjmuje trenera
//implementacja druzyny to wtrzykniecie druzyny i dodanie jej stadionu

//trener ma imie nazwisko i wiek
//druzyna ma nazwe i miasto
//stadion ma miasto i adres
//dodajcie 2 trenerow
//2 druzyny
//3 stadiony
//1 implementacje druzyny
//prosze napsiac metody toString

namespace OI
{
    public interface ITrener
    {
        void Trenuj();
        
    }
    public class TrenerKrajowy : ITrener
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public TrenerKrajowy(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void Trenuj() { Console.WriteLine("trener krajowy"); }
        public override string ToString()
        {
            return ("Imie: " + Imie + " Nazwisko: " + Nazwisko + " Wiek: " + Wiek.ToString());
        }
    }
        
    public class TrenerZagraniczny : ITrener
    {
        

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public TrenerZagraniczny(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }
        public void Trenuj() { Console.WriteLine("Trener zagraniczny"); }

        public override string ToString()
        {
            return ("Imie: " + Imie + ", Nazwisko: " + Nazwisko + ", Wiek: " + Wiek.ToString());
        }

    }
    public class Stadion
    {
        public Stadion(string miasto, string adres)
        {
            Miasto = miasto;
            Adres = adres;
        }

        public string Miasto { get; set; }
        public string Adres { get; set; }
        public override string ToString()
        {
            return ("Miasto: " + Miasto + ", Adres: " + Adres);
        }
    }

    public class Druzyna
    {
        public string Nazwa { get; set; }
        public string Miasto { get; set; }
        ITrener trener;
        public Druzyna(ITrener t, string nazwa, string miasto)
        {
            trener = t;
            Nazwa = nazwa;
            Miasto = miasto;
        }
        public override string ToString()
        {
            return ("Miasto: " + Miasto + ", Nazwa: " + Nazwa + ", Trener: " + trener);
        }
    }
    public class Druzyna_Implementacjion 
    {
        Druzyna druzyna;
        Stadion stadion;
       
        public Druzyna_Implementacjion(Druzyna d, Stadion s)
        {
            druzyna = d;
            stadion = s;
        }
        public override string ToString()
        {
            return ("Drużyna: " + druzyna + ", Stadion: " + stadion);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TrenerKrajowy TK = new TrenerKrajowy("Tomasz", "Kopawryj", 67);
            Console.WriteLine(TK.ToString()) ;
            TrenerZagraniczny JPD = new TrenerZagraniczny("Jean", "Pierre'Dolle", 41);
            Console.WriteLine(JPD.ToString());
            Druzyna LP = new Druzyna(TK, "Lech Poznań", "Poznań");
            Console.WriteLine(LP.ToString());
            Druzyna RK = new Druzyna(JPD, "Rakieta Kijów", "Kijów");
            Console.WriteLine(RK.ToString());

            Stadion B = new Stadion("Poznań", "Bułgarska 67");
            Console.WriteLine(B.ToString());
            Stadion C = new Stadion("Kijów", "Bandery 41");
            Console.WriteLine(C.ToString());
            Stadion A = new Stadion("Jekatinsburg", "Chuiwegd'zie");
            Console.WriteLine(A.ToString());

            Druzyna_Implementacjion DI_1 = new Druzyna_Implementacjion(LP, B);
            Console.WriteLine(DI_1.ToString());
            Druzyna_Implementacjion DI_2 = new Druzyna_Implementacjion(RK, C);
            Console.WriteLine(DI_2.ToString());
        }
    }
}
