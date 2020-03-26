using System;
using System.Text;
using System.Collections.Generic;
using Lab2_Library;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyText text = new MyText();
            text.AddText("123456789");
            text.AddText("123dfghedjh456789");
            text.Clear();
            text.AddText("dsaad gedgher asd");
            text.AddText("12345");
            text.AddText("dsaad gedgher asdq  w qeqweq");
            text.AddText("ds324d  asd");
            text.AddText("sfeuwy weqpd fqqpew");
            Console.WriteLine("Max={0}", text.GetMaxLenght());
            text.Remove(1);
            text.RemoveAll("dsa");
            text.ToUpperText();
            for (int i = 0; i < text.Text.Count; i++)
            {
                Console.WriteLine(text.Text[i].GetString());
            }


        }
    }

}
