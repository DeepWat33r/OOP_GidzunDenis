using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate[] arr = new Calculate[3];
            arr[0] = new Calculate(0.5, 2, 5.7);
            arr[1] = new Calculate(4, -1, 5.7);
            arr[2] = new Calculate(10, 4, 5.7);
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    double r = arr[i].Result();
                    Console.WriteLine(r);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}


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
};