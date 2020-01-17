namespace LengthDemo
{
    public class Length
    {
        private static readonly UnitConverterFactory _converterFactory = new UnitConverterFactory();
        private readonly double m_footValue;

        public Length(double val, Unit unit) 
            : this(val, _converterFactory.GetConverter(unit))
        {
        }

        private Length(double val, IUnitConverter converter)
        {
            Val = val;
            Unit = converter.ConvertType;
            m_footValue = converter.ConvertToFoot(val);
        }

        public Length As(Unit unit)
        {
            var converter = _converterFactory.GetConverter(unit);
            return new Length(converter.ConvertFromFoot(m_footValue), converter.ConvertType);
        }

        public double Val { get; }

        public Unit Unit { get; }
    }
}
