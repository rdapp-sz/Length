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
            var result = new Length(1, "inch").As("inch");

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, ("inch"));
        }

        [TestMethod]
        public void Should_2_Feet_Equals_2_Feet()
        {
            var result = new Length(2, "f").As("f");

            Assert.AreEqual(result.Val, (2.0));
            Assert.AreEqual(result.Unit, ("f"));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_1_Yard()
        {
            var result = new Length(1, "yard").As("yard");

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, ("yard"));
        }

        [TestMethod]
        public void Should_1_Foot_Equals_12_Inches()
        {
            var result = new Length(1, "f").As("inch");

            Assert.AreEqual(result.Val, (12.0));
            Assert.AreEqual(result.Unit, ("inch"));
        }

        [TestMethod]
        public void Should_3_Foot_Equals_1_Yard()
        {
            var result = new Length(3, "f").As("yard");

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, ("yard"));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_3_Feet()
        {
            var result = new Length(1, "yard").As("f");

            Assert.AreEqual(result.Val, (3.0));
            Assert.AreEqual(result.Unit, ("f"));
        }

        [TestMethod]
        public void Should_1_Yard_Equals_36_Inches()
        {
            var result = new Length(1, "yard").As("inch");

            Assert.AreEqual(result.Val, (36.0));
            Assert.AreEqual(result.Unit, ("inch"));
        }

        [TestMethod]
        public void Should_2_yards_Equals_72_Inches()
        {
            var result = new Length(2, "yard").As("inch");

            Assert.AreEqual(result.Val, (72.0));
            Assert.AreEqual(result.Unit, ("inch"));
        }

        [TestMethod]
        public void Should_12_Inches_Equals_1_Foot()
        {
            var result = new Length(12, "inch").As("f");

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, ("f"));
        }

        [TestMethod]
        public void Should_36_Inches_Equals_1_Yard()
        {
            var result = new Length(36, "inch").As("yard");

            Assert.AreEqual(result.Val, (1.0));
            Assert.AreEqual(result.Unit, ("yard"));
        }

        [TestMethod]
        public void Should_18_Inches_Equals_Half_Yard()
        {
            var result = new Length(18, "inch").As("yard");

            Assert.AreEqual(result.Val, (0.5));
            Assert.AreEqual(result.Unit, ("yard"));
        }
    }
}
