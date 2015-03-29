using System;
using ChuckNorris;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChuckNorrisQuotesUnitTest {
    [TestClass]
    public class ChuckNorrisQuotesUnitTest {

        private ChuckNorrisQuotes chuckNorrisQuotes = new ChuckNorrisQuotes();

        [TestMethod]
        public void TestFirst() {
            var nextQuote = GetNextQuote();
            Assert.AreEqual("Chuck Norris doesn't dial the wrong number. You answered the wrong phone.", nextQuote);
        }

        [TestMethod]
        public void TestLast() {
            var nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            Assert.AreEqual("Chuck Norris does not sleep; he waits.", nextQuote);
        }

        [TestMethod]
        public void TestRollBackToFirst() {
            var nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            nextQuote = GetNextQuote();
            Assert.AreEqual("Chuck Norris doesn't dial the wrong number. You answered the wrong phone.", nextQuote);
        }

        private string GetNextQuote() {
            
            var nextQuote = chuckNorrisQuotes.GetNextQuote();
            Console.WriteLine("Quote is " + nextQuote);
            return nextQuote;
        }

    }
}
