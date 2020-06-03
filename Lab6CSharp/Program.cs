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
                Console.WriteLine("fdfdg");
            }
        }
    }
}