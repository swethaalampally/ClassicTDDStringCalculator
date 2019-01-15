using System;

namespace ClassicTDDStringCalculator
{
    internal class StringCalculator
    {
        public StringCalculator()
        {
        }

        public int add(string number)
        {

            return number==""?0:Convert.ToInt32(number);
        }
    }
}