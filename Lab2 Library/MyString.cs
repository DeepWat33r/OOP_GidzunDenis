using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    public class MyString
    {
        private char[] s;
        public MyString(string s2)
        {
            s = s2.ToCharArray();
        }
        public int Length()
        {
            return s.Length;
        }
        public bool Compare(string s2)
        {
            for (int i = 0; i < s.Length - s2.Length; i++)
            {
                int j = 0;
                for (; j < s2.Length; j++)
                {
                    if (s[j + i] != s2[j]) break;
                }
                if (j == s2.Length) return true;
            }
            return false;
        }
        public void ToUpper()
        {
            if (s.Length > 0 ) s[0] = char.ToUpper(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == ' ' ) s[i] = char.ToUpper(s[i]);
            }
        }
        public string GetString()
        {
            string s2 = new string(s);
            return s2;
        }

    }
}
