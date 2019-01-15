using Xunit;

namespace ClassicTDDStringCalculator
{
    public class StringCalculatorShould
    {
        private StringCalculator _stringCalculator;

        public StringCalculatorShould()
        {
            _stringCalculator = new StringCalculator();
        }

        [Theory]
        [InlineData("",0)]
        public void ReturnZeroIfEmptyStringPassed(string numbers,int expectedValue)
        {
            int sum = _stringCalculator.add(numbers);

            Assert.Equal(expectedValue, sum);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        public void ReturnNumberIfNumberStringPassed(string numbers, int expectedValue)
        {
            int sum = _stringCalculator.add(numbers);

            Assert.Equal(expectedValue, sum);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("4,5", 9)]
        [InlineData("5,6", 11)]
        public void SumIfTwoNumbersPassed(string numbers, int expectedValue)
        {
            int sum = _stringCalculator.add(numbers);

            Assert.Equal(expectedValue, sum);
        }

        [Theory]
        [InlineData("1,2,3,4,5", 15)]
        public void SumIfMultipleNumbersPassed(string numbers, int expectedValue)
        {
            int sum = _stringCalculator.add(numbers);

            Assert.Equal(expectedValue, sum);
        }

    }

}
