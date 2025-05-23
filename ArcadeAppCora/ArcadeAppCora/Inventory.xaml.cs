namespace ArcadeAppCora;
using Models;
public partial class Inventory : ContentPage
{
	public Inventory()
	{
		InitializeComponent();

		Users user = App.UserRepo.GetUser(App.LoggedInUser);

        BlastoiseLabel.Text = $"Blastoise: {user.Blastoise}";
        CharizardLabel.Text = $"Charizard: {user.Charizard}";
        GyaradosLabel.Text = $"Gyarados: {user.Gyarados}";
        LaprasLabel.Text = $"Lapras: {user.Lapras}";
        LunalaLabel.Text = $"Lunala: {user.Lunala}";
        MewtwoLabel.Text = $"Mewtwo: {user.Mewtwo}";
        PikachuLabel.Text = $"Pikachu: {user.Pikachu}";
        PsyduckLabel.Text = $"Psyduck: {user.Psyduck}";

    }
}