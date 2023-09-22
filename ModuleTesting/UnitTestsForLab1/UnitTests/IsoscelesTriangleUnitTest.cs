using ModuleTesting;

namespace UnitTestsForLab1.UnitTests
{
    internal class IsoscelesTriangleUnitTest
    {
        [Test]
        public void IsIsoscelesTriang_1()
        {
            Triangle triangle = new Triangle(3, 2, 2);
            Assert.That(triangle.Type, Is.EqualTo(TriangleType.Isosceles), "Triangle isn't Isosceles but has two sides equal to 2.");
        }

        [Test]
        public void IsIsoscelesTriang_2()
        {
            Triangle triangle = new Triangle(4, 5, 4);
            Assert.That(triangle.Type, Is.EqualTo(TriangleType.Isosceles), "Triangle isn't Isosceles but has two sides equal to 4.");
        }

        [Test]
        public void IsIsoscelesTriang_3()
        {
            Triangle triangle = new Triangle(6, 6, 5);
            Assert.That(triangle.Type, Is.EqualTo(TriangleType.Isosceles), "Triangle isn't Isosceles but has two sides equal to 6.");
        }

        [Test]
        public void IsoscelesTriangleWithZeroSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 0), "Triangle was created with sides equal to 0.");
        }
    }
}
