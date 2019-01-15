using System;
using Xunit;

namespace ClassicTDDStringCalculator
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("",0)]
        [InlineData("1",1)]
        [InlineData("1,2",3)]
        public void shouldreturnaddition(string numbers,int expectedValue)
        {
            StringCalculator obj = new StringCalculator();
            int sum = obj.add(numbers);
            Assert.Equal(expectedValue, sum);

        }
    }



}
