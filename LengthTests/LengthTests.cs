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
            var result = new Length(1, Length.INCH).As(Length.INCH);

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, (Length.INCH));
        }

        [TestMethod]
        public void Should_2_Feet_Equals_2_Feet()
        {
            var result = new Length(2, Length.FOOT).As(Length.FOOT);

            Assert.AreEqual(result.Val, (2.0));
            Assert.AreEqual(result.Unit, (Length.FOOT));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_1_Yard()
        {
            var result = new Length(1, Length.YARD).As(Length.YARD);

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, (Length.YARD));
        }

        [TestMethod]
        public void Should_1_Foot_Equals_12_Inches()
        {
            var result = new Length(1, Length.FOOT).As(Length.INCH);

            Assert.AreEqual(result.Val, (12.0));
            Assert.AreEqual(result.Unit, (Length.INCH));
        }

        [TestMethod]
        public void Should_3_Foot_Equals_1_Yard()
        {
            var result = new Length(3, Length.FOOT).As(Length.YARD);

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, (Length.YARD));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_3_Feet()
        {
            var result = new Length(1, Length.YARD).As(Length.FOOT);

            Assert.AreEqual(result.Val, (3.0));
            Assert.AreEqual(result.Unit, (Length.FOOT));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_36_Inches()
        {
            var result = new Length(1, Length.YARD).As(Length.INCH);

            Assert.AreEqual(result.Val, (36.0));
            Assert.AreEqual(result.Unit, Length.INCH);
        }

        [TestMethod]
        public void Should_2_yards_Equals_72_Inches()
        {
            var result = new Length(2, Length.YARD).As(Length.INCH);

            Assert.AreEqual(result.Val, (72.0));
            Assert.AreEqual(result.Unit, Length.INCH);
        }

        [TestMethod]
        public void Should_12_Inches_Equals_1_Foot()
        {
            var result = new Length(12, Length.INCH).As(Length.FOOT);

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, Length.FOOT);
        }

        [TestMethod]
        public void Should_36_Inches_Equals_1_Yard()
        {
            var result = new Length(36, Length.INCH).As(Length.YARD);

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, Length.YARD);
        }

        [TestMethod]
        public void Should_18_Inches_Equals_Half_Yard()
        {
            var result = new Length(18, Length.INCH).As(Length.YARD);

            Assert.AreEqual(result.Val, (0.5));
            Assert.AreEqual(result.Unit, Length.YARD);
        }
    }
}
