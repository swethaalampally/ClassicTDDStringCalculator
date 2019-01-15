using System;
using Xunit;

namespace ClassicTDDStringCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void shouldreturnaddition()
        {
            StringCalculator obj = new StringCalculator();
            int sum = obj.add("");

            Assert.Equal(0, sum);

        }
    }



}
