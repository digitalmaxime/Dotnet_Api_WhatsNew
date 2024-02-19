using Microsoft.Extensions.Time.Testing;

namespace UsingTimeTests;
using UsingTime;

public class UnitTest1
{
    private TimeOfDayService _timeOfDayService;
    // private TimeProvider _timeProvider;
    private readonly FakeTimeProvider _fakeTimeProvider;

    public UnitTest1()
    {
        _fakeTimeProvider = new FakeTimeProvider();
    }
    
    [Fact]
    public void TimeOdFay_ShouldReturnMorning_WhenItsMorning()
    {
        // _timeProvider = new MorningTimeProvider();
        _fakeTimeProvider.SetUtcNow(new DateTime(2023, 12, 1, 8, 0, 0));
        _timeOfDayService = new TimeOfDayService(_fakeTimeProvider);

        var v = _timeOfDayService.GetTimeOfDay();
        Assert.Equal("Morning", v);
    }
}