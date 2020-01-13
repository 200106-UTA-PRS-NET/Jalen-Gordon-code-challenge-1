using System;
using System.Collections.Generic;

namespace PalindromeTestLib
{
    public class Palindromelib
    {
        public string AnalyzePalin(string str)
        {
            string lowerCase = str.ToLower();
            string trim = lowerCase.Trim();

            // Check for any white space within string
            while(trim.IndexOf(' ') != -1)
            {
                trim = trim.Remove(trim.IndexOf(' '), 1);
            }

            // check for any commas within string
            while(trim.IndexOf(',') != -1)
            {
                trim = trim.Remove(trim.IndexOf(','), 1);
            }

            // check for any periods within string
            while (trim.IndexOf('.') != -1)
            {
                trim = trim.Remove(trim.IndexOf('.'), 1);
            }

            // return trim
            return trim;

        }

        public string Rev(string str)
        {
            char[] j = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                j[i] = str[str.Length - i - 1];
            }

            string b = new string(j);
            return b;
        }

        public bool PalindTest(string str)
        {
            str = AnalyzePalin(str);
            string b = Rev(str);
            return b.Equals(str);
        }

    }
}
