using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using FVAT;

namespace FVATTest
{
    [TestFixture]
    internal class FakturaTest
    {
        private Faktura _sut;
        private Produkt p1, p2, p3;
        [SetUp]
        public void SetUp()
        {
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
        }
        [Test]
        public void CheckITestWorks()
        {
            Assert.Pass();
        }
        [Test]
        public void CheckICanCreate()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void CheckINumbeO1ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p1][0], Is.EqualTo(3));
        }
        [Test]
        public void CheckINumbeO2ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p2][0], Is.EqualTo(2));
        }
        [Test]
        public void CheckINetO1ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p1][1], Is.EqualTo(3 * 5.99));
        }
        [Test]
        public void CheckINetO2ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p2][1], Is.EqualTo(2 * 5.99));
        }
        [Test]
        public void CheckITaxO3ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p3][2], Is.EqualTo(Math.Round((1 * 0.23 * 3555), 4)));
        }
        [Test]
        public void CheckITaxO2ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p2][2], Is.EqualTo(2 * 0.24 * 5.99));
        }
        [Test]
        public void CheckIWorthO1ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p1][3], Is.EqualTo(Math.Round(((3 * 0.12 * 5.99) + (3 * 5.99)), 4)));
        }
        [Test]
        public void CheckIWorthO2ProductIsCorrect()
        {
            Assert.That(_sut.ListaProduktow[p2][3], Is.EqualTo((2 * 0.24 * 5.99) + (2 * 5.99)));
        }
        [Test]
        public void CheckINumberOGeneratedInvoicesCorrect()
        {
            _sut.WygenerujFakture("18092021");
            Assert.That(_sut.IDFaktur.Count, Is.EqualTo(1));
        }
        /*[Test]
        public void CheckICanDuplicate()
        {
            _sut.WygenerujFakture("18092021");
            Assert.Throws<Exception>(() => _sut.WygenerujFakture("18092021"));
        }*/
        [Test]
        public void CheckIDateOPurchaseCorrect()
        {
            _sut.WygenerujFakture("18092021");
            Assert.That(_sut.DataSprzedazy, Is.EqualTo("18092021"));
        }
        [Test]
        public void CheckIDateCorrect()
        {
            _sut.WygenerujFakture("18092021");
            Assert.That(_sut.DataWystawienia, Is.EqualTo(DateTime.Today.ToString()));
        }
        [Test]
        public void CheckICanChangePayDate()
        {
            _sut.DataZaplaty = "19092021";
            Assert.That(_sut.DataZaplaty, Is.EqualTo("19092021"));
        }
        [Test]
        public void CheckIToStringCorrect()
        {
            _sut.WygenerujFakture("18092021");
            Assert.That(_sut.ToString(), Is.EqualTo("\tFAKTURA VAT\n\t" + _sut.IDFaktur.Last() +
                "\t\tData wystawienia: 05.11.2021 00:00:00\n" +
                "SPRZEDAWCA:\n" +
                "Nazwa: Marynowany śledź\n" +
                "Adres: Banasik 7392/418 14-522 Resko Pomorskie\n" +
                "NIP: 0600887425\n" +
                "IBAN: PL17110819766428936444984225\n" +
                "\t\tNABYWCA:\n" +
                "Nazwa/imię i nazwisko: Malinowe słonie\n" +
                "Adres: Zakrzewski 516/675 35-566 Krajenka Warmińsko-mazurskie\n\n" +
                "Lista towarów/usług:\n" +
                "Nazwa towaru/usługi i ich ilość:\tCena netto:\tSuma netto:\tKwota VAT:\tSuma brutto:\n\n" +
                "Mandarynka x 3 sztuk/a/i;\t5,99 zł\t17,97 zł\t2,16 zł\t20,13 zł\n" +
                "Majonez x 2 sztuk/a/i;\t5,99 zł\t11,98 zł\t2,88 zł\t14,86 zł\n" +
                "Teleon x 1 sztuk/a/i;\t3555 zł\t3555 zł\t817,65 zł\t4372,65 zł\n" +
                "\t\tSuma do zapłaty: 4407,63 zł\n"));
        }
    }
}
