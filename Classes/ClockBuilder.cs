using System;
using System.Collections.Generic;
using System.Globalization;

namespace BerlinClock.Classes
{
    public class ClockBuilder
    {
        private readonly List<LightsRow> _lightsRows;

        public ClockBuilder()
        {
            _lightsRows = new List<LightsRow>();
        }

        public void AddRow(LightsRow row)
        {
            _lightsRows.Add(row);
        }

        public string BuildClock(string timeString)
        {
            var time = new Time(timeString);
            var lightRowStrings = new List<string>();
            foreach(var row in _lightsRows)
            {
                switch(row.Type)
                {
                    case RowType.Hour:
                        lightRowStrings.Add(row.GetLightsRow(time.Hours));
                        break;
                    case RowType.Minute:
                        lightRowStrings.Add(row.GetLightsRow(time.Minutes));
                        break;
                    case RowType.Second:
                        lightRowStrings.Add(row.GetLightsRow(time.Seconds));
                        break;
                    default:
                        throw new ArgumentException("Invalid row type");
                }
            }

            var result = string.Join(Environment.NewLine, lightRowStrings);
            return result;
        }
    }
}
