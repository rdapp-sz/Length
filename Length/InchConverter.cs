namespace LengthDemo
{
    public sealed class InchConverter : IUnitConverter
    {
        public Unit ConvertType { get; } = Unit.Inch;

        public double ConvertToFoot(double value)
        {
            return value / 12;
        }

        public double ConvertFromFoot(double value)
        {
            return value * 12;
        }
    }
}