using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeTestLib;

namespace PalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRev()
        {
            //Arrange
            string str = "good bye";
            string b = "hey friend";

            Palindromelib pal = new Palindromelib();

            //Act
            str = pal.AnalyzePalin(str);

            //Assert
            Assert.AreEqual(b, str);
        }

        [TestMethod]
        public void TestAnalyzePalin()
        {
            string str = "the tree, is there";
            string a = "thetreeisthere";

            Palindromelib pal = new Palindromelib();

            //Act
            str = pal.AnalyzePalin(str);

            //Assert
            Assert.AreEqual(a, str);
        }

        [TestMethod]
        public void True1()
        {
            //Arrange
            string str = "nurses run";
            Palindromelib pal = new Palindromelib();
            //Act
            bool drome = pal.PalindTest(str);
            //Assert
            Assert.IsTrue(drome);
        }
        [TestMethod]
        public void True2()
        {
            //Arrange
            string str = "racecaR";
            Palindromelib pal = new Palindromelib();
            //Act
            bool drome = pal.PalindTest(str);
            //Assert
            Assert.IsTrue(drome);
        }
        [TestMethod]
        public void True3()
        {
            //Arrange
            string str = "1221";
            Palindromelib pal = new Palindromelib();
            //Act
            bool drome = pal.PalindTest(str);
            //Assert
            Assert.IsTrue(drome);
        }

        [TestMethod]
        public void False()
        {
            //Arrange
            string str = "hi bi hi";
            Palindromelib p = new Palindromelib();
            //Act
            bool pal = p.PalindTest(str);
            //Assert
            Assert.IsFalse(pal);
        }
    }
}
