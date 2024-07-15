namespace TimeApi.Functionality.Tests;

/// <summary>
/// <see cref="TimeTools"/> related tests.
/// </summary>
public class TimeToolsTests
{
    [Fact]
    public void GetLocalTimeOfDay()
    {
        //Arrange
        var time = new TimeOnly(12, 31, 14);
        var date = new DateOnly(2024, 07, 15);
        var dateTime = date.ToDateTime(time, DateTimeKind.Local);
        var timeProvider = HardcodedTimeProvider.FromTime(dateTime);
        var timeTools = new TimeTools(timeProvider);

        //Act
        var result = timeTools.GetLocalTimeOfDay();

        //Assert
        Assert.Equal(time, result);
    }
}