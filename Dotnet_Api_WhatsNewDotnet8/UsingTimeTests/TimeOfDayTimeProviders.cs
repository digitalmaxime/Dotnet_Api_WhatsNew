namespace UsingTimeTests;

public class NightTimeProvider: TimeProvider
{
    public override DateTimeOffset GetUtcNow()
    {
        return new DateTimeOffset(2023, 12, 1, 1, 0, 0, TimeSpan.Zero);
    }
}

public class MorningTimeProvider: TimeProvider
{
    public override DateTimeOffset GetUtcNow()
    {
        return new DateTimeOffset(2023, 12, 1, 8, 0, 0, TimeSpan.Zero);
    }
}

public class AfternoonTimeProvider: TimeProvider
{
    public override DateTimeOffset GetUtcNow()
    {
        return new DateTimeOffset(2023, 12, 1, 13, 0, 0, TimeSpan.Zero);
    }
}