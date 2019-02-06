using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NumberSystemConverter
{
    public class ArabicNumberConverter
    {
        public int ConvertNumber(string number)
        {
            var ret = 0;
            // var i = 0;
            Dictionary<string, int> numerals = new Dictionary<string, int>();
            numerals.Add("I", 1);
            numerals.Add("V", 5);
            numerals.Add("X", 10);
            numerals.Add("L", 50);
            numerals.Add("C", 100);
            numerals.Add("D", 500);
            numerals.Add("M", 1000);
            
            if (!Regex.IsMatch(number, @"^[IVXLCDM]+$"))
            {
                throw new IndexOutOfRangeException();
            }
            var letter = "";
            var nextLetter = "";
            for (int i = 0; i < number.Length; i++)
            {
                letter = "";
                letter += number[i];
                if (i + 1 < number.Length)
                {
                    nextLetter = "";
                    nextLetter += number[i + 1];
                }

                if (nextLetter.Length > 0 && numerals[letter] < numerals[nextLetter])
                {
                    ret = ret + (numerals[nextLetter] - numerals[letter]);
                    i++;
                }
                else
                    ret += numerals[letter];
            }
            return ret;

            throw new NotImplementedException();
        }
    }
}