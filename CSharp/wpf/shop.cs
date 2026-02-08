using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sklep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Koszyk koszyk;
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            koszyk  = new Koszyk();
            PokazProdukt(i);
            bPrev.IsEnabled = false;
        }
        private void PokazProdukt(int index)
        {
            if (koszyk.Produkty.Count == 0)
            {
                Dane.Text = "Brak produktów";
                Cena.Text = "";
                return;
            }

            if (index < 0) index = 0;
            if (index >= koszyk.Produkty.Count) index = koszyk.Produkty.Count - 1;

            Dane.Text = koszyk.Produkty[index].Nazwa;
            Cena.Text = koszyk.Produkty[index].Cena.ToString() + " zł";
        }
        private void bPrev_Click(object sender, RoutedEventArgs e)
        {
            
            if (i > 0) i--;
            PokazProdukt(i);
            if (i == 0) { bPrev.IsEnabled = false; }else { bPrev.IsEnabled = true; }
        }
        private void bNext_Click(object sender, RoutedEventArgs e)
        {
            if (i < koszyk.Produkty.Count-1) i++;
            PokazProdukt(i);
            if (i == koszyk.Produkty.Count-1) { bNext.IsEnabled = false; } else { bPrev.IsEnabled = true; }
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            IZniżkaStrategia strategia;
            if (stala.IsChecked == true)
            {
                przed.Content = "Przed: " + koszyk.Produkty[i].Cena + " zł";
                po.Content = "Po: " + (koszyk.Produkty[i].Cena - int.Parse(Znizka.Text)) + " zł";
            }
            if (procent.IsChecked == true)
            {
                if (int.Parse(Znizka.Text) > 0 && int.Parse(Znizka.Text) < 100)
                {
                    przed.Content = "Przed: " + koszyk.Produktya[i].Cena + " zł";
                    po.Content = "Po: " + (koszyk.Produkty[i].Cena - koszyk.Produkty[i].Cena * int.Parse(Znizka.Text)/100).ToString() + " zł";
                }
                else
                {
                    MessageBox.Show("Zły procent");
                }
            }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                MessageBox.Show("A key pressed");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sklep
{
    internal interface IZniżkaStrategia
    {
        int obliczZniżkę(int k, int x);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class Koszyk
    {
        public List<Produkt> Produkty = new();
        public IZniżkaStrategia ZniżkaStrategia;

        public Koszyk()
        {
            generujPróbki();
        }

        private void generujPróbki()
        {
            Produkty.Add(new ProduktFizyczny("Komputer", 400));
            Produkty.Add(new ProduktFizyczny2("Zinger", 25));
            Produkty.Add(new ProduktFizyczny2("Żyd", 0));
            Produkty.Add(new ProduktFizyczny2("Murzyn", 10000000));
            Produkty.Add(new ProduktFizyczny2("Biały", 271000));
        }

        public int obliczWartośćKoszyka()
        {
            int w = 0;
            foreach (var item in Produkty)
            {
                w += item.Cena;
            }
            return w;
        }

        public int obliczWartośćKoszykaPoRabacie(IZniżkaStrategia zniżkaStrategia, int x)
        {
            this.ZniżkaStrategia = zniżkaStrategia;
            int w = obliczWartośćKoszyka();
            return ZniżkaStrategia.obliczZniżkę(w, x);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal abstract class Produkt
    {
        public String Nazwa;
        public int Cena;

        protected Produkt(string nazwa, int cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class ProduktFizyczny : Produkt
    {
        public ProduktFizyczny(string nazwa, int cena) : base(nazwa, cena)
        {
        }
    }

    internal class ProduktFizyczny2 : Produkt
    {
        public ProduktFizyczny2(string nazwa, int cena) : base(nazwa, cena)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    internal class ZniżkaKwotowa : IZniżkaStrategia
    {
        public int obliczZniżkę(int k, int x)
        {
            return k - x;
        }
    }

    internal class ZniżkaProcentowa : IZniżkaStrategia
    {
        public int obliczZniżkę(int k, int x)
        {
            return (k * (100 - x)) / 100;
        }
    }
}
