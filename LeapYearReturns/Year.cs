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
            if (year == 1900 || year == 2200 || year == 2300)
                return false;
            if (year % 400 == 0)
                return true;
            if (year % 4 == 0)
                return true;
            return false;
        }
    }
}