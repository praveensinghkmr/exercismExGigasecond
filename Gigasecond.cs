using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime birthDate)
    {
        DateTime gigasecondMoment;
        gigasecondMoment = birthDate.AddSeconds(1000000000);
        //To view gigasecond birthdate : gigasecondMoment.ToLongDateString()
        return gigasecondMoment;
    }
}