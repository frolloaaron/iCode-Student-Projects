namespace ArcadeAppCora;
using Models;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
		//App.UserRepo.AddUser("dev", "abc");
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

    private async void ToSignButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("signup");

    }
}