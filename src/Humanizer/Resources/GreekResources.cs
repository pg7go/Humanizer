class GreekResources : IResources
{
    public string Culture => "el";
    public static GreekResources Instance => new();
    public string DateMultipleDaysAgo => "πριν από {0} ημέρες";
    public string DateMultipleDaysFromNow => "{0} ημέρες από τώρα";
    public string DateMultipleHoursAgo => "πριν από {0} ώρες";
    public string DateMultipleHoursFromNow => "{0} ώρες από τώρα";
    public string DateMultipleMinutesAgo => "πριν από {0} λεπτά";
    public string DateMultipleMinutesFromNow => "{0} λεπτά από τώρα";
    public string DateMultipleMonthsAgo => "πριν από {0} μήνες";
    public string DateMultipleMonthsFromNow => "{0} μήνες από τώρα";
    public string DateMultipleSecondsAgo => "πριν από {0} δευτερόλεπτα";
    public string DateMultipleSecondsFromNow => "{0} δευτερόλεπτα από τώρα";
    public string DateMultipleYearsAgo => "πριν από {0} χρόνια";
    public string DateMultipleYearsFromNow => "{0} χρόνια από τώρα";
    public string DateNever => "ποτέ";
    public string DateNow => "τώρα";
    public string DateSingleDayAgo => "χθες";
    public string DateSingleDayFromNow => "αύριο";
    public string DateSingleHourAgo => "πριν από μία ώρα";
    public string DateSingleHourFromNow => "πρίν από μία ώρα από τώρα";
    public string DateSingleMinuteAgo => "πριν από ένα λεπτό";
    public string DateSingleMinuteFromNow => "πρίν από ένα λεπτό από τώρα";
    public string DateSingleMonthAgo => "πριν από έναν μήνα";
    public string DateSingleMonthFromNow => "πριν από έναν μήνα από τώρα";
    public string DateSingleSecondAgo => "πριν από ένα δευτερόλεπτο";
    public string DateSingleSecondFromNow => "πριν από ένα δευτερόλεπτο από τώρα";
    public string DateSingleYearAgo => "πριν από έναν χρόνο";
    public string DateSingleYearFromNow => "πριν από έναν χρόνο από τώρα";
    public string TimeSpanMultipleDays => "{0} μέρες";
    public string TimeSpanMultipleHours => "{0} ώρες";
    public string TimeSpanMultipleMilliseconds => "{0} χιλιοστά του δευτερολέπτου";
    public string TimeSpanMultipleMinutes => "{0} λεπτά";
    public string TimeSpanMultipleMonths => "{0} μήνες";
    public string TimeSpanMultipleSeconds => "{0} δευτερόλεπτα";
    public string TimeSpanMultipleWeeks => "{0} βδομάδες";
    public string TimeSpanMultipleYears => "{0} χρόνια";
    public string TimeSpanSingleDay => "1 μέρα";
    public string TimeSpanSingleHour => "1 ώρα";
    public string TimeSpanSingleMillisecond => "1 χιλιοσtό του δευτερολέπτου";
    public string TimeSpanSingleMinute => "1 λεπτό";
    public string TimeSpanSingleMonth => "1 μήνα";
    public string TimeSpanSingleSecond => "1 δευτερόλεπτο";
    public string TimeSpanSingleWeek => "1 βδομάδα";
    public string TimeSpanSingleYear => "1 χρόνο";
    public string TimeSpanZero => "μηδέν χρόνος";
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
    public string DateMultipleDaysAgoSingular => InvariantResources.Instance.DateMultipleDaysAgoSingular;
    public string DateMultipleDaysFromNowDual => InvariantResources.Instance.DateMultipleDaysFromNowDual;
    public string DateMultipleDaysFromNowPlural => InvariantResources.Instance.DateMultipleDaysFromNowPlural;
    public string DateMultipleDaysFromNowSingular => InvariantResources.Instance.DateMultipleDaysFromNowSingular;
    public string DateMultipleHoursAgoDual => InvariantResources.Instance.DateMultipleHoursAgoDual;
    public string DateMultipleHoursAgoPlural => InvariantResources.Instance.DateMultipleHoursAgoPlural;
    public string DateMultipleHoursAgoSingular => InvariantResources.Instance.DateMultipleHoursAgoSingular;
    public string DateMultipleHoursFromNowPlural => InvariantResources.Instance.DateMultipleHoursFromNowPlural;
    public string DateMultipleHoursFromNowSingular => InvariantResources.Instance.DateMultipleHoursFromNowSingular;
    public string DateMultipleMinutesAgoDual => InvariantResources.Instance.DateMultipleMinutesAgoDual;
    public string DateMultipleMinutesAgoPlural => InvariantResources.Instance.DateMultipleMinutesAgoPlural;
    public string DateMultipleMinutesAgoSingular => InvariantResources.Instance.DateMultipleMinutesAgoSingular;
    public string DateMultipleMinutesFromNowDual => InvariantResources.Instance.DateMultipleMinutesFromNowDual;
    public string DateMultipleMinutesFromNowSingular => InvariantResources.Instance.DateMultipleMinutesFromNowSingular;
    public string DateMultipleMonthsAgoDual => InvariantResources.Instance.DateMultipleMonthsAgoDual;
    public string DateMultipleMonthsAgoPlural => InvariantResources.Instance.DateMultipleMonthsAgoPlural;
    public string DateMultipleMonthsAgoSingular => InvariantResources.Instance.DateMultipleMonthsAgoSingular;
    public string DateMultipleMonthsFromNowDual => InvariantResources.Instance.DateMultipleMonthsFromNowDual;
    public string DateMultipleMonthsFromNowPlural => InvariantResources.Instance.DateMultipleMonthsFromNowPlural;
    public string DateMultipleMonthsFromNowSingular => InvariantResources.Instance.DateMultipleMonthsFromNowSingular;
    public string DateMultipleSecondsAgoPlural => InvariantResources.Instance.DateMultipleSecondsAgoPlural;
    public string DateMultipleSecondsAgoSingular => InvariantResources.Instance.DateMultipleSecondsAgoSingular;
    public string DateMultipleSecondsFromNowPlural => InvariantResources.Instance.DateMultipleSecondsFromNowPlural;
    public string DateMultipleSecondsFromNowSingular => InvariantResources.Instance.DateMultipleSecondsFromNowSingular;
    public string DateMultipleYearsAgoDual => InvariantResources.Instance.DateMultipleYearsAgoDual;
    public string DateMultipleYearsAgoPlural => InvariantResources.Instance.DateMultipleYearsAgoPlural;
    public string DateMultipleYearsAgoSingular => InvariantResources.Instance.DateMultipleYearsAgoSingular;
    public string DateMultipleYearsFromNowPlural => InvariantResources.Instance.DateMultipleYearsFromNowPlural;
    public string DateMultipleYearsFromNowSingular => InvariantResources.Instance.DateMultipleYearsFromNowSingular;
    public string TimeSpanMultipleDaysSingular => InvariantResources.Instance.TimeSpanMultipleDaysSingular;
    public string TimeSpanMultipleHoursDual => InvariantResources.Instance.TimeSpanMultipleHoursDual;
    public string TimeSpanMultipleHoursSingular => InvariantResources.Instance.TimeSpanMultipleHoursSingular;
    public string TimeSpanMultipleMillisecondsSingular => InvariantResources.Instance.TimeSpanMultipleMillisecondsSingular;
    public string TimeSpanMultipleMinutesSingular => InvariantResources.Instance.TimeSpanMultipleMinutesSingular;
    public string TimeSpanMultipleSecondsDual => InvariantResources.Instance.TimeSpanMultipleSecondsDual;
    public string TimeSpanMultipleSecondsSingular => InvariantResources.Instance.TimeSpanMultipleSecondsSingular;
    public string TimeSpanMultipleWeeksDual => InvariantResources.Instance.TimeSpanMultipleWeeksDual;
    public string TimeSpanMultipleWeeksPlural => InvariantResources.Instance.TimeSpanMultipleWeeksPlural;
    public string TimeSpanMultipleWeeksSingular => InvariantResources.Instance.TimeSpanMultipleWeeksSingular;
    public string TimeSpanMultipleMonthsDual => InvariantResources.Instance.TimeSpanMultipleMonthsDual;
    public string TimeSpanMultipleMonthsPlural => InvariantResources.Instance.TimeSpanMultipleMonthsPlural;
    public string TimeSpanMultipleMonthsSingular => InvariantResources.Instance.TimeSpanMultipleMonthsSingular;
    public string TimeSpanMultipleYearsDual => InvariantResources.Instance.TimeSpanMultipleYearsDual;
    public string TimeSpanMultipleYearsPlural => InvariantResources.Instance.TimeSpanMultipleYearsPlural;
    public string TimeSpanMultipleYearsSingular => InvariantResources.Instance.TimeSpanMultipleYearsSingular;
    public string TimeSpanSingleDayWords => InvariantResources.Instance.TimeSpanSingleDayWords;
    public string TimeSpanSingleHourWords => InvariantResources.Instance.TimeSpanSingleHourWords;
    public string TimeSpanSingleMillisecondWords => InvariantResources.Instance.TimeSpanSingleMillisecondWords;
    public string TimeSpanSingleMinuteWords => InvariantResources.Instance.TimeSpanSingleMinuteWords;
    public string TimeSpanSingleMonthWords => InvariantResources.Instance.TimeSpanSingleMonthWords;
    public string TimeSpanSingleSecondWords => InvariantResources.Instance.TimeSpanSingleSecondWords;
    public string TimeSpanSingleWeekWords => InvariantResources.Instance.TimeSpanSingleWeekWords;
    public string TimeSpanSingleYearWords => InvariantResources.Instance.TimeSpanSingleYearWords;
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
    public string DateMultipleDaysAgoPaucal => InvariantResources.Instance.DateMultipleDaysAgoPaucal;
    public string DateMultipleDaysFromNowPaucal => InvariantResources.Instance.DateMultipleDaysFromNowPaucal;
    public string DateMultipleHoursAgoPaucal => InvariantResources.Instance.DateMultipleHoursAgoPaucal;
    public string DateMultipleHoursFromNowPaucal => InvariantResources.Instance.DateMultipleHoursFromNowPaucal;
    public string DateMultipleMinutesAgoPaucal => InvariantResources.Instance.DateMultipleMinutesAgoPaucal;
    public string DateMultipleMinutesFromNowPaucal => InvariantResources.Instance.DateMultipleMinutesFromNowPaucal;
    public string DateMultipleMonthsAgoPaucal => InvariantResources.Instance.DateMultipleMonthsAgoPaucal;
    public string DateMultipleMonthsFromNowPaucal => InvariantResources.Instance.DateMultipleMonthsFromNowPaucal;
    public string DateMultipleSecondsAgoPaucal => InvariantResources.Instance.DateMultipleSecondsAgoPaucal;
    public string DateMultipleSecondsFromNowPaucal => InvariantResources.Instance.DateMultipleSecondsFromNowPaucal;
    public string DateMultipleYearsAgoPaucal => InvariantResources.Instance.DateMultipleYearsAgoPaucal;
    public string DateMultipleYearsFromNowPaucal => InvariantResources.Instance.DateMultipleYearsFromNowPaucal;
    public string DateTwoDaysAgo => InvariantResources.Instance.DateTwoDaysAgo;
    public string DateTwoDaysFromNow => InvariantResources.Instance.DateTwoDaysFromNow;
    public string TimeSpanMultipleDaysPaucal => InvariantResources.Instance.TimeSpanMultipleDaysPaucal;
    public string TimeSpanMultipleHoursPaucal => InvariantResources.Instance.TimeSpanMultipleHoursPaucal;
    public string TimeSpanMultipleMillisecondsPaucal => InvariantResources.Instance.TimeSpanMultipleMillisecondsPaucal;
    public string TimeSpanMultipleMinutesPaucal => InvariantResources.Instance.TimeSpanMultipleMinutesPaucal;
    public string TimeSpanMultipleMonthsPaucal => InvariantResources.Instance.TimeSpanMultipleMonthsPaucal;
    public string TimeSpanMultipleSecondsPaucal => InvariantResources.Instance.TimeSpanMultipleSecondsPaucal;
    public string TimeSpanMultipleWeeksPaucal => InvariantResources.Instance.TimeSpanMultipleWeeksPaucal;
    public string TimeSpanMultipleYearsPaucal => InvariantResources.Instance.TimeSpanMultipleYearsPaucal;
    public string TimeSpanAge => InvariantResources.Instance.TimeSpanAge;
}