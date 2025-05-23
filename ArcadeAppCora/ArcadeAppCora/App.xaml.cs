namespace ArcadeAppCora
{
    public partial class App : Application
    {
        public static UsersRep UserRepo { get; set; }

        public static string LoggedInUser;
        public App(UsersRep repo)
        {
            InitializeComponent();

            MainPage = new AppShell();

            UserRepo = repo;

            LoggedInUser = "";
        }
    }
}
