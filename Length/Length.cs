namespace LengthDemo
{
    public class Length
    {
        public const string YARD = "yard";
        public const string INCH = "inch";
        public const string FOOT = "foot";

        public Length(double val, string unit)
        {
            Val = val;
            Unit = unit;
        }

        public Length As(string u)
        {
            var len = this;
            if (Unit.Equals(FOOT))
            {
                if (u.Equals(YARD))
                {
                    len = new Length(Val / 3, u);
                }
                else if (u.Equals(INCH))
                {
                    len = new Length(Val * 12, u);
                }
            }

            if (Unit.Equals(YARD))
            {
                if (u.Equals(INCH))
                {
                    len = new Length(Val * 36, u);
                }
                else if (u.Equals(FOOT))
                {
                    len = new Length(Val * 3, u);
                }
            }

            if (Unit.Equals(INCH))
            {
                if (u.Equals(FOOT))
                {
                    len = new Length(Val / 12, u);
                }
                else if (u.Equals(YARD))
                {
                    len = new Length(Val / 36, u);
                }
            }

            return len;
        }

        public double Val { get; }

        public string Unit { get; }
    }
}
