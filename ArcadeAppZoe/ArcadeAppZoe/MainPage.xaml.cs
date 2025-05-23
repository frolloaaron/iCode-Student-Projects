namespace ArcadeAppZoe
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
            ImageButton2.BackgroundColor = Colors.Lavender;
            await Shell.Current.GoToAsync("storybook_home");
        }

        private async void platformer_button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("platform_home");
        }

        private async void Clicker_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ghost_clicker");
        }

        private async void Pokemon_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("pokemon_cards");
        }

        private async void Weather_Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("weather_app");
        }

        async private void TicTacToe_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("tictactoe");

        }

        private async void Checkers_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("checkers");
        }

    }

}
