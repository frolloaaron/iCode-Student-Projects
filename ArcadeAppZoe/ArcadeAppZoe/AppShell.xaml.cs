namespace ArcadeAppZoe
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();


            //Routing.RegisterRoute("quiz_home", typeof(Quiz_HomePage));
            //Routing.RegisterRoute("quiz_main", typeof(Quiz_MainPage));


            Routing.RegisterRoute("storybook_home", typeof(Storybook_HomePage));
            Routing.RegisterRoute("storybook_main", typeof(Storybook_MainPage));
            Routing.RegisterRoute("platform_home", typeof(Platform_HomePage));
            Routing.RegisterRoute("platform_main", typeof(Platform_MainPage));
            Routing.RegisterRoute("main", typeof(MainPage));
            Routing.RegisterRoute("ghost_clicker", typeof(Ghost_Clicker_Game));
            Routing.RegisterRoute("pokemon_cards", typeof(Pokemon_Cards));
            Routing.RegisterRoute("signup", typeof(SignUp));
            Routing.RegisterRoute("inventory", typeof(Inventory));
            Routing.RegisterRoute("weather_app", typeof(Weather_App));
            Routing.RegisterRoute("tictactoe", typeof(TicTacToe));
            Routing.RegisterRoute("checkers", typeof(checkers));
        }

    }
}
