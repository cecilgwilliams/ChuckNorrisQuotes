using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;

namespace ChuckNorris
{
    public class ChuckNorrisActions
    {
        public ChuckNorrisActions() {
            this.Title = "Chuck Norris Greatness";
            this.Punches = new List<DataPoint>();
            this.Kicks = new List<DataPoint>();

            var currentPunches = 0;
            var currentKicks = 0;
            var random = new Random();
            for (var year = 1940; year < 2015; year++)
            {
                currentPunches += random.Next(30);
                currentKicks += random.Next(50);
                this.Punches.Add(new DataPoint(year, currentPunches));
                this.Kicks.Add(new DataPoint(year, currentKicks));
            }
        }

        public string Title { get; private set; }
        public IList<DataPoint> Punches { get; private set; }
        public IList<DataPoint> Kicks { get; private set; }
    }
}
