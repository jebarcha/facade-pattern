using Facade.Entities;
using Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IWeatherFacade
    {
        WeatherFacadeResults GetTempInCity(string zipCode);
    }

    public class WeatherFacade : IWeatherFacade
    {
        private readonly ConverterService _convertService;
        private readonly GeoLookupService _geoLookupService;
        private readonly WeatherService _weatherService;
        public WeatherFacade() :
            this(new ConverterService(), new GeoLookupService(), new WeatherService())
        {

        }
        public WeatherFacade(ConverterService converterService, 
            GeoLookupService geoLookUpService,
            WeatherService watherService)
        {
            _convertService = converterService;
            _geoLookupService = geoLookUpService;
            _weatherService = watherService;
        }
        public WeatherFacadeResults GetTempInCity(string zipCode)
        {
            City city = _geoLookupService.GetCityForZipCode(zipCode);
            State state = _geoLookupService.GetStateForZipCode(zipCode);
            int tempF = _weatherService.GetTempFahrenheit(city, state);
            int tempC = _convertService.ConvertFahrenheitToCelcious(tempF);

            var results = new WeatherFacadeResults
            {
                City = city,
                State = state,
                Fahrenheith = tempF,
                Celsius = tempC
            };

            return results;
        }
    }

}
