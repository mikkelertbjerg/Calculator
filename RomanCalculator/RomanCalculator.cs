using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class RomanCalculator : IRomanCalculator
    {
        private static Dictionary<string, int> RomanNumerals
        {
            get
            {
                return new()
                {
                    { "M", 1000 },
                    { "CM", 900 },
                    { "D", 500 },
                    { "CD", 400 },
                    { "C", 100 },
                    { "XC", 90 },
                    { "L", 50 },
                    { "XL", 40 },
                    { "X", 10 },
                    { "IX", 9 },
                    { "V", 5 },
                    { "IV", 4 },
                    { "I", 1 },
                };
            }
        }

        public string IntToRoman(int i)
        {
            if (i >= 4000)
            {
                throw new NotImplementedException("Numbers 4000 and above are not implemented.");
            }

            if (i == 0)
            {
                throw new ArgumentException("Zero is not represented in roman.");
            }

            if (i < 0)
            {
                throw new ArgumentException("Negative numbers are supported");
            }

            var res = new StringBuilder();

            foreach (var kvp in RomanNumerals)
            {
                while (kvp.Value <= i)
                {
                    i -= kvp.Value;
                    res.Append(kvp.Key);
                }
            }

            return res.ToString();
        }

        public string DecimalToRoman(double value)
        {
            var i = Convert.ToInt32(value);
            return IntToRoman(i);
        }

        public int RomanToInt(string s)
        {
            if (!IsValidRomanNumeral(s))
            {
                throw new ArgumentException($"Invalid numeral: {s}, any numeral may only be repeated three times. V, L and D can never repeat. Only one lesser numeral may appear before a larger.");
            }

            var res = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var current = s[i].ToString();
                RomanNumerals.TryGetValue(current, out int value);
                if (i + 1 < s.Length && RomanNumerals[s[i + 1].ToString()] > RomanNumerals[current])
                {
                    res -= value;
                }
                else
                {
                    res += value;
                }
            }

            return res;
        }

        private static bool IsValidRomanNumeral(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            if (!Regex.Match(s, @"(?<=^)M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})(?=$)").Success)
            {
                return false;
            }

            return true;
        }


    }
}
