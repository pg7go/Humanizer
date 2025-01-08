namespace Humanizer;

class MalteseFormatter(CultureInfo culture) :
    DefaultFormatter(culture, MalteseResources.Instance)
{
    protected override string GetResourceKey(string resourceKey, int number)
    {
        if (number != 2)
        {
            return resourceKey;
        }

        if (DualResourceKeys.TryGetValue(resourceKey, out var result))
        {
            return result;
        }

        return resourceKey;
    }

    static readonly FrozenDictionary<string, string> DualResourceKeys =
        new Dictionary<string, string>
            {
                {
                    "DateMultipleDaysAgo", "DateMultipleDaysAgoDual"
                },
                {
                    "DateMultipleDaysFromNow", "DateMultipleDaysFromNowDual"
                },
                {
                    "DateMultipleHoursAgo", "DateMultipleHoursAgoDual"
                },
                {
                    "DateMultipleHoursFromNow", "DateMultipleHoursFromNowDual"
                },
                {
                    "DateMultipleMonthsAgo", "DateMultipleMonthsAgoDual"
                },
                {
                    "DateMultipleMonthsFromNow", "DateMultipleMonthsFromNowDual"
                },
                {
                    "DateMultipleYearsAgo", "DateMultipleYearsAgoDual"
                },
                {
                    "DateMultipleYearsFromNow", "DateMultipleYearsFromNowDual"
                },
                {
                    "TimeSpanMultipleDays", "TimeSpanMultipleDaysDual"
                },
                {
                    "TimeSpanMultipleYears", "TimeSpanMultipleYearsDual"
                },
                {
                    "TimeSpanMultipleMonths", "TimeSpanMultipleMonthsDual"
                },
                {
                    "TimeSpanMultipleHours", "TimeSpanMultipleHoursDual"
                },
                {
                    "TimeSpanMultipleWeeks", "TimeSpanMultipleWeeksDual"
                },
            }
            .ToFrozenDictionary();
}