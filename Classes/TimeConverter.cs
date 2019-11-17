using BerlinClock.Classes;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            var secondsRow =
                new EvenLightsRow(Constants.SecondsRowLights, Constants.SecondsDenominator, RowType.Second);
            var hoursFirstRow = new QuotientLightsRow(Constants.HoursFirstRowLights, Constants.HoursDenominator, RowType.Hour);
            var hoursSecondRow = new RemainderLightsRow(Constants.HoursSecondRowLights, Constants.HoursDenominator, RowType.Hour);
            var minutesFirstRow = new QuotientLightsRow(Constants.MinutesFirstRowLights, Constants.MinutesDenominator, RowType.Minute);
            var minutesSecondRow = new RemainderLightsRow(Constants.MinutesSecondRowLights, Constants.MinutesDenominator, RowType.Minute);

            var builder = new ClockBuilder();
            builder.AddRow(secondsRow);
            builder.AddRow(hoursFirstRow);
            builder.AddRow(hoursSecondRow);
            builder.AddRow(minutesFirstRow);
            builder.AddRow(minutesSecondRow);

            return builder.BuildClock(aTime);
        }
    }
}
