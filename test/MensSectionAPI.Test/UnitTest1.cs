namespace MensSectionAPI.Test;
using MensSectionAPI.Controllers;

public class UnitTest1
{
    WeatherForeCastController ctrl = new WeatherForeCastController();

    [Fact]
    public void GetWeather()
    {
        var lst = ctrl.Get();
        Assert.True(lst.Count > 0);

    }
}