namespace UserEventTime.Extensions
{
    public static class DateTimeExtension
    {
        public static bool IsWeekend(this DateTime dateTime) 
        {
            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            return false;
        }
    }
}
