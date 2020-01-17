namespace LengthDemo
{
    public sealed class YardConverter : IUnitConverter
    {
        public Unit ConvertType { get; } = Unit.Yard;

        public double ConvertToFoot(double value)
        {
            return value * 3;
        }

        public double ConvertFromFoot(double value)
        {
            return value / 3;
        }
    }
}