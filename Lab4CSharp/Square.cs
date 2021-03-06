﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4CSharp
{
    class Square
    {
        double x1, y1;
        double A;
        public Square()
        {
            x1 = y1 = 0;
            A = 1;
        }
        public Square(double x1, double y1, double A)
        {
            this.x1 = x1; this.y1 = y1;
            this.A = A;
            if (A <= 0) throw new ArgumentException();
        }
        public Square(Square s)
        {
            this.x1 = s.x1; this.y1 = s.y1;
            this.A = s.A;           
        }
        public double S { get { return A * A; } }
        public double P { get { return 4*A; } }
        public double X1 { get { return x1; } }
        public double Y1 { get { return y1; } }
        public double X2 { get { return x1; } }
        public double Y2 { get { return y1 + A; } }
        public double X3 { get { return x1 + A; } }
        public double Y3 { get { return y1 + A; } }
        public double X4 { get { return x1 + A; } }
        public double Y4 { get { return y1; } }
        public double a { get { return A; } }

        public static Square operator +(Square s1, Square s2)
        {
            Square s3 = new Square(s1.x1, s1.y1, s1.A + s2.A);
            return s3;
        }
        public static Square operator +(Square s1, double A)
        {
            Square s3 = new Square(s1.x1, s1.y1, s1.A + A);
            return s3;
        }
        public static Square operator +(double A,Square s1)
        {
            Square s3 = new Square(s1.x1, s1.y1, s1.A + A);
            return s3;
        }
        public static Square operator /(Square s1, Square s2)
        {
            Square s3 = new Square(s1.x1, s1.y1, s1.A / s2.A);
            return s3;
        }

    }
}
