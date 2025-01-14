﻿namespace Humanizer;

class RomanianFormatter(CultureInfo culture) :
    DefaultFormatter(culture, RomanianResources.Instance)
{
    const int PrepositionIndicatingDecimals = 2;
    const int MaxNumeralWithNoPreposition = 19;
    const int MinNumeralWithNoPreposition = 1;
    const string UnitPreposition = " de";

    static readonly double Divider = Math.Pow(10, PrepositionIndicatingDecimals);

    protected override string Format(TimeUnit unit, string resourceKey, int number, bool toWords = false)
    {
        var format = GetResource(GetResourceKey(resourceKey, number));
        var preposition = ShouldUsePreposition(number)
            ? UnitPreposition
            : string.Empty;

        return string.Format(format, number, preposition);
    }

    static bool ShouldUsePreposition(int number)
    {
        var prepositionIndicatingNumeral = Math.Abs(number % Divider);
        return prepositionIndicatingNumeral is < MinNumeralWithNoPreposition or > MaxNumeralWithNoPreposition;
    }
}