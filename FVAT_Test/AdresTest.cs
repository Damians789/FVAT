using System;
using NUnit.Framework;
using FVAT;

namespace FVATTest
{
    [TestFixture]
    public class AdresTest
    {
        private Adres _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new Adres("Zakrzewski", "516/675", "35-566", "Krajenka", "Warmińsko-mazurskie");
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
        public void CheckIfStreetCorrect()
        {
            Assert.That(_sut.Ulica, Is.EqualTo("Zakrzewski"));
        }
        [Test]
        public void CheckIfLocalCorrect()
        {
            Assert.That(_sut.NumerDomu, Is.EqualTo("516/675"));
        }
        [Test]
        public void CheckIfZipCorrect()
        {
            Assert.That(_sut.Zip, Is.EqualTo("35-566"));
        }
        [Test]
        public void CheckIfCityCorrect()
        {
            Assert.That(_sut.Miasto, Is.EqualTo("Krajenka"));
        }
        [Test]
        public void CheckIfRegionCorrect()
        {
            Assert.That(_sut.Wojewodztwo, Is.EqualTo("Warmińsko-mazurskie"));
        }
        [Test]
        public void CheckIfStreetChange()
        {
            _sut.Ulica = "Biernacki";
            Assert.That(_sut.Ulica, Is.EqualTo("Biernacki"));
        }
        [Test]
        public void CheckIfLocalChange()
        {
            _sut.NumerDomu = "5509/210";
            Assert.That(_sut.NumerDomu, Is.EqualTo("5509/210"));
        }
        [Test]
        public void CheckIfZipChange()
        {
            _sut.Zip = "02-595";
            Assert.That(_sut.Zip, Is.EqualTo("02-595"));
        }
        [Test]
        public void CheckIfCityChange()
        {
            _sut.Miasto = "Zduny";
            Assert.That(_sut.Miasto, Is.EqualTo("Zduny"));
        }
        [Test]
        public void CheckIfRegionChange()
        {
            _sut.Wojewodztwo = "Świętokrzyskie";
            Assert.That(_sut.Wojewodztwo, Is.EqualTo("Świętokrzyskie"));
        }
    }
}