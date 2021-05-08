using CaesarCipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cipher.Unittests
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void Cipher_UnitTest_SmallLetter()
        {
            char result = Converter.Cipher('a', 1);
            Assert.AreEqual(result, 'b');
        }
        [TestMethod]
        public void Cipher_UnitTest_BigLetter()
        {
            char result = Converter.Cipher('A', 1);
            Assert.AreEqual(result, 'B');
        }
        [TestMethod]
        public void Cipher_UnitTest_NotLetter()
        {
            char result = Converter.Cipher('1', 1);
            Assert.AreEqual(result, '1');
        }

        [TestMethod]
        public void Encipher_UnitTest_SmallLetters()
        {
            string result = Converter.Encipher("aaa", 1);
            Assert.AreEqual(result, "bbb");
        }
        [TestMethod]
        public void Encipher_UnitTest_BigLetters()
        {
            string result = Converter.Encipher("ABA", 1);
            Assert.AreEqual(result, "BCB");
        }
        [TestMethod]
        public void Encipher_UnitTest_NotLetters()
        {
            string result = Converter.Encipher("133", 4);
            Assert.AreEqual(result, "133");
        }

        [TestMethod]
        public void Encipher_UnitTest_Mix()
        {
            string result = Converter.Encipher("1ab", 3);
            Assert.AreEqual(result, "1de");
        }

        [TestMethod]
        public void Decipher_UnitTest_SmallLetters()
        {
            string result = Converter.Decipher("bbb", 1);
            Assert.AreEqual(result, "aaa");
        }

        [TestMethod]
        public void Decipher_UnitTest_BigLetters()
        {
            string result = Converter.Decipher("EEE", 2);
            Assert.AreEqual(result, "CCC");
        }
        [TestMethod]
        public void Decipher_UnitTest_NotLetters()
        {
            string result = Converter.Decipher("333", 7);
            Assert.AreEqual(result, "333");
        }
        [TestMethod]
        public void Decipher_UnitTest_Mix()
        {
            string result = Converter.Decipher("B c", 1);
            Assert.AreEqual(result, "A b");
        }
    }
}
