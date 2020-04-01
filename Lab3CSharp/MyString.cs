using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3CSharp
{
    public class MyString
    {
        private char[] s;
        private int count = 0;
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
                char[] s2 = { 'a', 'e', 'i', 'u', 'o', 'y', 'A', 'E', 'I', 'U', 'O', 'Y' };

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
