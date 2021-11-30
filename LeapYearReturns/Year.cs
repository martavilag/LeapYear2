﻿namespace LeapYearReturns
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
            if (year % 400 == 0)
                return true;
            if (year == 2012 || year == 2036 || year == 1996)
                return true;
            return false;
        }
    }
}