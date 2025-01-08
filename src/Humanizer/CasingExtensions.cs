namespace Humanizer;

/// <summary>
/// ApplyCase method to allow changing the case of a sentence easily
/// </summary>
public static class CasingExtensions
{
    /// <summary>
    /// Changes the casing of the provided input
    /// </summary>
    public static string ApplyCase(this string input, LetterCasing casing,CultureInfo? culture=null)
    {
        culture ??= CultureInfo.CurrentCulture;
        return casing switch
        {
            LetterCasing.Title => input.Transform(culture, To.TitleCase),
            LetterCasing.LowerCase => input.Transform(culture, To.LowerCase),
            LetterCasing.AllCaps => input.Transform(culture, To.UpperCase),
            LetterCasing.Sentence => input.Transform(culture, To.SentenceCase),
            _ => throw new ArgumentOutOfRangeException(nameof(casing))
        };
    }
}