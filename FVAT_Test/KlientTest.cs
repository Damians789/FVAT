
using FVAT;
using NUnit.Framework;
using System;

namespace FVATTest
{
    [TestFixture]
    public class KlientTest
    {
        private Klient _sut;
        private Adres adres1;

        [SetUp]
        public void Setup()
        {
            adres1 = new Adres("Zakrzewski", "516/675", "35-566", "Krajenka", "Warmińsko-mazurskie");
            _sut = new Klient("Malinowe słonie", adres1, "523213123123", "213123123");
        }
        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }
        [Test]
        public void CheckIfCanCreateSut()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void CheckIfNameCorrect()
        {
            Assert.That(_sut.NazwaFirmy, Is.EqualTo("Malinowe słonie"));
        }
        [Test]
        public void CheckIfNipCorrect()
        {
            Assert.That(_sut.NIP, Is.EqualTo("523213123123"));
        }
        [Test]
        public void CheckIfIBANCorrect()
        {
            Assert.That(_sut.IBAN, Is.EqualTo("213123123"));
        }
        [Test]
        public void CheckIfNameChangeCorrect()
        {
            _sut.NazwaFirmy = "Owocowe poziomki";
            Assert.That(_sut.NazwaFirmy, Is.EqualTo("Owocowe poziomki"));
        }
        [Test]
        public void CheckIfNipChangeCorrect()
        {
            _sut.NIP = "1235312352";
            Assert.That(_sut.NIP, Is.EqualTo("1235312352"));
        }
        [Test]
        public void CheckIfIBANChangeCorrect()
        {
            _sut.IBAN = "9923123125123";
            Assert.That(_sut.IBAN, Is.EqualTo("9923123125123"));
        }
        [Test]
        public void CheckIfStreetCorrect()
        {
            Assert.That(_sut.Adr.Ulica, Is.EqualTo("Zakrzewski"));
        }
        [Test]
        public void CheckIfLocalCorrect()
        {
            Assert.That(_sut.Adr.NumerDomu, Is.EqualTo("516/675"));
        }
        [Test]
        public void CheckIfZipCorrect()
        {
            Assert.That(_sut.Adr.Zip, Is.EqualTo("35-566"));
        }
        [Test]
        public void CheckIfCityCorrect()
        {
            Assert.That(_sut.Adr.Miasto, Is.EqualTo("Krajenka"));
        }
        [Test]
        public void CheckIfRegionCorrect()
        {
            Assert.That(_sut.Adr.Wojewodztwo, Is.EqualTo("Warmińsko-mazurskie"));
        }
        [Test]
        public void CheckIfStreetChange()
        {
            _sut.Adr.Ulica = "Biernacki";
            Assert.That(_sut.Adr.Ulica, Is.EqualTo("Biernacki"));
        }
        [Test]
        public void CheckIfLocalChange()
        {
            _sut.Adr.NumerDomu = "5509/210";
            Assert.That(_sut.Adr.NumerDomu, Is.EqualTo("5509/210"));
        }
        [Test]
        public void CheckIfZipChange()
        {
            _sut.Adr.Zip = "02-595";
            Assert.That(_sut.Adr.Zip, Is.EqualTo("02-595"));
        }
        [Test]
        public void CheckIfCityChange()
        {
            _sut.Adr.Miasto = "Zduny";
            Assert.That(_sut.Adr.Miasto, Is.EqualTo("Zduny"));
        }
        [Test]
        public void CheckIfRegionChange()
        {
            _sut.Adr.Wojewodztwo = "Świętokrzyskie";
            Assert.That(_sut.Adr.Wojewodztwo, Is.EqualTo("Świętokrzyskie"));
        }
        [Test]
        public void CheckIfNameEmpty_ThrowsException()
        {
            Klient k;
            Adres a1 = new Adres("Zakrzewski", "516/675", "35-566", "Krajenka", "Warmińsko-mazurskie");
            Assert.Throws<Exception>(() => k = new Klient("", adres1, "523213123123", "213123123"));
        }
        [Test]
        public void CheckIfIBANEmpty_ThrowsException()
        {
            Klient k;
            Adres a1 = new Adres("Zakrzewski", "516/675", "35-566", "Krajenka", "Warmińsko-mazurskie");
            Assert.Throws<Exception>(() => k = new Klient("Słonie", adres1, "523213123123", ""));
        }
        [Test]
        public void CheckIfNIPEmpty_ThrowsException()
        {
            Klient k;
            Adres a1 = new Adres("Zakrzewski", "516/675", "35-566", "Krajenka", "Warmińsko-mazurskie");
            Assert.Throws<Exception>(() => k = new Klient("Słonie", adres1, "", "2313"));
        }
    }
}
