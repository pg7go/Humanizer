namespace Humanizer;

class FrenchFormatter(CultureInfo culture, IResources resources) :
    DefaultFormatter(culture, resources)
{
    const string DualPostfix = "Dual";

    protected override string GetResourceKey(string resourceKey, int number)
    {
        if (number == 2 && resourceKey is "DateMultipleDaysAgo" or "DateMultipleDaysFromNow")
        {
            return resourceKey + DualPostfix;
        }

        if (number == 0 && resourceKey.StartsWith("TimeSpanMultiple"))
        {
            return resourceKey + "Singular";
        }

        return resourceKey;
    }
}