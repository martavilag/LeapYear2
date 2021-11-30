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

        [Fact]
        public void ReturnTrueForTwoThousandTwelve()
        {
            Year year = new Year(2012);
            Assert.True(year.IsLeap());
        }
        
        [Fact]
        public void ReturnTrueForTwoThousandThirtySix()
        {
            Year year = new Year(2036);
            Assert.True(year.IsLeap());
        }

        
    }
    
}
