using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCountTests
{
    [TestClass]
    public class WordCountTest
    {
        private string tex = "One two three\nfour five six";

        [TestMethod]
        public void CountLines_String_NumberOfLines()
        {
            string result = CountWords.CountLines(tex);
            string expected = "Lines = 2";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountWord_String_NumberOfWords()
        {
            string result = CountWords.CountWord(tex);
            string expected = "Words = 6";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountChars_String_NumberOfChars()
        {
            string result = CountWords.CountChars(tex);
            string expected = "Chars = 22";
            Assert.AreEqual(expected, result);
        }
    }
}
