using ConvertisseurRomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Convertisseur.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(2, "II")]
        [DataRow(4, "IV")]
        [DataRow(13, "XIII")]
        [DataRow(38, "XXXVIII")]
        [DataRow(3224, "MMMCCXXIV")]
        [DataRow(3314, "MMMCCCXIV")]
        [DataRow(3400, "MMMCD")]
        [DataRow(3422, "MMMCDXXII")]
        [DataRow(3661, "MMMDCLXI")]
        [DataRow(9, "IX")]
        public void TestMethod1(int value, string result)
        {
            var sut = Converter.GetRoman(value);

            Assert.AreEqual(result, sut);
        }
    }
}
