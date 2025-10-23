using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_hotel_hotel
{
    public class PokojHotelowy
    {
        public string Typ { get; set; }

        public bool Balkon { get; set; }

        public bool Klimatyzacja { get; set; }

        public bool Telewizor { get; set; }

        public bool Lodowka { get; set; }
        public override string ToString()
        {
            return $"Typ: {Typ}, Balkon: {(Balkon ? "tak" : "nie")}, " +
                   $"Klimatyzacja: {(Klimatyzacja ? "tak" : "nie")}, " +
                   $"Telewizor: {(Telewizor ? "tak" : "nie")}, " +
                   $"Lodówka: {(Lodowka ? "tak" : "nie")}";
        }
    }
    public interface IPokojBuilder
    {
        void UstawTyp(string typ);
        void DodajBalkon();
        void DodajKlimatyzacje();
        void DodajWyposazenie(bool telewizor, bool lodowka);
        PokojHotelowy PobierzPokoj();
    }
    public class StandardowyPokojBuilder : IPokojBuilder
    {
        private PokojHotelowy _pokoj = new PokojHotelowy();

        public void UstawTyp(string typ)
        {
            _pokoj.Typ = typ;
        }

        public void DodajBalkon()
        {
            _pokoj.Balkon = false;
        }

        public void DodajKlimatyzacje()
        {
            _pokoj.Klimatyzacja = true;
        }

        public void DodajWyposazenie(bool telewizor, bool lodowka)
        {
            _pokoj.Telewizor = telewizor;
            _pokoj.Lodowka = lodowka;
        }

        public PokojHotelowy PobierzPokoj()
        {
            return _pokoj;
        }
    }
    public class LuksusowyPokojBuilder : IPokojBuilder
    {
        private PokojHotelowy _pokoj = new PokojHotelowy();
        public void UstawTyp(string typ)
        {
            _pokoj.Typ = typ;
        }

        public void DodajBalkon()
        {
            _pokoj.Balkon = true;
        }

        public void DodajKlimatyzacje()
        {
            _pokoj.Klimatyzacja = true;
        }

        public void DodajWyposazenie(bool telewizor, bool lodowka)
        {
            _pokoj.Telewizor = telewizor;
            _pokoj.Lodowka = lodowka;
        }

        public PokojHotelowy PobierzPokoj()
        {
            return _pokoj;
        }
    }
    public class Recepcja
    {
        public PokojHotelowy PrzygotujPokoj(IPokojBuilder builder)
        {
            // Ustalamy, jak pokój ma być zbudowany
            builder.UstawTyp("Standardowy");
            builder.DodajBalkon();
            builder.DodajKlimatyzacje();

            // Zwracamy gotowy pokój
            return builder.PobierzPokoj();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPokojBuilder builder = new StandardowyPokojBuilder();
            IPokojBuilder builder2 = new LuksusowyPokojBuilder();
            Recepcja recepcja = new Recepcja();

            PokojHotelowy pokojStandartowy = recepcja.PrzygotujPokoj(builder);
            PokojHotelowy pokojLuksusowy = recepcja.PrzygotujPokoj(builder2);

            Console.WriteLine("Pokoje zostały przygotowane:");
            Console.WriteLine(pokojStandartowy);
            Console.WriteLine(pokojLuksusowy);

            Console.ReadKey();

        }
    }
}
