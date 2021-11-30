using LeapYearReturns;
using Xunit;

namespace LeapYearReturns.Tests
{
    public class LeapYearShould
    {
        [Fact]
        public void ReturnTrueForTwoThousand()
        {
            Year year = new Year(2000);
            Assert.True(year.IsLeap());
        }
    }
    
}
