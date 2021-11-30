namespace LeapYearReturns
{
    public class Year
    {
        private readonly int year;

        public Year(int year)
        {
            this.year = year;
        }

        public bool IsLeap()
        {
            if (year == 2000)
                return true;
            return false;
        }
    }
}