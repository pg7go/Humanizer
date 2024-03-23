class FrenchResources : IResources
{
    public string Culture => "fr";
    public static FrenchResources Instance => new();
    public string DateSingleSecondAgo => "il y a une seconde";
    public string DateMultipleSecondsAgo => "il y a {0} secondes";
    public string DateSingleMinuteAgo => "il y a une minute";
    public string DateMultipleMinutesAgo => "il y a {0} minutes";
    public string DateSingleHourAgo => "il y a une heure";
    public string DateMultipleHoursAgo => "il y a {0} heures";
    public string DateSingleDayAgo => "hier";
    public string DateMultipleDaysAgo => "il y a {0} jours";
    public string DateSingleMonthAgo => "il y a un mois";
    public string DateMultipleMonthsAgo => "il y a {0} mois";
    public string DateSingleYearAgo => "il y a un an";
    public string DateMultipleYearsAgo => "il y a {0} ans";
    public string DateMultipleDaysFromNow => "dans {0} jours";
    public string DateMultipleHoursFromNow => "dans {0} heures";
    public string DateMultipleMinutesFromNow => "dans {0} minutes";
    public string DateMultipleMonthsFromNow => "dans {0} mois";
    public string DateMultipleSecondsFromNow => "dans {0} secondes";
    public string DateMultipleYearsFromNow => "dans {0} ans";
    public string DateNow => "maintenant";
    public string DateSingleDayFromNow => "demain";
    public string DateSingleHourFromNow => "dans une heure";
    public string DateSingleMinuteFromNow => "dans une minute";
    public string DateSingleMonthFromNow => "dans un mois";
    public string DateSingleSecondFromNow => "dans une seconde";
    public string DateSingleYearFromNow => "dans un an";
    public string TimeSpanMultipleDays => "{0} jours";
    public string TimeSpanMultipleHours => "{0} heures";
    public string TimeSpanMultipleMilliseconds => "{0} millisecondes";
    public string TimeSpanMultipleMinutes => "{0} minutes";
    public string TimeSpanMultipleSeconds => "{0} secondes";
    public string TimeSpanMultipleWeeks => "{0} semaines";
    public string TimeSpanSingleDay => "1 jour";
    public string TimeSpanSingleHour => "1 heure";
    public string TimeSpanSingleMillisecond => "1 milliseconde";
    public string TimeSpanSingleMinute => "1 minute";
    public string TimeSpanSingleSecond => "1 seconde";
    public string TimeSpanSingleWeek => "1 semaine";
    public string TimeSpanZero => "temps nul";
    public string DateNever => "jamais";
    public string TimeSpanMultipleMonths => "{0} mois";
    public string TimeSpanMultipleYears => "{0} ans";
    public string TimeSpanSingleMonth => "1 mois";
    public string TimeSpanSingleYear => "1 an";
    public string DateMultipleDaysAgoDual => "avant-hier";
    public string DateMultipleDaysFromNowDual => "après-demain";
    public string TimeSpanMultipleYearsSingular => "{0} an";
    public string TimeSpanMultipleMonthsSingular => "{0} mois";
    public string TimeSpanMultipleWeeksSingular => "{0} semaine";
    public string TimeSpanMultipleDaysSingular => "{0} jour";
    public string TimeSpanMultipleHoursSingular => "{0} heure";
    public string TimeSpanMultipleMinutesSingular => "{0} minute";
    public string TimeSpanMultipleSecondsSingular => "{0} seconde";
    public string TimeSpanMultipleMillisecondsSingular => "{0} milliseconde";
    public string TimeSpanSingleDayWords => "un jour";
    public string TimeSpanSingleHourWords => "une heure";
    public string TimeSpanSingleMillisecondWords => "une milliseconde";
    public string TimeSpanSingleMinuteWords => "une minute";
    public string TimeSpanSingleMonthWords => "un mois";
    public string TimeSpanSingleSecondWords => "une seconde";
    public string TimeSpanSingleWeekWords => "une semaine";
    public string TimeSpanSingleYearWords => "un an";
    public string DataUnitBit => "bit";
    public string DataUnitBitSymbol => "b";
    public string DataUnitByte => "octet";
    public string DataUnitByteSymbol => "o";
    public string DataUnitKilobyte => "kilooctet";
    public string DataUnitKilobyteSymbol => "Ko";
    public string DataUnitMegabyte => "mégaoctet";
    public string DataUnitMegabyteSymbol => "Mo";
    public string DataUnitGigabyte => "gigaoctet";
    public string DataUnitGigabyteSymbol => "Go";
    public string DataUnitTerabyte => "téraoctet";
    public string DataUnitTerabyteSymbol => "To";
    public string TimeUnitMillisecond => "ms";
    public string TimeUnitSecond => "s";
    public string TimeUnitMinute => "min";
    public string TimeUnitHour => "h";
    public string TimeUnitDay => "j";
    public string TimeUnitWeek => "semaine";
    public string TimeUnitMonth => "mois";
    public string TimeUnitYear => "a";
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
    public string DateMultipleDaysAgoPlural => InvariantResources.Instance.DateMultipleDaysAgoPlural;
    public string DateMultipleDaysAgoSingular => InvariantResources.Instance.DateMultipleDaysAgoSingular;
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
    public string TimeSpanMultipleHoursDual => InvariantResources.Instance.TimeSpanMultipleHoursDual;
    public string TimeSpanMultipleSecondsDual => InvariantResources.Instance.TimeSpanMultipleSecondsDual;
    public string TimeSpanMultipleWeeksDual => InvariantResources.Instance.TimeSpanMultipleWeeksDual;
    public string TimeSpanMultipleWeeksPlural => InvariantResources.Instance.TimeSpanMultipleWeeksPlural;
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
