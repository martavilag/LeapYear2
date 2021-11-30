using LeapYearReturns;
using Xunit;

namespace LeapYearReturns.Tests
{
    public class LeapYearShould
    {
        
        [Theory]
        [InlineData(2000)]
        [InlineData(2400)]
        [InlineData(2800)]
        public void ReturnTrueForYearsDivisibleByFourHundred(int number)
        {
            Year year = new Year(number);
            Assert.True(year.IsLeap());
        }

        [Theory]
        [InlineData(2012)]
        [InlineData(2036)]
        [InlineData(1996)]
        public void ReturnTrueForYearsDivisibleByFour(int number)
        {
            Year year = new Year(number);
            Assert.True(year.IsLeap());
        }
        
        [Theory]
        [InlineData(1900)]
        [InlineData(2200)]
        [InlineData(2300)]
        public void ReturnFalseForYearsDivisibleByFourAndHundred(int number)
        {
            Year year = new Year(number);
            Assert.False(year.IsLeap());
        }

    }
    
}
