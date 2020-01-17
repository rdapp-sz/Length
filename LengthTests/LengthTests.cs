using LengthDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LengthTests
{
    [TestClass]
    public class LengthTests
    {
        [TestMethod]
        public void Should_1_Inch_Equals_1_Inch()
        {
            var result = new Length(1, Unit.Inch).As(Unit.Inch);

            Assert.AreEqual(1.0, result.Val);
            Assert.AreEqual(Unit.Inch, result.Unit);
        }

        [TestMethod]
        public void Should_2_Feet_Equals_2_Feet()
        {
            var result = new Length(2, Unit.Foot).As(Unit.Foot);

            Assert.AreEqual(2.0, result.Val);
            Assert.AreEqual(Unit.Foot, result.Unit);
        }

        [TestMethod]
        public void Should_1_Yard_Equals_1_Yard()
        {
            var result = new Length(1, Unit.Yard).As(Unit.Yard);

            Assert.AreEqual(1.0, result.Val);
            Assert.AreEqual(Unit.Yard,result.Unit);
        }

        [TestMethod]
        public void Should_1_Foot_Equals_12_Inches()
        {
            var result = new Length(1, Unit.Foot).As(Unit.Inch);

            Assert.AreEqual(12.0, result.Val);
            Assert.AreEqual(Unit.Inch, result.Unit);
        }

        [TestMethod]
        public void Should_3_Foot_Equals_1_Yard()
        {
            var result = new Length(3, Unit.Foot).As(Unit.Yard);

            Assert.AreEqual(1.0, result.Val);
            Assert.AreEqual(Unit.Yard, result.Unit);
        }

        [TestMethod]
        public void Should_1_Yard_Equals_3_Feet()
        {
            var result = new Length(1, Unit.Yard).As(Unit.Foot);

            Assert.AreEqual(3.0, result.Val);
            Assert.AreEqual(Unit.Foot, result.Unit);
        }

        [TestMethod]
        public void Should_1_Yard_Equals_36_Inches()
        {
            var result = new Length(1, Unit.Yard).As(Unit.Inch);

            Assert.AreEqual(36.0, result.Val);
            Assert.AreEqual(Unit.Inch, result.Unit);
        }

        [TestMethod]
        public void Should_2_yards_Equals_72_Inches()
        {
            var result = new Length(2, Unit.Yard).As(Unit.Inch);

            Assert.AreEqual(72.0, result.Val);
            Assert.AreEqual(Unit.Inch, result.Unit);
        }

        [TestMethod]
        public void Should_12_Inches_Equals_1_Foot()
        {
            var result = new Length(12, Unit.Inch).As(Unit.Foot);

            Assert.AreEqual(1.0, result.Val);
            Assert.AreEqual(Unit.Foot, result.Unit);
        }

        [TestMethod]
        public void Should_36_Inches_Equals_1_Yard()
        {
            var result = new Length(36, Unit.Inch).As(Unit.Yard);

            Assert.AreEqual(1.0, result.Val);
            Assert.AreEqual(Unit.Yard, result.Unit);
        }

        [TestMethod]
        public void Should_18_Inches_Equals_Half_Yard()
        {
            var result = new Length(18, Unit.Inch).As(Unit.Yard);

            Assert.AreEqual(0.5, result.Val);
            Assert.AreEqual(Unit.Yard, result.Unit);
        }
    }
}
