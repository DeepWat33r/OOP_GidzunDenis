using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Calculate
    {
        private double a, c, d;
        public Calculate() { }
        public Calculate(double a, double c, double d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }
        public double Result()
        {
            if (a / 4 + c == 0) throw new DivideByZeroException("Divide by Zero");
            if (2 * c - a <= 0) throw new ArgumentException("ArgumentException");
            double r;
            r = (Math.Log10(2 * c - a) + d - 152) / (a / 4 + c);
            return r;
        }
        public void SetA(double a)
        {
            this.a = a;
        }
        public void SetC(double c)
        {
            this.c = c;
        }
        public void SetD(double d)
        {
            this.d = d;
        }
    }
}
