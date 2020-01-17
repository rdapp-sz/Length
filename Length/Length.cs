namespace LengthDemo
{
    public class Length
    {
        public Length(double val, string unit)
        {
            Val = val;
            Unit = unit;
        }

        public Length As(string u)
        {
            var len = this;
            if (Unit.Equals("f"))
            {
                if (u.Equals("yard"))
                {
                    len = new Length(Val / 3, u);
                }
                else if (u.Equals("inch"))
                {
                    len = new Length(Val * 12, u);
                }
            }

            if (Unit.Equals("yard"))
            {
                if (u.Equals("inch"))
                {
                    len = new Length(Val * 36, u);
                }
                else if (u.Equals("f"))
                {
                    len = new Length(Val * 3, u);
                }
            }

            if (Unit.Equals("inch"))
            {
                if (u.Equals("f"))
                {
                    len = new Length(Val / 12, u);
                }
                else if (u.Equals("yard"))
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
