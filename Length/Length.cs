namespace LengthDemo
{
    public class Length
    {
        public Length(double val, Unit unit)
        {
            Val = val;
            Unit = unit;
        }

        public Length As(Unit unit)
        {
            var len = this;
            var currentUnit = Unit;

            if (currentUnit == Unit.Foot)
            {
                if (unit == Unit.Yard)
                {
                    len = new Length(Val / 3, unit);
                }
                else if (unit == Unit.Inch)
                {
                    len = new Length(Val * 12, unit);
                }
            }

            if (currentUnit == Unit.Yard)
            {
                if (unit == Unit.Inch)
                {
                    len = new Length(Val * 36, unit);
                }
                else if (unit == Unit.Foot)
                {
                    len = new Length(Val * 3, unit);
                }
            }

            if (currentUnit == Unit.Inch)
            {
                if (unit == Unit.Foot)
                {
                    len = new Length(Val / 12, unit);
                }
                else if (unit == Unit.Yard)
                {
                    len = new Length(Val / 36, unit);
                }
            }

            return len;
        }

        public double Val { get; }

        public Unit Unit { get; }
    }
}
