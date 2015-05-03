using System.Collections.Generic;

namespace ChuckNorris
{
    public class ChuckNorrisQuotes {
        private readonly IEnumerator<string> _enumerator;

        public ChuckNorrisQuotes() {
            var quotes = new List<string> {
                "Chuck Norris doesn't dial the wrong number. You answered the wrong phone.",
                "Chuck Norris knows Victoria's secret.",
                "If Chuck Norris was a Spartan in the movie 300, the movie would be called 1.",
                "When Chuck Norris turned 18, his parents moved out.",
                "When Chuck Norris swims in the ocean, the sharks are in a steel cage.",
                "Chuck Norris will never have a heart attack. His heart isn't nearly foolish enough to attack him.",
                "Chuck Norris once kicked a horse in the chin. Its descendants today are known as giraffes.",
                "Chuck Norris doesn't breathe air. He holds air hostage.",
                "Chuck Norris can delete the Recycling Bin.",
                "Chuck Norris has already been to Mars. That's why there are no signs of life.",
                "Chuck Norris can kill two stones with one bird.",
                "Chuck Norris's calendar goes straight from March 31st to April 2. No one fools Chuck Norris.",
                "Chuck Norris wears sunglasses so that his eyes won't hurt the sun.",
                "When Chuck Norris works out he doesn't get stronger, the machine does.",
                "Chuck Norris does not sleep; he waits."
            };
            _enumerator = quotes.GetEnumerator();
        }

        public string GetNextQuote() {
            
            if (_enumerator.MoveNext()) {
                return _enumerator.Current;
            }

            _enumerator.Reset();
            return GetNextQuote();
        }
    }
}
