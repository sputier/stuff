using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToRoman
{
    public class DecimalToRomanConverter
    {
        private static readonly (string RomanValue, int DecimalValue)[] _baseNumbers = {
            ("M", 1000),
            ("CM", 900),
            ("D", 500),
            ("CD", 400),
            ("C", 100),
            ("XC", 90),
            ("L", 50),
            ("XL", 40),
            ("X", 10),
            ("IX", 9),
            ("V", 5),
            ("IV", 4),
            ("I", 1),
        };

        public string Convert(int input)
        {
            string result = string.Empty;

            for (var i = 0; i < _baseNumbers.Length; i++)
            {
                var baseNumber = _baseNumbers[i];
                var count = 0;
                while (input >= baseNumber.DecimalValue)
                {
                    result += baseNumber.RomanValue;
                    input -= baseNumber.DecimalValue;
                    count++;
                }

            }

            return result;
        }
    }
}
