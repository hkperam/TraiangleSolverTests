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
    public class Test1
    {
        [Test]
        public void IsEquilateral()
        {
            int firstSide=5, secondSide=5, thirdSide=5;
            String expected= "Equilateral triangle"; 
            string actual=Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            Assert.AreEqual(actual,expected);

        }
    }
}
