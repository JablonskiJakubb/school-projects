using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{

    public class Pokoj
    {
        // Prywatne pola
        private int numerPokoju;
        private int liczbaMiejsc;

        // Konstruktor klasy bazowej
        public Pokoj(int numerPokoju, int liczbaMiejsc)
        {
            this.numerPokoju = numerPokoju;
            this.liczbaMiejsc = liczbaMiejsc;
        }

        // Publiczne metody (gettery)
        public int GetNumerPokoju()
        {
            return numerPokoju;
        }

        public int GetLiczbaMiejsc()
        {
            return liczbaMiejsc;
        }
        public virtual string Opis()
        {
            return "To jest ogólny opis pokoju.";
        }
    }
    public class PokojStandardowy : Pokoj
    {
        private bool HasView { get; set; } = false;
        
        public PokojStandardowy(int numerPokoju, int liczbaMiejsc, bool HasView = false) : base(numerPokoju, liczbaMiejsc)
        {
            this.HasView = HasView;
        }
        public override string Opis()
        {
            return $"Pokoj numer: {GetNumerPokoju()}, ma {GetLiczbaMiejsc()} miejsc. ma widok: {HasView} ";
        }
    }
    public class Apartament : Pokoj
    {
        private int numer_apartamentu { get; set; }
        private int piętro { get; set; }

        public Apartament(int numerPokoju, int liczbaMiejsc, int numer_apartamentu, int pietro) :base(numerPokoju, liczbaMiejsc)
        {
            this.numer_apartamentu = numer_apartamentu;
            this.piętro = piętro;
        }
        public override string Opis()
        {
            return $"Apartament o numerze: {GetNumerPokoju()}, ma {GetLiczbaMiejsc()} miejsc. Znajduje sie w apartamencie {numer_apartamentu} na pietrze {piętro}";
        }
    }
    public class PokójRodzinny : Pokoj
    {
        private int LiczbaDzieci { get; set; }
        private bool CzyLozeczko { get; set; } = false;
        public int GetLiczbaDzieci()
        {
            return LiczbaDzieci;
        }

        public bool GetczyLozeczko()
        {
            return CzyLozeczko;
        }
        public PokójRodzinny(int numerPokoju, int liczbaMiejsc, int liczbaDzieci, bool CzyLozeczko) : base(numerPokoju, liczbaMiejsc)
        {
            this.LiczbaDzieci = liczbaDzieci;
            this.CzyLozeczko = CzyLozeczko;
        }
        public override string Opis()
        {
            return $"Apartament o numerze: {GetNumerPokoju()}, ma {GetLiczbaMiejsc()} miejsc. Ilosc dzieci liczba} na pietrze {GetczyLozeczko}"
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pokoj> pokoje = new List<Pokoj>();
            pokoje.Add(new PokojStandardowy(102, 3, true));
            pokoje.Add(new Apartament(201, 3, 2, 3));
            foreach (Pokoj i in pokoje)
            {
                Console.WriteLine(i.Opis());
            }
            Console.ReadLine();
        }
    }
}
