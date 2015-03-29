using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorris
{
    public class ChuckNorrisQuotes {
        private List<string> quotes;
        private IEnumerator<string> enumerator;

        public ChuckNorrisQuotes() {
            this.quotes = new List<string>();
            quotes.Add("Chuck Norris doesn't dial the wrong number. You answered the wrong phone.");
            quotes.Add("Chuck Norris knows Victoria's secret.");
            quotes.Add("If Chuck Norris was a Spartan in the movie 300, the movie would be called 1.");
            quotes.Add("When Chuck Norris turned 18, his parents moved out.");
            quotes.Add("When Chuck Norris swims in the ocean, the sharks are in a steel cage.");
            quotes.Add("Chuck Norris will never have a heart attack. His heart isn't nearly foolish enough to attack him.");
            quotes.Add("Chuck Norris once kicked a horse in the chin. Its descendants today are known as giraffes.");
            quotes.Add("Chuck Norris doesn't breathe air. He holds air hostage.");
            quotes.Add("Chuck Norris can delete the Recycling Bin.");
            quotes.Add("Chuck Norris has already been to Mars. That's why there are no signs of life.");
            quotes.Add("Chuck Norris can kill two stones with one bird.");
            quotes.Add("Chuck Norris's calendar goes straight from March 31st to April 2. No one fools Chuck Norris.");
            quotes.Add("Chuck Norris wears sunglasses so that his eyes won't hurt the sun.");
            quotes.Add("When Chuck Norris works out he doesn't get stronger, the machine does.");
            quotes.Add("Chuck Norris does not sleep; he waits.");
            enumerator = quotes.GetEnumerator();
        }

        public string GetNextQuote() {
            
            while (enumerator.MoveNext()) {
                return enumerator.Current; 
            }

            return quotes.First();
        }
    }
}
