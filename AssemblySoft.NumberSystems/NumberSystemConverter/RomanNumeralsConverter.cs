using System;

namespace NumberSystemConverter
{
    public class RomanNumeralsConverter
    {
        private string _calculateUnits(int num, string a, string b, string c)
        {
            var ret = "";
            if (num == 9)
            {
                ret += c;
                num -= 9;
            }
            else if (num == 4)
            {
                ret = ret + a + b;
                num -= 4;
            }
            else if (num >= 5 && num < 9)
            {
                ret += b;
                num -= 5;
            }
            while (num > 0)
            {
                ret += a;
                num--;
            }
            return ret;
        }

        public string ConvertNumber(int number)
        {
            var ret = "";
            var temp = number;
            var i = 0;
            if (number > 3000 || number < 1)
            {
                throw new IndexOutOfRangeException();
            }
            while (temp > 0)
            {
                if (temp / 1000 > 0)
                {
                    // Thousands
                   ret += _calculateUnits(temp / 1000, "M", "M", "M");
                   temp = temp % 1000;
                }
                else if (temp / 100 > 0)
                {
                    ret += _calculateUnits(temp / 100, "C", "D", "CM");
                   temp = temp % 100;
                }
                else if (temp / 10 > 0)
                {
                   ret += _calculateUnits(temp / 10, "X", "L", "XC");
                   temp = temp % 10;
                }
                else if (temp > 0 && temp < 10)
                {
                    ret += _calculateUnits(temp, "I", "V", "IX");
                    temp -= temp;
                }
            }
            return ret;

            throw new NotImplementedException();
        }
    }
}