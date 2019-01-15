using System;
using System.Linq;

namespace ClassicTDDStringCalculator
{
    internal class StringCalculator
    {
        public int Add(string inputString)
        {
            char[] seperators = { ',', '\n' };

            if (inputString == "")
                return 0;

            var numbers = inputString.Split(seperators);

            return numbers.Sum(Convert.ToInt32);
        }
    }
}