namespace Humanizer;

class SlovenianFormatter(CultureInfo culture) :
    DefaultFormatter(culture, SlovenianResources.Instance)
{
    const string DualPostfix = "Dual";
    const string TrialQuadralPostfix = "Paucal";

    protected override string GetResourceKey(string resourceKey, int number)
    {
        if (number == 2)
        {
            return resourceKey + DualPostfix;
        }

        // When the count is three or four some words have a different form when counting in Slovenian language
        if (number is 3 or 4)
        {
            return resourceKey + TrialQuadralPostfix;
        }

        return resourceKey;
    }
}