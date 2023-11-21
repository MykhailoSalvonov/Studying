using ModuleTesting;
using NUnit.Framework;

namespace UnitTestsLab2
{
    public class GeographicCalculatorUnitTests
    {
        [Test]
        public void Test1()
        {
            List<double> results = new List<double>();
            var latitude = 47;
            for (double i = 0; i < 0.001; i+= double.Epsilon)
            {
                results.Add(GeographicCalculator.MeridianLength(latitude, i));
            }

            List<double> sortedResult = results.OrderBy(x=>x).ToList();
            CollectionAssert.AreEqual(sortedResult, results);

        }
    }
}
