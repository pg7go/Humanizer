namespace Humanizer;

class CroatianFormatter(CultureInfo culture) :
    DefaultFormatter(culture, CroatianResources.Instance)
{
    const string PaucalPostfix = "Paucal";

    protected override string GetResourceKey(string resourceKey, int number)
    {
        var mod10 = number % 10;
        if (mod10 is > 1 and < 5 && number != 12 && number != 13 && number != 14)
        {
            return resourceKey + PaucalPostfix;
        }

        return resourceKey;
    }
}