using System;
using System.Linq;

namespace ClassicTDDStringCalculator
{
    internal class StringCalculator
    {
        public int Add(string inputString)
        {
            if (inputString == "")
                return 0;

            if (!inputString.Contains(','))
            {
                return Convert.ToInt32(inputString);
            }

            var numbers = inputString.Split(',');

            return numbers.Sum(Convert.ToInt32);
        }
    }
}