﻿namespace Humanizer;

class SerbianFormatter(CultureInfo culture, IResources resources) :
    DefaultFormatter(culture, resources)
{
    const string PaucalPostfix = "Paucal";

    protected override string GetResourceKey(string resourceKey, int number)
    {
        var mod10 = number % 10;
        if (mod10 is > 1 and < 5)
        {
            return resourceKey + PaucalPostfix;
        }

        return resourceKey;
    }
}