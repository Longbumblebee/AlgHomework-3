using System;
using System.Collections.Generic;
using System.Text;

namespace AlgHomework_3
{
    public class PointClassDouble
    {
        public double X;
        public double Y;

        public PointClassDouble(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double PointDistance(PointClassDouble pointOne, PointClassDouble pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((float)((x * x) + (y * y)));
        }

    }
}