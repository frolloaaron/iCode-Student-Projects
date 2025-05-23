namespace ArcadeAppCora;
using ArcadeAppCora.Models;
public partial class Weather : ContentPage
{
	public Weather()
	{
		InitializeComponent();
		BindingContext = new WeatherInfo();
	}

	private void WeatherButton_Clicked(object sender, EventArgs e)
	{

	}
}