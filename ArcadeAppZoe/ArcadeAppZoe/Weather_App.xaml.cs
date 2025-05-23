namespace ArcadeAppZoe;
using ArcadeAppZoe.Models;
public partial class Weather_App : ContentPage
{
	public Weather_App()
	{
		InitializeComponent();
		BindingContext = new WeatherInfo();
	}

    private void WeatherButton_Clicked(object sender, EventArgs e)
    {

    }
}