namespace BerlinClock.Classes
{
    public class EvenLightsRow : LightsRow
    {
        public EvenLightsRow(string lights, int denominator, RowType type) : base(lights, denominator, type)
        {
        }

        public override string GetLightsRow(int value)
        {
            var remainder = value % Denominator;

            if (remainder == 0)
            {
                return "Y";
            }

            return "O";
        }
    }
}
