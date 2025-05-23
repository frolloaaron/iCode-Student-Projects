namespace ArcadeAppZoe
{
    public partial class App : Application
    {
        public static UsersRepository UserRepo { get; set; }

        public static string LoggedInUser;

        public App(UsersRepository repo)
        {
            InitializeComponent();

            MainPage = new AppShell();

            UserRepo = repo;

            LoggedInUser = "";
        }
    }
}
