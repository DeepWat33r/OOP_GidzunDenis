using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3CSharp
{
    public class MyString
    {
        private char[] s;
        public MyString(string s2)
        {
            s = s2.ToCharArray();
        }
        public char this[int index]
        {
            get
            {
                if (index >= 0 && index < s.Length) return char.ToUpper(s[index]);
                return '-';
            }
        }
        public int GetLetter
        {
            get
            {
                char[] s2 = { 'a', 'e', 'i', 'u', 'o', 'y' };

                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < s2.Length; j++)
                        if (s[i] == s2[j]) { count++; break; }
                }
                return count;
            }
        }
    }
}
