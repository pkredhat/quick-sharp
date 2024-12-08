using System.Linq;
using System.Threading.Tasks;
using MyWebApi.Controllers;
using Xunit;

namespace MyWebApi.Tests
{
    public class WeatherForecastControllerTests
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
}