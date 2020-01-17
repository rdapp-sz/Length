namespace LengthDemo
{
    public sealed class FootConverter : IUnitConverter
    {
        public Unit ConvertType { get; } = Unit.Foot;

        public double ConvertToFoot(double value)
        {
            return value;
        }

        double IUnitConverter.ConvertFromFoot(double value)
        {
            return value;
        }
    }
}