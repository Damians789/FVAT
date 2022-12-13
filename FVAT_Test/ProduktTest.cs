
using FVAT;
using NUnit.Framework;
using System;

namespace FVATTest
{
    [TestFixture]
    internal class ProduktTest
    {
        private Produkt _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new Produkt("Mandarynka", 5.99, 0.12);
        }
        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }
        [Test]
        public void CheckIfCanCreate()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void CheckIfNameCorrect()
        {
            Assert.That(_sut.Nazwa, Is.EqualTo("Mandarynka"));
        }
        [Test]
        public void CheckIfPriceCorrect()
        {
            Assert.That(_sut.Cena, Is.EqualTo(5.99));
        }
        [Test]
        public void CheckIfTaxCorrect()
        {
            Assert.That(_sut.Tax, Is.EqualTo(0.12));
        }
        [Test]
        public void CheckIfNameChangeCorrect()
        {
            _sut.Nazwa = "Pomarańcz";
            Assert.That(_sut.Nazwa, Is.EqualTo("Pomarańcz"));
        }
        [Test]
        public void CheckIfPriceChangeCorrect()
        {
            _sut.Cena = 4.99;
            Assert.That(_sut.Cena, Is.EqualTo(4.99));
        }
        [Test]
        public void CheckIfTaxChangeCorrect()
        {
            _sut.Tax = 0.13;
            Assert.That(_sut.Tax, Is.EqualTo(0.13));
        }
        [Test]
        public void CheckIfTaxBelowZero_ThrowsException()
        {
            Produkt p;
            Assert.Throws<InvalidOperationException>(() => p = new Produkt("Xbox", 1900.00, -0.15));
        }
        [Test]
        public void CheckIfPriceBelowZero_ThrowsException()
        {
            Produkt p;
            Assert.Throws<InvalidOperationException>(() => p = new Produkt("Nintendo", -1900.00, 0.15));
        }
        [Test]
        public void CheckIfIncorrectName_ThrowsException()
        {
            Produkt p;
            Assert.Throws<InvalidOperationException>(() => p = new Produkt("5 maseł Nintendo", 1900.00, 0.15));
        }
    }
}
