using System;

namespace ClassicTDDStringCalculator
{
    internal class StringCalculator
    {
        public int add(string number)
        {
            if (number == "")
                return 0;

            if (!number.Contains(','))
            {
                return Convert.ToInt32(number);
            }

            string firstNumber = number.Split(',')[0];
            string secondNumber = number.Split(',')[1];

            return Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber);

        }
    }
}