using System;
using System.Collections.Generic;

namespace LengthDemo
{
    public sealed class UnitConverterFactory
    {
        private readonly Dictionary<Unit, IUnitConverter> m_converters = new Dictionary<Unit, IUnitConverter>();

        public UnitConverterFactory()
        {
            m_converters[Unit.Foot] = new FootConverter();
            m_converters[Unit.Yard] = new YardConverter();
            m_converters[Unit.Inch] = new InchConverter();
        }

        public IUnitConverter GetConverter(Unit unit)
        {
            if (!m_converters.TryGetValue(unit, out var converter))
            {
                throw new NotSupportedException();
            }

            return converter;
        }
    }
}