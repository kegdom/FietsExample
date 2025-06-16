using System;
using System.Collections.Generic;
using FietsExample;

namespace FietsExampleTest;

public class FietsExampleTests
{
    [TestFixture]
    public class BestellingTests
    {
        [SetUp]
        public void Init()
        {
            Catalogus.GetInstance();
        }

        [Test]
        public void AddBestelling()
        {
            // Arrange
            var catalogus = Catalogus.GetInstance();
            var racefiets = catalogus.Lookup(1);
            var elecfiets = catalogus.Lookup(2);
            var gps = catalogus.Lookup(3);
            var fietstassen = catalogus.Lookup(4);

            var bestelling = new Bestelling(1);

            // Act
            bestelling.Regels.Add(new Regel(1, racefiets));
            bestelling.Regels.Add(new Regel(2, elecfiets));
            bestelling.Regels.Add(new Regel(3, gps));
            bestelling.Regels.Add(new Regel(4, fietstassen));

            // Assert
            Assert.That(bestelling.Regels.Count, Is.EqualTo(4),
                "Er zouden precies vier regels in de bestelling moeten zitten.");
        }

        [Test]
        public void BerekenTotaalPrijs_Geeft_Juiste_Waarde()
        {
            // Arrange
            var catalogus = Catalogus.GetInstance();
            var racefiets = catalogus.Lookup(1);
            var elecfiets = catalogus.Lookup(2);
            var gps = catalogus.Lookup(3);
            var fietstassen = catalogus.Lookup(4);

            // Act
            var bestelling = new Bestelling(1);
            bestelling.Regels.Add(new Regel(1, racefiets));
            bestelling.Regels.Add(new Regel(2, elecfiets));
            bestelling.Regels.Add(new Regel(3, gps));
            bestelling.Regels.Add(new Regel(4, fietstassen));

            var totaal = bestelling.BerekenTotaalPrijs();

            // Assert 4334.9 total
            Assert.That(totaal, Is.EqualTo(4334.9f).Within(0.01f),
                "De berekende totaalprijs moet overeenkomen met de som van alle regels.");
        }
    }
}