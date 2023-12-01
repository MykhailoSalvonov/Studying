using ModuleTesting;
using NUnit.Framework;

namespace UnitTestsLab6
{
    public class GeographicCalculatorUnitTests
    {
        int latitude = 47;

        [Test]
        public void ContinuityNearZeroDegree()
        {
            List<double> resultList = new List<double>();

            for (double i = 0.0; i < double.Epsilon*1000; i+= double.Epsilon)
            {
                resultList.Add(GeographicCalculator.MeridianLength(latitude, i));
            }
            List<double> sortedResult = resultList.OrderBy(x=>x).ToList();
            CollectionAssert.AreEqual(sortedResult, resultList);

        }

        [Test]
        public void ContinuityNearOneDegree()
        {
            List<double> resultList = new List<double>();

            for (double i = 0.0; i < double.Epsilon * 1000; i += double.Epsilon)
            {
                resultList.Add(GeographicCalculator.MeridianLength(latitude, 1-i));
            }

            List<double> sortedResult = resultList.OrderBy(x => x).ToList();
            CollectionAssert.AreEqual(sortedResult, resultList);
        }

        [Test]
        public void ContinuityOneDegree()
        {
            double preaviousValue = 0.0;
            double currentValue;

            currentValue = GeographicCalculator.MeridianLength(latitude, 1);
            Assert.Greater(currentValue, preaviousValue);
        }
    }
}
