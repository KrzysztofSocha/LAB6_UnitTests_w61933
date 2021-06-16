using Microsoft.VisualStudio.TestTools.UnitTesting;
using UlamekBiblioteka;
using System;
namespace UlamekBibliotekaTestProject
{
    [TestClass]
    public class UlamekUnitTest1
    {
        [TestMethod]
        public void TestKonstruktorWlasnosci()
        {
            //przygotowanie =>Arrange
            int licznik = 1;
            int mianownik = 2;
            //dzia³anie =>Act
            Ulamek u = new Ulamek(licznik, mianownik);
            //weryfikacja => Assert
            Assert.AreEqual(licznik, u.Licznik, "Niezgodnosc w liczniku");
            //licznik - wartoœæ spodziewana, u.Licznik -wartoœæ uzyskiwana w wyniku testu
            Assert.AreEqual(mianownik, u.Mianownik, "Niezgodnosc w mianowniku");
        }
        [TestMethod]
        public void TestKonstruktora()
        {
            //przygotowanie =>Arrange
            int licznik = 1;
            int mianownik = 2;
            //dzia³anie =>Act
            Ulamek u = new Ulamek(licznik, mianownik);
            PrivateObject po = new PrivateObject(u);
            int u_licznik = u.Licznik;
            //weryfikacja => Assert
            int u_mianownik = (int)po.GetField("mianownik");
            Assert.AreEqual(licznik, u.Licznik, "Niezgodnosc w liczniku");
            //licznik - wartoœæ spodziewana, u.Licznik -wartoœæ uzyskiwana w wyniku testu
            Assert.AreEqual(mianownik, u.Mianownik, "Niezgodnosc w mianowniku");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestKonstruktoraWyjatek()
        {
            Ulamek u = new Ulamek(1, 0);
        }
        [TestMethod]
        public void TestUprosc()
        {
            Ulamek u = new Ulamek(4, -2);
            u.Uprosc();
            Assert.AreEqual(-2, u.Licznik);
            Assert.AreEqual(1, u.Mianownik);
        }
    }
}
