using System;

namespace ModuleTesting
{
    public class Triangle
    {
        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Each side of triangle should be bigger than zero.");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Sum of any two side should be bigger than third one.");

            A = a; B = b; C = c;

            if (A == B && A == C && B == C)
                Type = TriangleType.Equilateral;
            else if (A == C || B == C || A == B)
                Type = TriangleType.Isosceles;
            else
                Type = TriangleType.Scalene;
        }

        public int A { get; }
        public int B { get; }
        public int C { get; }

        public TriangleType Type {  get; }
    }

    public enum TriangleType
    {
        Scalene,
        Isosceles,
        Equilateral
    }
}
