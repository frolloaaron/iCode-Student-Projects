using ArcadeAppZoe.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeAppZoe.Models;

internal partial class WeatherInfo : ObservableObject
{
    private readonly WeatherApiService weatherApiService;

    public WeatherInfo()
    {
        weatherApiService = new WeatherApiService();
    }


    [ObservableProperty]
    private string city;

    [ObservableProperty]
    private string state_country;

    [ObservableProperty]
    private string temperature;

    [ObservableProperty]
    private string weather_icon;

    [ObservableProperty]
    private string wind_speed;

    [ObservableProperty]
    private string observation_time;

    [ObservableProperty]
    private string feelslike;

    [RelayCommand]
    private async Task GetWeatherInfo()
    {
        var weatherApiResponse = await weatherApiService.GetWeatherInformation(City);
        if (weatherApiResponse != null)
        {
            Weather_icon = weatherApiResponse.Current.weather_icons[0];
            Temperature = $"{weatherApiResponse.Current.temperature}°C";
        }    
    }
}
