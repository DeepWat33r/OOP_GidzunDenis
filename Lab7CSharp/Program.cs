using System;
using System.Threading.Tasks.Dataflow;

namespace Lab7CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList Mylist = new MyList();
            Mylist.Add(78);
            Mylist.Add(5);
            Mylist.Add(11);
            Mylist.Add(6);
            Mylist.AppendLast(23);
            Mylist.AppendLast(27);
            Mylist.AppendLast(2);
            Mylist.AppendLast(1.4f);
            foreach (float item in Mylist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Numbers that > 10.5: {0}", Mylist.CountMoreThan(10.5f));
            foreach (float item in Mylist)
            {
                if (item < 2.6f) Mylist.Remove(item);
            }
            foreach (float item in Mylist)
            {
                Console.WriteLine(item);
            }
            Mylist.Clear();            
        }
    }
}
