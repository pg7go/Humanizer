﻿namespace Humanizer;

/// <summary>
/// Default implementation of IFormatter interface.
/// </summary>
#pragma warning disable CS9113 // Parameter is unread.
public class DefaultFormatter(CultureInfo culture, IResources resources) : IFormatter
#pragma warning restore CS9113 // Parameter is unread.
{
    protected CultureInfo Culture { get; } = culture;

    public DefaultFormatter(string localeCode, IResources resources)
        : this(new CultureInfo(localeCode), resources)
    {
    }


    bool inited;
    Dictionary<string, string> resDict=new ();
    private void Init()
    {
        inited = true;
        resDict = new();
        foreach (var property in resources.GetType().GetProperties())
        {
            if (property.PropertyType == typeof(string))
            {
                var value = (string?)property.GetValue(resources);
                if (value != null)
                {
                    resDict.Add(property.Name,value);
                }
            }
        }
    }
    public string GetResource(string key)
    {
        if (!inited)
            Init();
        return resDict.TryGetValue(key, out var str) ? str : Resources.GetResource(key, CultureInfo.InvariantCulture);
    }






    public virtual string DateHumanize_Now() =>
        GetResourceForDate(TimeUnit.Millisecond, Tense.Past, 0);

    public virtual string DateHumanize_Never() =>
        resources.DateNever;

    /// <summary>
    /// Returns the string representation of the provided DateTime
    /// </summary>
    public virtual string DateHumanize(TimeUnit timeUnit, Tense timeUnitTense, int unit) =>
        GetResourceForDate(timeUnit, timeUnitTense, unit);

    /// <summary>
    /// 0 seconds
    /// </summary>
    /// <returns>Returns 0 seconds as the string representation of Zero TimeSpan</returns>
    public virtual string TimeSpanHumanize_Zero() =>
        GetResourceForTimeSpan(TimeUnit.Millisecond, 0, true);

    /// <summary>
    /// Returns the string representation of the provided TimeSpan
    /// </summary>
    /// <param name="timeUnit">A time unit to represent.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">Is thrown when timeUnit is larger than TimeUnit.Week</exception>
    public virtual string TimeSpanHumanize(TimeUnit timeUnit, int unit, bool toWords = false) =>
        GetResourceForTimeSpan(timeUnit, unit, toWords);

    /// <inheritdoc/>
    public virtual string TimeSpanHumanize_Age() =>
        resources.TimeSpanAge;

    /// <inheritdoc cref="IFormatter.DataUnitHumanize(DataUnit, double, bool)"/>
    public virtual string DataUnitHumanize(DataUnit dataUnit, double count, bool toSymbol = true)
    {
        var resourceKey = toSymbol ? $"DataUnit{dataUnit}Symbol" : $"DataUnit{dataUnit}";
        var resourceValue = GetResource(resourceKey);

        if (!toSymbol && count > 1)
            resourceValue += 's';

        return resourceValue;
    }

    /// <inheritdoc />
    public virtual string TimeUnitHumanize(TimeUnit timeUnit) =>
        timeUnit switch
        {
            TimeUnit.Millisecond => resources.TimeUnitMillisecond,
            TimeUnit.Second => resources.TimeUnitSecond,
            TimeUnit.Minute => resources.TimeUnitMinute,
            TimeUnit.Hour => resources.TimeUnitHour,
            TimeUnit.Day => resources.TimeUnitDay,
            TimeUnit.Week => resources.TimeUnitWeek,
            TimeUnit.Month => resources.TimeUnitMonth,
            TimeUnit.Year => resources.TimeUnitYear,
            _ => throw new ArgumentOutOfRangeException(nameof(timeUnit), timeUnit, null)
        };

    string GetResourceForDate(TimeUnit unit, Tense timeUnitTense, int count)
    {
        var resourceKey = ResourceKeys.DateHumanize.GetResourceKey(unit, timeUnitTense: timeUnitTense, count: count);
        if (count == 1)
        {
            return GetResource(resourceKey);
        }
        return Format(unit, resourceKey, count);
    }

    string GetResourceForTimeSpan(TimeUnit unit, int count, bool toWords = false)
    {
        var resourceKey = ResourceKeys.TimeSpanHumanize.GetResourceKey(unit, count, toWords);
        if (count == 1)
        {
            return GetResource(resourceKey + (toWords ? "Words" : ""));
        }

        return Format(unit, resourceKey, count, toWords);
    }

    /// <summary>
    /// Formats the specified resource key.
    /// </summary>
    /// <param name="unit"></param>
    /// <param name="resourceKey">The resource key.</param>
    /// <param name="number">The number.</param>
    /// <param name="toWords"></param>
    /// <exception cref="ArgumentException">If the resource not exists on the specified culture.</exception>
    protected virtual string Format(TimeUnit unit, string resourceKey, int number, bool toWords = false)
    {
        var resolvedKey = GetResourceKey(resourceKey, number);
        var resourceString = GetResource(resolvedKey);

        return string.Format(resourceString, toWords ? NumberToWords(unit, number, Culture) : number);
    }

    protected virtual string NumberToWords(TimeUnit unit, int number, CultureInfo culture) =>
        number.ToWords(culture);

    /// <summary>
    /// Override this method if your locale has complex rules around multiple units; e.g. Arabic, Russian
    /// </summary>
    /// <param name="resourceKey">The resource key that's being in formatting</param>
    /// <param name="number">The number of the units being used in formatting</param>
    protected virtual string GetResourceKey(string resourceKey, int number) =>
        resourceKey;
}