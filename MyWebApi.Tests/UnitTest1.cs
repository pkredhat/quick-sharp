using temp1.Controllers;

namespace MyWebApi.Tests;


public class UnitTest1
{
    [Fact]
        public async Task Get_ReturnsListOfWeatherForecasts()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Any());
        }
}
