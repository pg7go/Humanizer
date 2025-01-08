namespace Humanizer;

class CzechSlovakPolishFormatter(CultureInfo culture, IResources resources) :
    DefaultFormatter(culture, resources)
{
    const string PaucalPostfix = "Paucal";

    protected override string GetResourceKey(string resourceKey, int number)
    {
        if (number is > 1 and < 5)
        {
            return resourceKey + PaucalPostfix;
        }

        return resourceKey;
    }
}