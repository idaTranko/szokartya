using Microsoft.VisualStudio.TestTools.UnitTesting;
using Szokartya;

namespace UnitTestSzokartya
{
    [TestClass]
    public class TestSzokartya
    {
        [TestMethod]
        public void TestMethod_SulyIncrement()
        {
            // Példányosítás
            SzotarRekord szr = new SzotarRekord();
            szr.Anyanyelv = "kutya";
            szr.Idegennyelv = "dog";
            szr.Suly = 5;

            // Metódus hívása
            szr.IncrementSuly(5);

            // Kiértékelés
            Assert.AreEqual(10, szr.Suly, 0, "Megadott érték hibás.");
        }

        [TestMethod]
        public void TestMethod_UppercaseFirst()
        {
            // Példányosítás

            // Metódus hívása
            string megvaltozottSzoveg = SzokartyaHelper.UppercaseFirst("kutya");

            // Kiértékelés
            Assert.AreEqual("Kutya", megvaltozottSzoveg, false, string.Empty);
        }
    }
}
