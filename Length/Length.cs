using System;

namespace LengthDemo
{
    public class Length
    {
        private readonly Func<Unit, double> m_convertFunc;

        public Length(double val, Unit unit)
        {
            Val = val;
            Unit = unit;

            switch (unit)
            {
                case Unit.Foot:
                    m_convertFunc = FromFootTo;
                    break;
                case Unit.Inch:
                    m_convertFunc = FromInchTo;
                    break;
                case Unit.Yard:
                    m_convertFunc = FromYardTo;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        public Length As(Unit unit)
        {
            return new Length(m_convertFunc(unit), unit);
        }

        private double FromFootTo(Unit unit)
        {
            if (unit == Unit.Yard)
            {
                return Val / 3;
            }

            if (unit == Unit.Inch)
            {
                return Val * 12;
            }

            if (unit == Unit.Foot)
            {
                return Val;
            }

            throw new NotSupportedException();
        }

        private double FromYardTo(Unit unit)
        {
            if (unit == Unit.Inch)
            {
                return Val * 36;
            }

            if (unit == Unit.Foot)
            {
                return Val * 3;
            }

            if (unit == Unit.Yard)
            {
                return Val;
            }

            throw new NotSupportedException();
        }

        private double FromInchTo(Unit unit)
        {
            if (unit == Unit.Foot)
            {
                return Val / 12;
            }

            if (unit == Unit.Yard)
            {
                return Val / 36;
            }

            if (unit == Unit.Inch)
            {
                return Val;
            }

            throw new NotSupportedException();
        }

        public double Val { get; }

        public Unit Unit { get; }
    }
}
