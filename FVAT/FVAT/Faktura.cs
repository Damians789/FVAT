using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVAT
{
    public class Faktura
    {
        public static int IloscFaktur = 0;
        public Dictionary<Produkt, double[]> ListaProduktow;
        private Klient KL { get; }
        public int ID { get; set; }
        public HashSet<int> IDFaktur = new HashSet<int>();
        public string DataWystawienia { get; set; }
        public string DataSprzedazy { get; set; }
        public string DataZaplaty { get; set; }

        public void WygenerujFakture(string data)
        {
            var random = new Random();
            ID = random.Next(IloscFaktur, IloscFaktur + 500);
            /*!Object.Equals(this.IDFaktury, default(int))*/
            while (!IDFaktur.Add(ID))
            {
                ID = random.Next(IloscFaktur, IloscFaktur + 500);
            }
            IloscFaktur++;
            /*this.IDFaktury = IloscFaktur;*/
            this.IDFaktur.Add(ID);
            this.DataSprzedazy = data;
            this.DataWystawienia = DateTime.Today.ToString();
        }

        public override string ToString()
        {
            if (!IDFaktur.Contains(this.IDFaktur.Last()))
                throw new Exception("Ta faktura nie została jeszcze wygenerowana");
            string res = "\tFAKTURA VAT\n\t" + this.IDFaktur.Last() +
                "\t\tData wystawienia: " + this.DataWystawienia + "\n" +
                "SPRZEDAWCA:\n" +
                "Nazwa: " + Sprzedawca.NazwaFirmy + "\n" +
                Sprzedawca.Adr.ToString() +
                "NIP: " + Sprzedawca.NIP + "\n" +
                "IBAN: " + Sprzedawca.IBAN + "\n" +
                "\t\tNABYWCA:\n" +
                "Nazwa/imię i nazwisko: " + this.KL.NazwaFirmy + "\n" +
                this.KL.Adr.ToString() + "\n";
            string produkty = "Lista towarów/usług:\n" +
                "Nazwa towaru/usługi i ich ilość:\tCena netto:\tSuma netto:\tKwota VAT:\tSuma brutto:\n\n";
            double suma = 0;
            foreach (Produkt p in this.ListaProduktow.Keys)
            {
                suma += this.ListaProduktow[p][3];
                produkty += p.Nazwa + " x " + this.ListaProduktow[p][0] + " sztuk/a/i;\t" + p.Cena + " zł\t" + this.ListaProduktow[p][1] + " zł\t" +
                    this.ListaProduktow[p][2].ToString("0.00") + " zł\t" + this.ListaProduktow[p][3].ToString("0.00") + " zł\n";
            }
            /*suma = Math.Truncate(suma);*/
            produkty += "\t\tSuma do zapłaty: " + suma.ToString("0.00") + " zł\n";

            if (!Object.Equals(this.DataZaplaty, default(string)))
                return res + produkty + "\nTermin płatności: " + this.DataZaplaty + "\n";
            else
                return res + produkty;

        }

        public Faktura(Klient k, Dictionary<Produkt, int> lp)
        {
            this.KL = k;
            Dictionary<Produkt, double[]> d = new Dictionary<Produkt, double[]>();
            foreach(Produkt p in lp.Keys)
            {
                double[] arr = new double[4];
                arr[0] = lp[p]; //ilosc produktu
                arr[1] = arr[1] = arr[0] * p.Cena; //cena jednostkowa netto
                Math.Round(arr[1], 4);
                arr[2] = arr[1] * p.Tax; //cena netto pozycji
                arr[2] = Math.Round(arr[2], 4);
                arr[3] = arr[1] + arr[2]; //cena jednostkowa brutto
                arr[3] = Math.Round(arr[3], 4);
                d.Add(p, arr);
            }
            this.ListaProduktow = d;
        }
        public static void Main()
        {
            /*Faktura _sut;
            Produkt p1, p2, p3;
            Adres adres1 = new Adres("Zakrzewski", "516/675", "35-566", "Krajenka", "Warmińsko-mazurskie");
            Klient klient1 = new Klient("Malinowe słonie", adres1, "523213123123", "213123123");
            Dictionary<Produkt, int> lista = new Dictionary<Produkt, int>();
            p1 = new Produkt("Mandarynka", 5.99, 0.12);
            p2 = new Produkt("Majonez", 5.99, 0.24);
            p3 = new Produkt("Teleon", 3555, 0.23);
            lista.Add(p1, 3);
            lista.Add(p2, 2);
            lista.Add(p3, 1);

            _sut = new Faktura(klient1, lista);
            Faktura.IloscFaktur = 0;
            Dictionary<Produkt, double[]> d = new Dictionary<Produkt, double[]>();
            foreach (Produkt p in lista.Keys)
            {
                double[] arr = new double[4];
                arr[0] = lista[p]; //ilosc produktu
                arr[1] = arr[1] = arr[0] * p.Cena; //cena jednostkowa netto
                Math.Round(arr[1], 4);
                arr[2] = arr[1] * p.Tax; //cena netto pozycji
                arr[2] = Math.Round(arr[2], 4);
                arr[3] = arr[1] + arr[2]; //cena jednostkowa brutto
                arr[3] = Math.Round(arr[3], 4);
                d.Add(p, arr);
            }*/
        }
    }
}
