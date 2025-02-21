using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace EquilateralUnitTest
{
    [TestFixture]
    public class Isosceles
    {
        [Test]
        public void IsIsoscelesAandB()
        {
            int firstSide = 5, secondSide = 5, thirdSide = 4;
            String expected = "Isosceles triangle";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void IsIsoscelesBandC()
        {
            int firstSide = 4, secondSide = 5, thirdSide = 5;
            String expected = "Isosceles triangle";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void IsIsoscelesAandC()
        {
            int firstSide = 5, secondSide = 4, thirdSide = 5;
            String expected = "Isosceles triangle";
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual(actual, expected);

        }

    }
}
