using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    public class MyText
    {
        public List<MyString> Text = new List<MyString>();
        public void AddText(string s)
        {
            MyString s2 = new MyString(s);
            Text.Add(s2);
        }
        public void Remove(int index)
        {
            Text.RemoveAt(index);
        }
        public void Clear()
        {
            Text.Clear();
        }
        public void RemoveAll(string s)
        {
            for (int i = Text.Count - 1; i >= 0; i--)
            {
                if (Text[i].Compare(s)) Text.RemoveAt(i);
            }
        }
        public int GetMaxLenght()
        {
            int max = 0;
            for (int i = 0; i < Text.Count; i++)
            {
                if (Text[i].Length() > max) max = Text[i].Length();
            }

            return max;
        }
        public void ToUpperText()
        {
            for (int i = 0; i < Text.Count; i++)
            {
                Text[i].ToUpper();
            }
        }
    }
}
