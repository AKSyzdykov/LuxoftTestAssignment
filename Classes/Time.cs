using System;
using System.Globalization;

namespace BerlinClock.Classes
{
    public class Time
    {
        public Time(string timeString)
        {
            if (!DateTime.TryParseExact(timeString, "HH:mm:ss", null, DateTimeStyles.None, out DateTime time))
            {
                if (timeString.Equals("24:00:00"))
                {
                    Hours = 24;
                    Minutes = 0;
                    Seconds = 0;
                }
                else
                {
                    throw new ArgumentException("Invalid time string");
                }
            }
            else
            {
                Hours = time.Hour;
                Minutes = time.Minute;
                Seconds = time.Second;
            }
        }

        public int Hours { get; }

        public int Minutes { get; }

        public int Seconds { get; }
    }
}
