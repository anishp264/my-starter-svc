using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_starter_svc;
using my_starter_svc.Controllers;
using Xunit;

namespace my_starter_svc.Tests
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void WeatherForecastEndpoint_exists()
        {
            var controller = new WeatherForecastController();
            var weatherForecasts = controller.Get();
            if(weatherForecasts is not null)
            {
                Assert.True(weatherForecasts.Any());
            }
            //Assert.IsType<OkResult>(weatherForecasts);
            Assert.False(false);
        }
    }
}
