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

            string[] numbers = number.Split(',');
            int sum=0;

            foreach (string i in numbers)
            {
                sum += Convert.ToInt32(i);
            }

            return sum;
        }
    }
}