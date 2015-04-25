using ChuckNorris;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChuckNorrisQuotesUnitTest 
{

    [TestClass]
    public class ChuckNorrisQuotesUnitTest 
    {

        private readonly ChuckNorrisQuotes _chuckNorrisQuotes = new ChuckNorrisQuotes();

        [TestMethod]
        public void TestFirst() 
        {
            var nextQuote = _chuckNorrisQuotes.GetNextQuote();
            Assert.AreEqual("Chuck Norris doesn't dial the wrong number. You answered the wrong phone.", nextQuote);
        }

        [TestMethod]
        public void TestLast() 
        {
            for (var i = 1; i < 15; i++) {
                _chuckNorrisQuotes.GetNextQuote();
            }
            var nextQuote = _chuckNorrisQuotes.GetNextQuote();
            Assert.AreEqual("Chuck Norris does not sleep; he waits.", nextQuote);
        }

        [TestMethod]
        public void TestRollBackToFirst() 
        {
            for (var i = 1; i < 16; i++) {
                _chuckNorrisQuotes.GetNextQuote();
            }
            var nextQuote = _chuckNorrisQuotes.GetNextQuote();
            Assert.AreEqual("Chuck Norris doesn't dial the wrong number. You answered the wrong phone.", nextQuote);
            nextQuote = _chuckNorrisQuotes.GetNextQuote();
            Assert.AreEqual("Chuck Norris knows Victoria's secret.", nextQuote);
        }
    }
}
