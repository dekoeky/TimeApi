namespace TimeApi.Functionality;

public class HardcodedTimeProvider(DateTimeOffset t) : TimeProvider
{
    public static HardcodedTimeProvider FromTime(DateTime dateTime)
    {
        if (dateTime.Kind == DateTimeKind.Unspecified)
            throw new ArgumentException($"{nameof(dateTime)} kind should be specified", nameof(dateTime));

        return new HardcodedTimeProvider(new DateTimeOffset(dateTime));
    }

    public override DateTimeOffset GetUtcNow() => t.UtcDateTime;
    public override long GetTimestamp() => t.Ticks;
}