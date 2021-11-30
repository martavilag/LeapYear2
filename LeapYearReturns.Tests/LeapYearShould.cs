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

        [Fact]
        public void ReturnFalseForYearOneThousandNineHundred()
        {
            Year year = new Year(1900);
            Assert.False(year.IsLeap());
        }
        
        [Fact]
        public void ReturnFalseForYearTwoThousandTwoHundred()
        {
            Year year = new Year(2200);
            Assert.False(year.IsLeap());
        }
        
    }
    
}
