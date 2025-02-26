﻿namespace Humanizer;

class UkrainianFormatter(CultureInfo culture)
    : DefaultFormatter(culture, UkrainianResources.Instance)
{
    protected override string GetResourceKey(string resourceKey, int number)
    {
        var grammaticalNumber = RussianGrammaticalNumberDetector.Detect(number);
        return grammaticalNumber switch
        {
            RussianGrammaticalNumber.Singular => resourceKey + "Singular",
            RussianGrammaticalNumber.Paucal => resourceKey + "Paucal",
            _ => resourceKey
        };
    }

    protected override string NumberToWords(TimeUnit unit, int number, CultureInfo culture) =>
        number.ToWords(GetUnitGender(unit), culture);

    static GrammaticalGender GetUnitGender(TimeUnit unit) =>
        unit switch
        {
            TimeUnit.Day or TimeUnit.Week or TimeUnit.Month or TimeUnit.Year => GrammaticalGender.Masculine,
            _ => GrammaticalGender.Feminine
        };
}