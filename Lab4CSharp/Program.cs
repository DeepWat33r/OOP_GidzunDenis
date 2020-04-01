using System;

namespace Lab4CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Square K1 = new Square();
            Square K2 = new Square(10, 10, 9);
            Square K3 = new Square(K2);
            Square K4 = K1 + K2;
            Console.WriteLine("x1={0}, y1={1}, A={2}", K4.X1, K4.Y1, K4.a);
            K3 = K3 + 5;
            Console.WriteLine("x1={0}, y1={1}, A={2}", K3.X1, K3.Y1, K3.a);
            K1 = K2 / K3;
            Console.WriteLine("x1={0}, y1={1}, A={2}", K1.X3, K1.Y1, K1.a);
            //Console.WriteLine("X4={0},  Y4={1}", K2.X4, K2.P());
        }
    }
}