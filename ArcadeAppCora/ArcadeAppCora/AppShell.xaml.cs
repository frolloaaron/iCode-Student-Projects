namespace ArcadeAppCora
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("main", typeof(MainPage));
            Routing.RegisterRoute("storybook_home", typeof(Storybook_Homepage));
            Routing.RegisterRoute("storybook_main", typeof(Storybook_Mainpage));
            Routing.RegisterRoute("platform_home", typeof(Platform_Homepage));
            Routing.RegisterRoute("platform_main", typeof(Platform_Mainpage));
            Routing.RegisterRoute("clicker_game", typeof(Mushroom_Clicker));
            Routing.RegisterRoute("pokemon_cards", typeof(Pokemon_Cards));
            Routing.RegisterRoute("signup", typeof(SignUp));
            Routing.RegisterRoute("inventory", typeof(Inventory));
            Routing.RegisterRoute("weather", typeof(Weather));
            Routing.RegisterRoute("Tic_Tac_Toe", typeof(TicTacToe));
            Routing.RegisterRoute("Checkers", typeof(Checkers));
        }
    }
}
