class CroatianResources : IResources
{
    public string Culture => "hr";
    public static CroatianResources Instance => new();
    public string DateSingleSecondAgo => "prije jedne sekunde";
    public string DateMultipleSecondsAgo => "prije {0} sekundi";
    public string DateMultipleSecondsAgoPaucal => "prije {0} sekunde";
    public string DateSingleMinuteAgo => "prije jedne minute";
    public string DateMultipleMinutesAgo => "prije {0} minuta";
    public string DateMultipleMinutesAgoPaucal => "prije {0} minute";
    public string DateSingleHourAgo => "prije sat vremena";
    public string DateMultipleHoursAgo => "prije {0} sati";
    public string DateMultipleHoursAgoPaucal => "prije {0} sata";
    public string DateSingleDayAgo => "jučer";
    public string DateMultipleDaysAgo => "prije {0} dana";
    public string DateSingleMonthAgo => "prije mjesec dana";
    public string DateMultipleMonthsAgo => "prije {0} mjeseci";
    public string DateMultipleMonthsAgoPaucal => "prije {0} mjeseca";
    public string DateSingleYearAgo => "prije godinu dana";
    public string DateMultipleYearsAgo => "prije {0} godina";
    public string DateMultipleYearsAgoPaucal => "prije {0} godine";
    public string TimeSpanMultipleDays => "{0} dana";
    public string TimeSpanMultipleDaysPaucal => "{0} dana";
    public string TimeSpanMultipleHours => "{0} sati";
    public string TimeSpanMultipleHoursPaucal => "{0} sata";
    public string TimeSpanMultipleMilliseconds => "{0} milisekundi";
    public string TimeSpanMultipleMillisecondsPaucal => "{0} milisekunde";
    public string TimeSpanMultipleMinutes => "{0} minuta";
    public string TimeSpanMultipleMinutesPaucal => "{0} minute";
    public string TimeSpanMultipleSeconds => "{0} sekundi";
    public string TimeSpanMultipleSecondsPaucal => "{0} sekunde";
    public string TimeSpanSingleDay => "1 dan";
    public string TimeSpanSingleHour => "1 sat";
    public string TimeSpanSingleMillisecond => "1 milisekunda";
    public string TimeSpanSingleMinute => "1 minuta";
    public string TimeSpanSingleSecond => "1 sekunda";
    public string TimeSpanZero => "bez podatka o vremenu";
    public string TimeSpanMultipleWeeks => "{0} tjedana";
    public string TimeSpanMultipleWeeksPaucal => "{0} tjedna";
    public string TimeSpanSingleWeek => "1 tjedan";
    public string DateMultipleDaysFromNow => "za {0} dana";
    public string DateMultipleHoursFromNow => "za {0} sati";
    public string DateMultipleHoursFromNowPaucal => "za {0} sata";
    public string DateMultipleMinutesFromNow => "za {0} minuta";
    public string DateMultipleMinutesFromNowPaucal => "za {0} minute";
    public string DateMultipleMonthsFromNow => "za {0} mjeseci";
    public string DateMultipleMonthsFromNowPaucal => "za {0} mjeseca";
    public string DateMultipleSecondsFromNow => "za {0} sekundi";
    public string DateMultipleSecondsFromNowPaucal => "za {0} sekunde";
    public string DateMultipleYearsFromNow => "za {0} godina";
    public string DateMultipleYearsFromNowPaucal => "za {0} godine";
    public string DateNow => "upravo sada";
    public string DateSingleDayFromNow => "sutra";
    public string DateSingleHourFromNow => "za sat vremena";
    public string DateSingleMinuteFromNow => "za jednu minutu";
    public string DateSingleMonthFromNow => "za mjesec dana";
    public string DateSingleSecondFromNow => "za jednu sekundu";
    public string DateSingleYearFromNow => "za godinu dana";
    public string TimeSpanMultipleMonths => "{0} mjeseci";
    public string TimeSpanMultipleMonthsPaucal => "{0} mjeseca";
    public string TimeSpanMultipleYears => "{0} godina";
    public string TimeSpanMultipleYearsPaucal => "{0} godine";
    public string TimeSpanSingleMonth => "1 mjesec";
    public string TimeSpanSingleYear => "1 godina";
    public string DateMultipleDaysAgoPaucal => "prije {0} dana";
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
    public string DateNever => InvariantResources.Instance.DateNever;
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
    public string DateMultipleDaysFromNowPaucal => InvariantResources.Instance.DateMultipleDaysFromNowPaucal;
    public string DateTwoDaysAgo => InvariantResources.Instance.DateTwoDaysAgo;
    public string DateTwoDaysFromNow => InvariantResources.Instance.DateTwoDaysFromNow;
    public string TimeSpanAge => InvariantResources.Instance.TimeSpanAge;
}