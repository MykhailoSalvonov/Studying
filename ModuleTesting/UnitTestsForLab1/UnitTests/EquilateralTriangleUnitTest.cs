using ModuleTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsForLab1.UnitTests
{
    internal class EquilateralTriangleUnitTest
    {
        [Test]
        public void IsEquilateralTriang()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.That(triangle.Type, Is.EqualTo(TriangleType.Equilateral), "Triangle isn't Equilateral but has sides each one equals to 1.");
        }

        [Test]
        public void EquilateralTriangleWithZeroSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0), "Triangle was created with sides equal to 0.");
        }
    }
}
