namespace BerlinClock.Classes
{
    public abstract class LightsRow
    {
        protected string Lights { get; }
        protected int Denominator { get; }
        public RowType Type { get; }
        public abstract string GetLightsRow(int value);

        protected LightsRow(string lights, int denominator, RowType type)
        {
            Lights = lights;
            Denominator = denominator;
            Type = type;
        }
    }
}
