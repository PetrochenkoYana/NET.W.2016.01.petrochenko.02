﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class ConcatStringAlphabet
    {
        public static string Longest(string a, string b)
        {
            string commonStr = a + b;
            string resultStr = "";
            char[] charCommonStr = commonStr.ToCharArray();
            char[] arrayAlphabet = new char[26];

            for (int i = 0; i < charCommonStr.Length; i++)
            {
                if (arrayAlphabet[(int)charCommonStr[i] - 97] == 0)
                    arrayAlphabet[(int)charCommonStr[i] - 97] = charCommonStr[i];
            }
            for (int i = 0; i < arrayAlphabet.Length; i++)
            {
                if (arrayAlphabet[i] != 0)
                    resultStr += Convert.ToString(arrayAlphabet[i]);

            }
            return resultStr;
        }
    }
}
