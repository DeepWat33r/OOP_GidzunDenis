using System;

namespace Lab3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString s = new MyString("dsfo ewafwhee");
            Console.WriteLine(s[2]);
            Console.WriteLine(s.GetLetter);
        }
    }
}
