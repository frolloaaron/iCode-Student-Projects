namespace ArcadeAppCora
{
     public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Antebellum_Clicked(object sender, EventArgs e)
        {
            Antebellum.BackgroundColor = Colors.Lavender;
        }

        private async void ImageButton2_Clicked(object sender, EventArgs e)
        {
            ImageButton2.BackgroundColor = Colors.Red;
            await Shell.Current.GoToAsync("storybook_home");
        }

        private async void PlatformButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("platform_home");
        }

        private async void Clicker_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("clicker_game");
        }

        private async void Pokemon_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("pokemon_cards");
        }

        private async void WeatherButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("weather");
        }

        private async void TicTacToe_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Tic_Tac_Toe");
        }

        private async void Checkers_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Checkers");
        }
    }

}
