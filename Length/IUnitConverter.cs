namespace LengthDemo
{
    public interface IUnitConverter
    {
        Unit ConvertType { get; }

        double ConvertToFoot(double value);

        double ConvertFromFoot(double value);
    }
}