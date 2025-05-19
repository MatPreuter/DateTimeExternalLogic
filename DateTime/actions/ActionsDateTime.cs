using DateTime.interfaces;
using DateTime.structures;

namespace DateTime.actions {
    public class ActionsDateTime : InterfaceDateTime {

        public void AddQuarters(DateTime DateIn, int Quarters, out DateTime Date) {
            Date = new DateTime();


        }

        public void AddWeeks(DateTime DateIn, int Weeks, out DateTime Date) {
            Date = new DateTime();


        }

        public void CurrDateTimeUTC(out DateTime Result) {
            Result = new DateTime();


        }

        public void CurrTicksMilliseconds(out decimal TicksMilliseconds) {
            TicksMilliseconds = 0;


        }

        public void CurrTicksTimestamp(out long TicksTimestamp) {
            TicksTimestamp = 0;


        }

        public void CurrUnixMilliseconds(out long UnixMilliseconds) {
            UnixMilliseconds = 0;


        }

        public void CurrUnixTimestamp(out int UnixTimestamp) {
            UnixTimestamp = 0;


        }

        public void DateMax(DateTime Date1, DateTime Date2, out DateTime Result) {
            Result = new DateTime();


        }

        public void DateMin(DateTime Date1, DateTime Date2, out DateTime Result) {
            Result = new DateTime();


        }

        public void DateTimeCeiling(DateTime DateTime, int Interval, out DateTime Result) {
            Result = new DateTime();


        }

        public void DateTimeFloor(DateTime DateTime, int Interval, out DateTime Result) {
            Result = new DateTime();


        }

        public void DateTimeToISO8601(DateTime Date, out string Result) {
            Result = "";


        }

        public void DateTimeToUnixMilliseconds(DateTime DateTime, out long UnixMilliseconds) {
            UnixMilliseconds = 0;


        }

        public void DateTimeToUnixTimestamp(DateTime DateTime, out int UnixTimestamp) {
            UnixTimestamp = 0;


        }

        public void DayLightSaving_End(string TimeZoneId, int Year, out DateTime Date) {
            Date = new DateTime();


        }

        public void DayLightSaving_Start(string TimeZoneId, int Year, out DateTime Date) {
            Date = new DateTime();


        }

        public void DiffMonths(DateTime Date1, DateTime Date2, out int Value) {
            Value = 0;


        }

        public void DiffQuarters(DateTime Date1, DateTime Date2, out int Value) {
            Value = 0;


        }

        public void DiffWeeks(DateTime Date1, DateTime Date2, out int Value) {
            Value = 0;


        }

        public void DiffYears(DateTime Date1, DateTime Date2, out int Value) {
            Value = 0;


        }

        public void GetTimeZones(out string LocalTimeZoneId, out List<TimeZoneInfo> TimeZoneInfoList) {
            LocalTimeZoneId = "";

TimeZoneInfoList = new List<TimeZoneInfo>();


        }

        public void SecondsToTime(decimal Seconds, out DateTime Time) {
            Time = new DateTime();


        }

        public void StartOfMonth(DateTime DateIn, out DateTime DateOut) {
            DateOut = new DateTime();


        }

        public void StartOfQuarter(DateTime DateIn, out DateTime DateOut) {
            DateOut = new DateTime();


        }

        public void StartOfWeek(int FirstDayOfWeek, int WeekNumber, int WeekRule, int Year, out DateTime DateOut) {
            DateOut = new DateTime();


        }

        public void StartOfYear(DateTime DateIn, out DateTime DateOut) {
            DateOut = new DateTime();


        }

        public void UnixMillisecondsToDateTime(long UnixMilliseconds, out DateTime DateTime) {
            DateTime = new DateTime();


        }

        public void UnixTimestampToDateTime(int UnixTimestamp, out DateTime DateTime) {
            DateTime = new DateTime();


        }

        public void WeekNumber(DateTime DateIn, int FirstDayOfWeek, int WeekRule, out int Out) {
            Out = 0;


        }

    }
}