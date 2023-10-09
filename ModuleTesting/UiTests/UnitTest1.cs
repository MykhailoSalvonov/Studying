using FlaUI.Core.AutomationElements;
using NUnit.Framework;
using System.Diagnostics;
using UiTests.Core;
using UiTests.PageObject;

namespace UiTests
{
    public class Tests
    {
        Process _process;

        [SetUp]
        public void Setup()
        {
            string exePath = @"D:\Git\Studying\ModuleTesting\Triangle\bin\Debug\net6.0-windows\TriangleBuilder.exe";
            _process = Process.Start(exePath);
            Thread.Sleep(1000);
        }

        [TearDown] 
        public void Teardown() 
        {
            _process.CloseMainWindow();
        }

        [Test]
        public void TriangleWithSideMuchBiggerThenOtherUI_1()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 2;
            triangleView.SizeB = 3;
            triangleView.SizeC = 5;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo("Sum of any two side should be bigger than third one."));
        }

        [Test]
        public void TriangleWithSideMuchBiggerThenOtherUI_2()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 2;
            triangleView.SizeB = 3;
            triangleView.SizeC = 10;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo("Sum of any two side should be bigger than third one."));
        }

        [Test]
        public void IsEquilateralTriangUI()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 10;
            triangleView.SizeB = 10;
            triangleView.SizeC = 10;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo($"Triangle has been created successful, it has type - Equilateral"));
        }

        [Test]
        public void IsScaleneTriangUI()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA =  4;
            triangleView.SizeB = 5;
            triangleView.SizeC = 6;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo($"Triangle has been created successful, it has type - Scalene"));
        }

        [Test]
        public void EquilateralTriangleWithZeroSides()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 0;
            triangleView.SizeB = 0;
            triangleView.SizeC = 0;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo($"Each side of triangle should be bigger than zero."));
        }

        [Test]
        public void IsIsoscelesTriangUI_1()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 3;
            triangleView.SizeB = 2;
            triangleView.SizeC = 2;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo($"Triangle has been created successful, it has type - Isosceles"));
        }

        [Test]
        public void IsIsoscelesTriangUI_2()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 4;
            triangleView.SizeB = 5;
            triangleView.SizeC = 4;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo($"Triangle has been created successful, it has type - Isosceles"));
        }

        [Test]
        public void IsIsoscelesTriangUI_3()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 6;
            triangleView.SizeB = 6;
            triangleView.SizeC = 5;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo($"Triangle has been created successful, it has type - Isosceles"));
        }

        [Test]
        public void IsoscelesTriangleUIWithZeroSides()
        {
            TriangleMainView triangleView = new TriangleMainView();

            triangleView.SizeA = 0;
            triangleView.SizeB = 1;
            triangleView.SizeC = 0;
            triangleView.Create();

            Assert.That(triangleView.Message, Is.EqualTo($"Each side of triangle should be bigger than zero."));
        }
    }
}