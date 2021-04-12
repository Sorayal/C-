namespace LeapYear
{
    static class LeapYearCalculation
    {
        public static bool TestIfInputIsLeapYear(int inputYear)
        {
            bool isLeapYear;
            if (inputYear % 4 == 0)
            {
                if(inputYear % 100 == 0 && inputYear % 400 != 0)
                {
                    isLeapYear = false;
                }
                else
                {
                    isLeapYear = true;
                }               
            }
            else
            {
                isLeapYear = false;
            }
            return isLeapYear;
        }
    }
}
