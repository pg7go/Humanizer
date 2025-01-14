class UkrainianResources : IResources
{
    public string Culture => "uk";
    public static UkrainianResources Instance => new();
    public string DateSingleSecondAgo => "секунду тому";
    public string DateSingleMinuteAgo => "хвилину тому";
    public string DateSingleHourAgo => "годину тому";
    public string DateSingleDayAgo => "вчора";
    public string DateSingleMonthAgo => "місяць тому";
    public string DateSingleYearAgo => "рік тому";
    public string DateMultipleDaysAgoSingular => "{0} день тому";
    public string DateMultipleHoursAgo => "{0} годин тому";
    public string DateMultipleMinutesAgo => "{0} хвилин тому";
    public string DateMultipleMonthsAgo => "{0} місяців тому";
    public string DateMultipleSecondsAgo => "{0} секунд тому";
    public string DateMultipleYearsAgo => "{0} років тому";
    public string DateMultipleDaysAgo => "{0} днів тому";
    public string DateMultipleDaysAgoPaucal => "{0} дні тому";
    public string DateMultipleHoursAgoPaucal => "{0} години тому";
    public string DateMultipleHoursAgoSingular => "{0} годину тому";
    public string DateMultipleMinutesAgoPaucal => "{0} хвилини тому";
    public string DateMultipleMinutesAgoSingular => "{0} хвилину тому";
    public string DateMultipleMonthsAgoPaucal => "{0} місяці тому";
    public string DateMultipleMonthsAgoSingular => "{0} місяць тому";
    public string DateMultipleSecondsAgoPaucal => "{0} секунди тому";
    public string DateMultipleSecondsAgoSingular => "{0} секунду тому";
    public string DateMultipleYearsAgoPaucal => "{0} роки тому";
    public string DateMultipleYearsAgoSingular => "{0} рік тому";
    public string DateNow => "зараз";
    public string TimeSpanMultipleDays => "{0} днів";
    public string TimeSpanMultipleDaysPaucal => "{0} дні";
    public string TimeSpanMultipleDaysSingular => "{0} день";
    public string TimeSpanMultipleHours => "{0} годин";
    public string TimeSpanMultipleHoursPaucal => "{0} години";
    public string TimeSpanMultipleHoursSingular => "{0} година";
    public string TimeSpanMultipleMilliseconds => "{0} мілісекунд";
    public string TimeSpanMultipleMillisecondsPaucal => "{0} мілісекунди";
    public string TimeSpanMultipleMillisecondsSingular => "{0} мілісекунда";
    public string TimeSpanMultipleMinutes => "{0} хвилин";
    public string TimeSpanMultipleMinutesPaucal => "{0} хвилини";
    public string TimeSpanMultipleMinutesSingular => "{0} хвилина";
    public string TimeSpanMultipleSeconds => "{0} секунд";
    public string TimeSpanMultipleSecondsPaucal => "{0} секунди";
    public string TimeSpanMultipleSecondsSingular => "{0} секунда";
    public string TimeSpanMultipleWeeks => "{0} тижнів";
    public string TimeSpanMultipleWeeksPaucal => "{0} тижні";
    public string TimeSpanMultipleWeeksSingular => "{0} тиждень";
    public string TimeSpanSingleDay => "1 день";
    public string TimeSpanSingleHour => "1 година";
    public string TimeSpanSingleMillisecond => "1 мілісекунда";
    public string TimeSpanSingleMinute => "1 хвилина";
    public string TimeSpanSingleSecond => "1 секунда";
    public string TimeSpanSingleWeek => "1 тиждень";
    public string TimeSpanZero => "без часу";
    public string DateMultipleDaysFromNow => "через {0} днів";
    public string DateMultipleDaysFromNowPaucal => "через {0} дні";
    public string DateMultipleDaysFromNowSingular => "через {0} день";
    public string DateMultipleHoursFromNow => "через {0} годин";
    public string DateMultipleHoursFromNowPaucal => "через {0} години";
    public string DateMultipleHoursFromNowSingular => "через {0} годину";
    public string DateMultipleMinutesFromNow => "через {0} хвилин";
    public string DateMultipleMinutesFromNowPaucal => "через {0} хвилини";
    public string DateMultipleMinutesFromNowSingular => "через {0} хвилину";
    public string DateMultipleMonthsFromNow => "через {0} місяців";
    public string DateMultipleMonthsFromNowPaucal => "через {0} місяці";
    public string DateMultipleMonthsFromNowSingular => "через {0} місяць";
    public string DateMultipleSecondsFromNow => "через {0} секунд";
    public string DateMultipleSecondsFromNowPaucal => "через {0} секунди";
    public string DateMultipleSecondsFromNowSingular => "через {0} секунду";
    public string DateMultipleYearsFromNow => "через {0} років";
    public string DateMultipleYearsFromNowPaucal => "через {0} роки";
    public string DateMultipleYearsFromNowSingular => "через {0} рік";
    public string DateSingleDayFromNow => "завтра";
    public string DateSingleHourFromNow => "через годину";
    public string DateSingleMinuteFromNow => "через хвилину";
    public string DateSingleMonthFromNow => "через місяць";
    public string DateSingleSecondFromNow => "через секунду";
    public string DateSingleYearFromNow => "через рік";
    public string TimeSpanMultipleMonths => "{0} місяців";
    public string TimeSpanMultipleMonthsPaucal => "{0} місяці";
    public string TimeSpanMultipleMonthsSingular => "{0} місяць";
    public string TimeSpanMultipleYears => "{0} років";
    public string TimeSpanMultipleYearsPaucal => "{0} роки";
    public string TimeSpanMultipleYearsSingular => "{0} рік";
    public string TimeSpanSingleMonth => "1 місяць";
    public string TimeSpanSingleYear => "1 рік";
    public string TimeSpanSingleDayWords => "один день";
    public string TimeSpanSingleHourWords => "одна година";
    public string TimeSpanSingleMillisecondWords => "одна мілісекунда";
    public string TimeSpanSingleMinuteWords => "одна хвилина";
    public string TimeSpanSingleMonthWords => "один місяць";
    public string TimeSpanSingleSecondWords => "одна секунда";
    public string TimeSpanSingleWeekWords => "один тиждень";
    public string TimeSpanSingleYearWords => "один рік";
    public string DateMultipleHoursFromNowDual => InvariantResources.Instance.DateMultipleHoursFromNowDual;
    public string DateMultipleMinutesFromNowPlural => InvariantResources.Instance.DateMultipleMinutesFromNowPlural;
    public string DateMultipleSecondsAgoDual => InvariantResources.Instance.DateMultipleSecondsAgoDual;
    public string DateMultipleSecondsFromNowDual => InvariantResources.Instance.DateMultipleSecondsFromNowDual;
    public string DateMultipleYearsFromNowDual => InvariantResources.Instance.DateMultipleYearsFromNowDual;
    public string TimeSpanMultipleDaysDual => InvariantResources.Instance.TimeSpanMultipleDaysDual;
    public string TimeSpanMultipleDaysPlural => InvariantResources.Instance.TimeSpanMultipleDaysPlural;
    public string TimeSpanMultipleHoursPlural => InvariantResources.Instance.TimeSpanMultipleHoursPlural;
    public string TimeSpanMultipleMillisecondsDual => InvariantResources.Instance.TimeSpanMultipleMillisecondsDual;
    public string TimeSpanMultipleMinutesDual => InvariantResources.Instance.TimeSpanMultipleMinutesDual;
    public string TimeSpanMultipleMinutesPlural => InvariantResources.Instance.TimeSpanMultipleMinutesPlural;
    public string TimeSpanMultipleSecondsPlural => InvariantResources.Instance.TimeSpanMultipleSecondsPlural;
    public string TimeSpanMultipleMillisecondsPlural => InvariantResources.Instance.TimeSpanMultipleMillisecondsPlural;
    public string DateMultipleDaysAgoDual => InvariantResources.Instance.DateMultipleDaysAgoDual;
    public string DateMultipleDaysAgoPlural => InvariantResources.Instance.DateMultipleDaysAgoPlural;
    public string DateMultipleDaysFromNowDual => InvariantResources.Instance.DateMultipleDaysFromNowDual;
    public string DateMultipleDaysFromNowPlural => InvariantResources.Instance.DateMultipleDaysFromNowPlural;
    public string DateMultipleHoursAgoDual => InvariantResources.Instance.DateMultipleHoursAgoDual;
    public string DateMultipleHoursAgoPlural => InvariantResources.Instance.DateMultipleHoursAgoPlural;
    public string DateMultipleHoursFromNowPlural => InvariantResources.Instance.DateMultipleHoursFromNowPlural;
    public string DateMultipleMinutesAgoDual => InvariantResources.Instance.DateMultipleMinutesAgoDual;
    public string DateMultipleMinutesAgoPlural => InvariantResources.Instance.DateMultipleMinutesAgoPlural;
    public string DateMultipleMinutesFromNowDual => InvariantResources.Instance.DateMultipleMinutesFromNowDual;
    public string DateMultipleMonthsAgoDual => InvariantResources.Instance.DateMultipleMonthsAgoDual;
    public string DateMultipleMonthsAgoPlural => InvariantResources.Instance.DateMultipleMonthsAgoPlural;
    public string DateMultipleMonthsFromNowDual => InvariantResources.Instance.DateMultipleMonthsFromNowDual;
    public string DateMultipleMonthsFromNowPlural => InvariantResources.Instance.DateMultipleMonthsFromNowPlural;
    public string DateMultipleSecondsAgoPlural => InvariantResources.Instance.DateMultipleSecondsAgoPlural;
    public string DateMultipleSecondsFromNowPlural => InvariantResources.Instance.DateMultipleSecondsFromNowPlural;
    public string DateMultipleYearsAgoDual => InvariantResources.Instance.DateMultipleYearsAgoDual;
    public string DateMultipleYearsAgoPlural => InvariantResources.Instance.DateMultipleYearsAgoPlural;
    public string DateMultipleYearsFromNowPlural => InvariantResources.Instance.DateMultipleYearsFromNowPlural;
    public string TimeSpanMultipleHoursDual => InvariantResources.Instance.TimeSpanMultipleHoursDual;
    public string TimeSpanMultipleSecondsDual => InvariantResources.Instance.TimeSpanMultipleSecondsDual;
    public string TimeSpanMultipleWeeksDual => InvariantResources.Instance.TimeSpanMultipleWeeksDual;
    public string TimeSpanMultipleWeeksPlural => InvariantResources.Instance.TimeSpanMultipleWeeksPlural;
    public string DateNever => InvariantResources.Instance.DateNever;
    public string TimeSpanMultipleMonthsDual => InvariantResources.Instance.TimeSpanMultipleMonthsDual;
    public string TimeSpanMultipleMonthsPlural => InvariantResources.Instance.TimeSpanMultipleMonthsPlural;
    public string TimeSpanMultipleYearsDual => InvariantResources.Instance.TimeSpanMultipleYearsDual;
    public string TimeSpanMultipleYearsPlural => InvariantResources.Instance.TimeSpanMultipleYearsPlural;
    public string N => InvariantResources.Instance.N;
    public string NNE => InvariantResources.Instance.NNE;
    public string NE => InvariantResources.Instance.NE;
    public string ENE => InvariantResources.Instance.ENE;
    public string E => InvariantResources.Instance.E;
    public string ESE => InvariantResources.Instance.ESE;
    public string SE => InvariantResources.Instance.SE;
    public string SSE => InvariantResources.Instance.SSE;
    public string S => InvariantResources.Instance.S;
    public string SSW => InvariantResources.Instance.SSW;
    public string SW => InvariantResources.Instance.SW;
    public string WSW => InvariantResources.Instance.WSW;
    public string W => InvariantResources.Instance.W;
    public string WNW => InvariantResources.Instance.WNW;
    public string NW => InvariantResources.Instance.NW;
    public string NNW => InvariantResources.Instance.NNW;
    public string NShort => InvariantResources.Instance.NShort;
    public string NNEShort => InvariantResources.Instance.NNEShort;
    public string NEShort => InvariantResources.Instance.NEShort;
    public string ENEShort => InvariantResources.Instance.ENEShort;
    public string EShort => InvariantResources.Instance.EShort;
    public string ESEShort => InvariantResources.Instance.ESEShort;
    public string SEShort => InvariantResources.Instance.SEShort;
    public string SSEShort => InvariantResources.Instance.SSEShort;
    public string SShort => InvariantResources.Instance.SShort;
    public string SSWShort => InvariantResources.Instance.SSWShort;
    public string SWShort => InvariantResources.Instance.SWShort;
    public string WSWShort => InvariantResources.Instance.WSWShort;
    public string WShort => InvariantResources.Instance.WShort;
    public string WNWShort => InvariantResources.Instance.WNWShort;
    public string NWShort => InvariantResources.Instance.NWShort;
    public string NNWShort => InvariantResources.Instance.NNWShort;
    public string DataUnitBit => InvariantResources.Instance.DataUnitBit;
    public string DataUnitBitSymbol => InvariantResources.Instance.DataUnitBitSymbol;
    public string DataUnitByte => InvariantResources.Instance.DataUnitByte;
    public string DataUnitByteSymbol => InvariantResources.Instance.DataUnitByteSymbol;
    public string DataUnitKilobyte => InvariantResources.Instance.DataUnitKilobyte;
    public string DataUnitKilobyteSymbol => InvariantResources.Instance.DataUnitKilobyteSymbol;
    public string DataUnitMegabyte => InvariantResources.Instance.DataUnitMegabyte;
    public string DataUnitMegabyteSymbol => InvariantResources.Instance.DataUnitMegabyteSymbol;
    public string DataUnitGigabyte => InvariantResources.Instance.DataUnitGigabyte;
    public string DataUnitGigabyteSymbol => InvariantResources.Instance.DataUnitGigabyteSymbol;
    public string DataUnitTerabyte => InvariantResources.Instance.DataUnitTerabyte;
    public string DataUnitTerabyteSymbol => InvariantResources.Instance.DataUnitTerabyteSymbol;
    public string TimeUnitMillisecond => InvariantResources.Instance.TimeUnitMillisecond;
    public string TimeUnitSecond => InvariantResources.Instance.TimeUnitSecond;
    public string TimeUnitMinute => InvariantResources.Instance.TimeUnitMinute;
    public string TimeUnitHour => InvariantResources.Instance.TimeUnitHour;
    public string TimeUnitDay => InvariantResources.Instance.TimeUnitDay;
    public string TimeUnitWeek => InvariantResources.Instance.TimeUnitWeek;
    public string TimeUnitMonth => InvariantResources.Instance.TimeUnitMonth;
    public string TimeUnitYear => InvariantResources.Instance.TimeUnitYear;
    public string DateTwoDaysAgo => InvariantResources.Instance.DateTwoDaysAgo;
    public string DateTwoDaysFromNow => InvariantResources.Instance.DateTwoDaysFromNow;
    public string TimeSpanAge => InvariantResources.Instance.TimeSpanAge;
}
