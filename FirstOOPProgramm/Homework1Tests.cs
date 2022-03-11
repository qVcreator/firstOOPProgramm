using NUnit.Framework;
using System;
using FirstOOPProgramm;

namespace FirstOOPProgramm.Test
{
    public class Homework1Tests
    {
        [TestCase()]
        public void GetSolutionTest(double a, double b, double expected)
        {
            double actual = FirstOOPProgramm.Homework1.GetSolution(a, b);
        }
    }
}