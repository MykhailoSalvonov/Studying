using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    public class GeographicCalculatorUnitTests
    {
        int latitude = 47;

        [Test]
        public void MathOperationTest()
        {
            int x = 37;
            double xCube = Math.Pow(x, 3);
            double sqrtXCube = Math.Sqrt(xCube);
            double cubeSqrtX = Math.Sqrt(x) * Math.Sqrt(x) * Math.Sqrt(x);
            Assert.That(sqrtXCube, Is.EqualTo(cubeSqrtX).Within(sqrtXCube * 10E-16));
        }

        [Test]
        public void ContinuityNearZeroDegree()
        {
            List<double> resultList = new List<double>();

            for (int i = 0; i < 1000; i++)
            {
                resultList.Add(GeographicCalculator.MeridianLength(latitude, i * double.Epsilon));
            }
            List<double> sortedResult = resultList.OrderBy(x => x).ToList();
            CollectionAssert.AreEqual(sortedResult, resultList);
        }

        [Test]
        public void ContinuityNearOneDegree()
        {
            List<double> resultList = new List<double>();
            var data = GetPreviousDoubles(1, 1000);
            foreach (double i in data)
            {
                resultList.Add(GeographicCalculator.MeridianLength(latitude, i));
            }

            List<double> sortedResult = resultList.OrderBy(x => x).ToList();
            CollectionAssert.AreEqual(sortedResult, resultList);
        }

        [Test]
        public void ContinuityNearOneHalfDegree()
        {
            List<double> resultList = new List<double>();
            var data1 = GetPreviousDoubles(0.5, 500);
            var data2 = GetNextDoubles(0.5, 500);
            var data = new List<double>();
            data.AddRange(data1);
            data.AddRange(data2);

            foreach (double i in data)
            {
                resultList.Add(GeographicCalculator.MeridianLength(latitude, i));
            }

            List<double> sortedResult = resultList.OrderBy(x => x).ToList();
            CollectionAssert.AreEqual(sortedResult, resultList);
        }

        [Test]
        public void ContinuityNearOneFifthDegree()
        {
            List<double> resultList = new List<double>();
            var data1 = GetPreviousDoubles(0.2, 500);
            var data2 = GetNextDoubles(0.2, 500);
            var data = new List<double>();
            data.AddRange(data1);
            data.AddRange(data2);

            foreach (double i in data)
            {
                resultList.Add(GeographicCalculator.MeridianLength(latitude, i));
            }

            List<double> sortedResult = resultList.OrderBy(x => x).ToList();
            CollectionAssert.AreEqual(sortedResult, resultList);
        }

        private List<double> GetPreviousDoubles(double value, int amount)
        {
            List<double> resultList = new List<double>();
            for (double i = 0; i < amount; i++)
            {
                long bits = BitConverter.DoubleToInt64Bits(value);
                value = BitConverter.Int64BitsToDouble(bits - 1);

                resultList.Add(value);
            }
            resultList = resultList.OrderBy(x => x).ToList();
            return resultList;
        }

        private List<double> GetNextDoubles(double value, int amount)
        {
            List<double> resultList = new List<double>();
            for (double i = 0; i < amount; i++)
            {
                long bits = BitConverter.DoubleToInt64Bits(value);
                value = BitConverter.Int64BitsToDouble(bits + 1);

                resultList.Add(value);
            }
            resultList = resultList.OrderBy(x => x).ToList();
            return resultList;
        }
    }
}
