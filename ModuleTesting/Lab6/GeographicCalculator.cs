using System;

namespace Lab6
{
    public class GeographicCalculator
    {
        public const double a = 6378137;/// мгс wgs84
        public const double pCompression = 1.0 / 298.257223563;
        ///<Константа типу double -- полярне стискання (GRS-80)
        public const double b = a * (1.0 - pCompression);
        public const double sa = a * a;
        public const double sb = b * b;
        public const double seccentricity = (sa - sb) / sa;
        public const double seccentricity2 = (sa - sb) / sb;
        
        
        /// підрахунок довжини в км. до одного градусу на меридіані
        public static double MeridianLength(double lattitude, double d = 1.0)
        {
            if (d > 1) 
                d = 1.0;
            else if (d <= 0.0) 
                return 0.0;

            if (lattitude > 90.0) 
                lattitude = 90.0;
            else if (lattitude < 0.0) 
                lattitude = 0.0;

            double lttM = lattitude + ((double)d) / 2.0;
            double sinB = sin(lttM);
            double foo = Math.Sqrt(1 - seccentricity * sinB * sinB);
            double M = a * (1 - seccentricity)
                / (foo * foo * foo);
            double rc = M * (Math.PI / 180.0); // length of 1 degree
            return rc * d; // this is part of degree
        }

        static public double sin(double degree)
        {
            return Math.Sin(degree * (Math.PI / 180.0));
        }
    }
}
