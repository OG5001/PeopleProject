using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleProject.Test
{
    [TestFixture]
    class PeopleTests
    {
        People people;

        [SetUp]
        public void Setup()
        {
            people = new People();
        }

        [Test]
        public void AtlagEletkor_Helyes_Hasznalata()
        {
            people.UjSzemely(20);
            people.UjSzemely(30);
            people.UjSzemely(40);
            double atlag = people.AtlagEletkor(20, 40);
            Assert.That(atlag, Is.EqualTo(30));
        }
        [Test]
        public void Atlag_Eletkor_Nem_Megflelo_Hatarertek()
        {
            people.UjSzemely(1);
            people.UjSzemely(2);
            Assert.That(() => people.AtlagEletkor(20, 30), Throws.TypeOf<ArgumentException>());
        }
        [Test]
        public void Atlag_Eletkor_Nincs_Szemely()
        {
            Assert.That(() => people.AtlagEletkor(20, 30), Throws.TypeOf<InvalidOperationException>());
        }
        [Test]
        public void Atlag_Eletkor_Negativ_Hatarertek()
        {
            people.UjSzemely(1);
            people.UjSzemely(15);
            Assert.That(() => people.AtlagEletkor(-5, 15), Throws.TypeOf<ArgumentException>());
        }
        [Test]
        public void Atlag_MinEletkor_Nagyobb_Mint_MaxEletkor()
        {
            people.UjSzemely(1);
            people.UjSzemely(10);
            Assert.That(() => people.AtlagEletkor(10, 1), Throws.TypeOf<ArgumentException>());
        }
    }
}
