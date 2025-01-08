namespace Humanizer;

public partial class ResourceKeys
{
    /// <summary>
    /// Encapsulates the logic required to get the resource keys for DateTime.Humanize
    /// </summary>
    public static class DateHumanize
    {
        /// <summary>
        /// Resource key for Now.
        /// </summary>
        public const string Now = "DateNow";

        /// <summary>
        /// Resource key for Never.
        /// </summary>
        public const string Never = "DateNever";

        /// <summary>
        /// Generates Resource Keys according to convention.
        /// </summary>
        /// <param name="timeUnit">Time unit</param>
        /// <param name="timeUnitTense">Is time unit in future or past</param>
        /// <param name="count">Number of units, default is One.</param>
        /// <returns>Resource key, like DateSingleMinuteAgo</returns>
        public static string GetResourceKey(TimeUnit timeUnit, Tense timeUnitTense, int count = 1)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (count == 0)
            {
                return Now;
            }

            if (count == 1)
            {
                if (timeUnitTense == Tense.Future)
                {
                    return timeUnit switch
                    {
                        TimeUnit.Millisecond => "DateSingleMillisecondFromNow",
                        TimeUnit.Second => "DateSingleSecondFromNow",
                        TimeUnit.Minute => "DateSingleMinuteFromNow",
                        TimeUnit.Hour => "DateSingleHourFromNow",
                        TimeUnit.Day => "DateSingleDayFromNow",
                        TimeUnit.Week => "DateSingleWeekFromNow",
                        TimeUnit.Month => "DateSingleMonthFromNow",
                        TimeUnit.Year => "DateSingleYearFromNow",
                        _ => throw new ArgumentOutOfRangeException(nameof(timeUnit), timeUnit, null)
                    };
                }

                return timeUnit switch
                {
                    TimeUnit.Millisecond => "DateSingleMillisecondAgo",
                    TimeUnit.Second => "DateSingleSecondAgo",
                    TimeUnit.Minute => "DateSingleMinuteAgo",
                    TimeUnit.Hour => "DateSingleHourAgo",
                    TimeUnit.Day => "DateSingleDayAgo",
                    TimeUnit.Week => "DateSingleWeekAgo",
                    TimeUnit.Month => "DateSingleMonthAgo",
                    TimeUnit.Year => "DateSingleYearAgo",
                    _ => throw new ArgumentOutOfRangeException(nameof(timeUnit), timeUnit, null)
                };
            }

            if (timeUnitTense == Tense.Future)
            {
                return timeUnit switch
                {
                    TimeUnit.Millisecond => "DateMultipleMillisecondsFromNow",
                    TimeUnit.Second => "DateMultipleSecondsFromNow",
                    TimeUnit.Minute => "DateMultipleMinutesFromNow",
                    TimeUnit.Hour => "DateMultipleHoursFromNow",
                    TimeUnit.Day => "DateMultipleDaysFromNow",
                    TimeUnit.Week => "DateMultipleWeeksFromNow",
                    TimeUnit.Month => "DateMultipleMonthsFromNow",
                    TimeUnit.Year => "DateMultipleYearsFromNow",
                    _ => throw new ArgumentOutOfRangeException(nameof(timeUnit), timeUnit, null)
                };
            }

            return timeUnit switch
            {
                TimeUnit.Millisecond => "DateMultipleMillisecondsAgo",
                TimeUnit.Second => "DateMultipleSecondsAgo",
                TimeUnit.Minute => "DateMultipleMinutesAgo",
                TimeUnit.Hour => "DateMultipleHoursAgo",
                TimeUnit.Day => "DateMultipleDaysAgo",
                TimeUnit.Week => "DateMultipleWeeksAgo",
                TimeUnit.Month => "DateMultipleMonthsAgo",
                TimeUnit.Year => "DateMultipleYearsAgo",
                _ => throw new ArgumentOutOfRangeException(nameof(timeUnit), timeUnit, null)
            };
        }
    }
}