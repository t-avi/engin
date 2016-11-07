using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class QuadEq
    {
        List<double> Result;
        public QuadEq()
        {
            Result = new List<double>();
        }

        public List<double> ResultPlease(double a, double b, double c)
        {
            double x1 = 0;
            double x2 = 0;

            x1 = (-b + Descr(a, b, c)) / 2 * a;
            x2 = (-b - Descr(a, b, c)) / 2 * a;

            Result.Add(x1);
            if (x1 != x2) Result.Add(x2);

            return Result;
        }

        private double Descr(double a, double b, double c) 
        {
            return (Math.Sqrt(b * b - 4 * a * c));
        }
    }
}
