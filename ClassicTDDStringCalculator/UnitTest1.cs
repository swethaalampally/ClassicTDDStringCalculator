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
            int sum = _stringCalculator.Add(numbers);

            Assert.Equal(expectedValue, sum);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        public void ReturnNumberIfNumberStringPassed(string numbers, int expectedValue)
        {
            int sum = _stringCalculator.Add(numbers);

            Assert.Equal(expectedValue, sum);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("4,5", 9)]
        [InlineData("5,6", 11)]
        public void SumIfTwoNumbersPassed(string numbers, int expectedValue)
        {
            int sum = _stringCalculator.Add(numbers);

            Assert.Equal(expectedValue, sum);
        }

        [Theory]
        [InlineData("1,2,3,4,5", 15)]
        [InlineData("1,1,1,1,1", 5)]
        [InlineData("1,1,1,1,2", 6)]
        public void SumIfMultipleNumbersPassed(string numbers, int expectedValue)
        {
            int sum = _stringCalculator.Add(numbers);

            Assert.Equal(expectedValue, sum);
        }


        [Theory]
        [InlineData(@"1\n2,3", 6)]
        [InlineData(@"1\n2,3\n1", 7)]
        [InlineData(@"1\n2,3\n1,1,1", 9)]
        public void SumIfMultipleNumbersPassedWithNewLine(string numbers, int expectedValue)
        {

            int sum = _stringCalculator.Add(numbers);

            Assert.Equal(expectedValue, sum);
        }

    }

}
