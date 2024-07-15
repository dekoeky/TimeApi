namespace TimeApi.Functionality;

public class TimeTools(TimeProvider timeProvider) : ILocalTimeOfDay
{
    public TimeTools() : this(TimeProvider.System)
    {
    }

    public TimeOnly GetLocalTimeOfDay() => TimeOnly.FromTimeSpan(timeProvider.GetLocalNow().TimeOfDay);
}