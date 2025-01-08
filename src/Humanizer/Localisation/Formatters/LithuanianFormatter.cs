namespace Humanizer;

class LithuanianFormatter(CultureInfo culture) :
    DefaultFormatter(culture, LithuanianResources.Instance)
{
    protected override string GetResourceKey(string resourceKey, int number)
    {
        if (resourceKey == "TimeSpanZero")
        {
            return resourceKey;
        }

        var grammaticalNumber = LithuanianNumberFormDetector.Detect(number);
        var suffix = GetSuffix(grammaticalNumber);
        return resourceKey + suffix;
    }

    static string GetSuffix(LithuanianNumberForm form)
    {
        if (form == LithuanianNumberForm.Singular)
        {
            return "Singular";
        }

        if (form == LithuanianNumberForm.GenitivePlural)
        {
            return "Plural";
        }

        return "";
    }
}