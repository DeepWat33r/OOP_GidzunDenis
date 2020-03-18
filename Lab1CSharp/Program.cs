using System;

namespace Lab1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34, num2 = 34;
            bool result =Compare(num1,num2);
            Decrement(ref num1);
            Console.WriteLine(num1);

        }
        public static bool Compare(int num1,int num2)
        {
            bool flag = false;
            if ((num1 ^ num2) == 0)
                flag = true;
            return flag;
        }
        public static void Decrement(ref int num1)
        {
            int num2 = 1, temp = 0;
            temp = num1 & num2;
            if (temp == 0)
            {

                while (temp == 0)
                {
                    temp = num1 & num2;
                    num1 = num1 ^ num2;
                    num2 = num2 << 1;
                }
            }
            else
            {
                num1 = num1 ^ num2;
            }
        }
    }
}
