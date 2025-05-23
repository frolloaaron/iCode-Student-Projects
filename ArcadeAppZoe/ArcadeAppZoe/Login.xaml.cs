namespace ArcadeAppZoe;
using Models;
public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
		//App.UserRepo.AddUser("ZOE_CODES!", "P@$$W0RD");
	}

    async private void LoginButton_Clicked(object sender, EventArgs e)
    {
		Users result = App.UserRepo.GetUser(UsernameEntry.Text);

		if (result != null)
		{
            if (UsernameEntry.Text == result.Username && PasswordEntry.Text == result.Password)
            {
                await Shell.Current.GoToAsync("main");
                App.LoggedInUser = result.Username;
            }
        }

    }

    private async void ToSignUpButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("signup");
    }
}