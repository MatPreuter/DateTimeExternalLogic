using OutSystems.ExternalLibraries.SDK;
using DateTime.structures;

namespace DateTime.interfaces
{
    [OSInterface(
        Name = "DateTime",
        Description = "Extended DateTime functions. Has add/diff, daylight saving, rounding, week number functions and more."
    )]
    public interface InterfaceDateTime
    {   
        [OSAction(
            Description = "Adds a number of quarters to a given date time."
        )]
        void AddQuarters(DateTime DateIn, int Quarters, out DateTime Date);
        [OSAction(
            Description = "Adds a number of weeks to a given date time."
        )]
        void AddWeeks(DateTime DateIn, int Weeks, out DateTime Date);
        [OSAction(
            Description = "Returns the current time in UTC."
        )]
        void CurrDateTimeUTC(out DateTime Result);
        [OSAction(
            Description = "The value in millisecond sof the Ticks property represents the number of 100-nanosecond intervals that have elapsed since 12:00:00 midnight on January 1, 0001, there are 10,000 ticks in a millisecond"
        )]
        void CurrTicksMilliseconds(out decimal TicksMilliseconds);
        [OSAction(
            Description = "The value of the Ticks property represents the number of 100-nanosecond intervals that have elapsed since 12:00:00 midnight on January 1, 0001"
        )]
        void CurrTicksTimestamp(out long TicksTimestamp);
        [OSAction(
            Description = "Returns the current Unix epoch time in milliseconds (e.g. 1541560518264)."
        )]
        void CurrUnixMilliseconds(out long UnixMilliseconds);
        [OSAction(
            Description = "Returns the current Unix epoch time (e.g. 1541560467)."
        )]
        void CurrUnixTimestamp(out int UnixTimestamp);
        [OSAction(
            Description = "Returns the largest date."
        )]
        void DateMax(DateTime Date1, DateTime Date2, out DateTime Result);
        [OSAction(
            Description = "Returns the smallest date."
        )]
        void DateMin(DateTime Date1, DateTime Date2, out DateTime Result);
        [OSAction(
            Description = "Rounds the datetime up to a given interval in minutes (e.g. 10:12, with 15m interval = 10:15)"
        )]
        void DateTimeCeiling(DateTime DateTime, int Interval, out DateTime Result);
        [OSAction(
            Description = "Rounds the datetime down to a given interval in minutes (e.g. 10:12, with 15m interval = 10:00)"
        )]
        void DateTimeFloor(DateTime DateTime, int Interval, out DateTime Result);
        [OSAction(
            Description = "Converts a DateTime value to the ISO 8601 format."
        )]
        void DateTimeToISO8601(DateTime Date, out string Result);
        [OSAction(
            Description = "Converts a date time to an Unix epoch time in milliseconds."
        )]
        void DateTimeToUnixMilliseconds(DateTime DateTime, out long UnixMilliseconds);
        [OSAction(
            Description = "Converts a date time to an Unix epoch time."
        )]
        void DateTimeToUnixTimestamp(DateTime DateTime, out int UnixTimestamp);
        [OSAction(
            Description = "Returns the date in which the daylight saving time ends for a given year and TimeZoneId (default the configured TimeZone on the server)"
        )]
        void DayLightSaving_End(string TimeZoneId, int Year, out DateTime Date);
        [OSAction(
            Description = "Returns the date in which the daylight saving time begins for a given year and TimeZoneId (default the configured TimeZone on the server)"
        )]
        void DayLightSaving_Start(string TimeZoneId, int Year, out DateTime Date);
        [OSAction(
            Description = "Returns the number of months between Date1 and Date2."
        )]
        void DiffMonths(DateTime Date1, DateTime Date2, out int Value);
        [OSAction(
            Description = "Returns the number of quarters between Date1 and Date2."
        )]
        void DiffQuarters(DateTime Date1, DateTime Date2, out int Value);
        [OSAction(
            Description = "Returns the number of weeks between Date1 and Date2."
        )]
        void DiffWeeks(DateTime Date1, DateTime Date2, out int Value);
        [OSAction(
            Description = "Returns the number of years between Date1 and Date2."
        )]
        void DiffYears(DateTime Date1, DateTime Date2, out int Value);
        [OSAction(
            Description = "Get the list of TimeZones available on the Server"
        )]
        void GetTimeZones(out string LocalTimeZoneId, out List<TimeZoneInfo> TimeZoneInfoList);
        [OSAction(
            Description = "Converts a set amount of seconds to a Time variable."
        )]
        void SecondsToTime(decimal Seconds, out DateTime Time);
        [OSAction(
            Description = "Returns the date that represents the start of the month of the given reference date."
        )]
        void StartOfMonth(DateTime DateIn, out DateTime DateOut);
        [OSAction(
            Description = "Returns the date that represents the start of the quarter of the given reference date."
        )]
        void StartOfQuarter(DateTime DateIn, out DateTime DateOut);
        [OSAction(
            Description = "Returns the date that represents the start of the week of the given reference year and week number."
        )]
        void StartOfWeek(int FirstDayOfWeek, int WeekNumber, int WeekRule, int Year, out DateTime DateOut);
        [OSAction(
            Description = "Returns the date that represents the start of the year of the given reference date."
        )]
        void StartOfYear(DateTime DateIn, out DateTime DateOut);
        [OSAction(
            Description = "Converts an Unix epoch time in milliseconds to date time."
        )]
        void UnixMillisecondsToDateTime(long UnixMilliseconds, out DateTime DateTime);
        [OSAction(
            Description = "Converts an Unix epoch time to date time."
        )]
        void UnixTimestampToDateTime(int UnixTimestamp, out DateTime DateTime);
        [OSAction(
            Description = "Gives the week number within the year of the given date. The first week begins at 1."
        )]
        void WeekNumber(DateTime DateIn, int FirstDayOfWeek, int WeekRule, out int Out);
    }
}