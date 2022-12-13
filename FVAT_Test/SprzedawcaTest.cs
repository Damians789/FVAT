
using FVAT;
using NUnit.Framework;
namespace FVATTest
{
    [TestFixture]
    internal class SprzedawcaTest
    {
        [SetUp]
        public void SetUp()
        {
            Sprzedawca.NazwaFirmy = "Marynowany śledź";
            Sprzedawca.Adr = new Adres("Banasik", "7392/418", "14-522", "Resko", "Pomorskie");
            Sprzedawca.NIP = "0600887425";
            Sprzedawca.IBAN = "PL17110819766428936444984225";
        }
        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }
        [Test]
        public void CheckIfNameCorrect()
        {
            Assert.That(Sprzedawca.NazwaFirmy, Is.EqualTo("Marynowany śledź"));
        }
        [Test]
        public void CheckIfNipCorrect()
        {
            Assert.That(Sprzedawca.NIP, Is.EqualTo("0600887425"));
        }
        [Test]
        public void CheckIfIBANCorrect()
        {
            Assert.That(Sprzedawca.IBAN, Is.EqualTo("PL17110819766428936444984225"));
        }
        [Test]
        public void CheckIfNameChangeCorrect()
        {
            Sprzedawca.NazwaFirmy = "Morskie świeżości";
            Assert.That(Sprzedawca.NazwaFirmy, Is.EqualTo("Morskie świeżości"));
        }
        [Test]
        public void CheckIfNipChangeCorrect()
        {
            Sprzedawca.NIP = "1235312352";
            Assert.That(Sprzedawca.NIP, Is.EqualTo("1235312352"));
        }
        [Test]
        public void CheckIfIBANChangeCorrect()
        {
            Sprzedawca.IBAN = "9923123125123";
            Assert.That(Sprzedawca.IBAN, Is.EqualTo("9923123125123"));
        }
        [Test]
        public void CheckIfStreetCorrect()
        {
            Assert.That(Sprzedawca.Adr.Ulica, Is.EqualTo("Banasik"));
        }
        [Test]
        public void CheckIfLocalCorrect()
        {
            Assert.That(Sprzedawca.Adr.NumerDomu, Is.EqualTo("7392/418"));
        }
        [Test]
        public void CheckIfZipCorrect()
        {
            Assert.That(Sprzedawca.Adr.Zip, Is.EqualTo("14-522"));
        }
        [Test]
        public void CheckIfCityCorrect()
        {
            Assert.That(Sprzedawca.Adr.Miasto, Is.EqualTo("Resko"));
        }
        [Test]
        public void CheckIfRegionCorrect()
        {
            Assert.That(Sprzedawca.Adr.Wojewodztwo, Is.EqualTo("Pomorskie"));
        }
        [Test]
        public void CheckIfStreetChange()
        {
            Sprzedawca.Adr.Ulica = "Biernacki";
            Assert.That(Sprzedawca.Adr.Ulica, Is.EqualTo("Biernacki"));
        }
        [Test]
        public void CheckIfLocalChange()
        {
            Sprzedawca.Adr.NumerDomu = "5509/210";
            Assert.That(Sprzedawca.Adr.NumerDomu, Is.EqualTo("5509/210"));
        }
        [Test]
        public void CheckIfZipChange()
        {
            Sprzedawca.Adr.Zip = "02-595";
            Assert.That(Sprzedawca.Adr.Zip, Is.EqualTo("02-595"));
        }
        [Test]
        public void CheckIfCityChange()
        {
            Sprzedawca.Adr.Miasto = "Zduny";
            Assert.That(Sprzedawca.Adr.Miasto, Is.EqualTo("Zduny"));
        }
        [Test]
        public void CheckIfRegionChange()
        {
            Sprzedawca.Adr.Wojewodztwo = "Świętokrzyskie";
            Assert.That(Sprzedawca.Adr.Wojewodztwo, Is.EqualTo("Świętokrzyskie"));
        }
    }
}
