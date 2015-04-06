
namespace State
{
    class DontDoThis
    {
        string mode = string.Empty;
        string YearMode = string.Empty;
        string MonthMode = string.Empty;
        string DayMode = string.Empty;
        string HourMode = string.Empty;
        string MinuteMode = string.Empty;
        int year = 0;
        int month = 0;
        int day = 0;
        int hour = 0;
        int minute = 0;
        // *** Don't Do this ***
        public void RotateKnobLeft()
        { 
            if(mode == YearMode)
            {
                year--;
            }
            if (mode == MonthMode)
            {
                month--;
            }
            if (mode == DayMode)
            {
                day--;
            }
            if (mode == HourMode)
            {
                hour--;
            }
            if (mode == MinuteMode)
            {
                minute--;
            }
        }
    }
}
