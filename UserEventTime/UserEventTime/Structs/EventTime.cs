namespace UserEventTime.Structs
{
    public struct EventTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }

        public EventTime(int year, int month, int day, int hour)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
        }
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day, Hour, 0, 0);
        }
    }
}
