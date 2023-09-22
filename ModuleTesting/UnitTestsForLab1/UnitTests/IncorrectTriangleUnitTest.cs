using ModuleTesting;

namespace UnitTestsForLab1.UnitTests
{
    internal class IncorrectTriangleUnitTest
    {
        [Test]
        public void TriangleWithZeroSide()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 2, 3), "Triangle was created with side equals to 0.");
        }

        [Test]
        public void TriangleWithSideMuchBiggerThenOther() 
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5), "Triangle was created with one side much bigger than two others.");
        }

        [Test]
        public void TriangleWithNegativeSide()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 2), "Triangle was created with one side with negative value.");
        }
    }
}
