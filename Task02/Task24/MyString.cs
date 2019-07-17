using System;
using System.Collections.Generic;
using System.Text;

namespace Task24
{
    public class MyString
    {
        private string str;
        public string StringProperty
        {
            get { return str; }
            set { str = value; }
        }

        public MyString(string str1)
        {
            this.str = str1;
        }

        public int IndexOf(char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                    return i;
            }
            return -1;
        }
        public bool Contains(char ch) => (IndexOf(ch)) >= 0;

        public bool StartsWith(char ch) => str[0] == ch;

        public string Concat(string a) => str + a;

        public static bool Equals(string a, string b)
        {
            if ((object)a == (object)b)
            {
                return true;
            }

            return false;
        }

        public string ToCharArray()
        {
            int length = str.Length;
            char[] newChar = new char[length];
            for (int i = 0; i < length; i++)
            {
                newChar[i] += str[i];
            }
            string newStr = "[";
            for (int i = 0; i < newChar.Length; i++)
            {
                newStr += str[i] + ", ";
            }
            newStr = newStr.Remove(newStr.Length - 2, 2);
            newStr += "]";
            return newStr;
        }

        public string Remove(int index)
        {
            index = index > str.Length ? str.Length : index;
            char[] newChar = new char[index];

            for (int i = 0; i < index; i++)
            {
                newChar[i] = str[i];
            }
            string newStr = new string(newChar);
            return newStr;
        }
    }
}
