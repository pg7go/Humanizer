namespace Humanizer;

public partial class ResourceKeys
{
    /// <summary>
    /// Encapsulates the logic required to get the resource keys for TimeSpan.Humanize
    /// Examples: TimeSpanSingleMinute, TimeSpanMultipleHours.
    /// </summary>
    public static class TimeSpanHumanize
    {
        /// <summary>
        /// Generates Resource Keys according to convention.
        /// </summary>
        /// <param name="unit">Time unit, <see cref="TimeUnit"/>.</param>
        /// <param name="count">Number of units, default is One.</param>
        /// <param name="toWords">Result to words, default is false.</param>
        /// <returns>Resource key, like TimeSpanSingleMinute</returns>
        public static string GetResourceKey(TimeUnit unit, int count = 1, bool toWords = false)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (count == 0 && toWords)
            {
                return "TimeSpanZero";
            }

            if (count == 1)
            {
                return unit switch
                {
                    TimeUnit.Millisecond => "TimeSpanSingleMillisecond",
                    TimeUnit.Second => "TimeSpanSingleSecond",
                    TimeUnit.Minute => "TimeSpanSingleMinute",
                    TimeUnit.Hour => "TimeSpanSingleHour",
                    TimeUnit.Day => "TimeSpanSingleDay",
                    TimeUnit.Week => "TimeSpanSingleWeek",
                    TimeUnit.Month => "TimeSpanSingleMonth",
                    TimeUnit.Year => "TimeSpanSingleYear",
                    _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, null)
                };
            }

            return unit switch
            {
                TimeUnit.Millisecond => "TimeSpanMultipleMilliseconds",
                TimeUnit.Second => "TimeSpanMultipleSeconds",
                TimeUnit.Minute => "TimeSpanMultipleMinutes",
                TimeUnit.Hour => "TimeSpanMultipleHours",
                TimeUnit.Day => "TimeSpanMultipleDays",
                TimeUnit.Week => "TimeSpanMultipleWeeks",
                TimeUnit.Month => "TimeSpanMultipleMonths",
                TimeUnit.Year => "TimeSpanMultipleYears",
                _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, null)
            };
        }
    }
}