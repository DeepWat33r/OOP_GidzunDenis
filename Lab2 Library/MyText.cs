using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    public class MyText
    {
        private MyString[] Text = new MyString[1000];
        private int size = 0;

        public void AddText(string s)
        {
            MyString s2 = new MyString(s);
            Text[size] = s2;
            size++;
        }
        public void Remove(int index)
        {
            for (int i = index + 1; i < size; i++)
            {
                Text[i - 1] = Text[i];
            }
            size--;
        }
        public void Clear()
        {
            size = 0;
        }
        public void RemoveAll(string s)
        {
            for (int i = size - 1; i >= 0; i--)
            {
                if (Text[i].Compare(s)) Remove(i);
            }
        }
        public int GetMaxLenght()
        {
            int max = 0;
            for (int i = 0; i < size; i++)
            {
                if (Text[i].Length() > max) max = Text[i].Length();
            }

            return max;
        }
        public void ToUpperText()
        {
            for (int i = 0; i < size; i++)
            {
                Text[i].ToUpper();
            }
        }
        public int Count()
        {
            return size;
        }
    }
}
