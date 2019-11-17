namespace BerlinClock.Classes
{
    public class RemainderLightsRow : LightsRow
    {
        public RemainderLightsRow(string lights, int denominator, RowType type) : base(lights, denominator, type)
        {
        }

        public override string GetLightsRow(int value)
        {
            var lightsCount = value % Denominator;
            var emptyLights = Lights.Length - lightsCount;

            var result = Lights.Substring(0, lightsCount);

            for (var i = 0; i < emptyLights; i++)
            {
                result += "O";
            }

            return result;
        }
    }
}
