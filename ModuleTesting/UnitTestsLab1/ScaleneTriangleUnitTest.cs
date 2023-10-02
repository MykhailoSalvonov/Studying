using ModuleTesting;
using NUnit.Framework;

namespace UnitTestsLab1.UnitTests
{
    public class Tests
    {
        [Test]
        public void IsScaleneTriang()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.Type, Is.EqualTo(TriangleType.Scalene), "Triangle isn't Scalene but has correct size of each side and all of them are different.");
        }
    }
}