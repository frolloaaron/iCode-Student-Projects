namespace ArcadeAppZoe;
using Models;

public partial class Inventory : ContentPage
{
	public Inventory()
	{
		InitializeComponent();

		Users user = App.UserRepo.GetUser(App.LoggedInUser);

        PalkiaLabel.Text = $"Palkia: {user.Palkia}";
        GroudonLabel.Text = $"Groudon: {user.Groudon}";
        DragoniteLabel.Text = $"Dragonite: {user.Dragonite}";
        Galarian_zapdosLabel.Text = $"Galarian Zapdos: {user.Galarian_zapdos}";
        GardevoirLabel.Text = $"Gardevoir: {user.Gardevoir}";
        RaichuLabel.Text = $"Raichu: {user.Raichu}";
        VenusaurLabel.Text = $"Venusaur: {user.Venusaur}";
        DarkraiLabel.Text = $"Darkrai: {user.Darkrai}";

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        PalkiaLabel.Text = $"Palkia: 0";
        GroudonLabel.Text = $"Groudon: 0";
        DragoniteLabel.Text = $"Dragonite: 0";
        Galarian_zapdosLabel.Text = $"Galarian Zapdos: 0";
        GardevoirLabel.Text = $"Gardevoir: 0";
        RaichuLabel.Text = $"Raichu: 0";
        VenusaurLabel.Text = $"Venusaur: 0";
        DarkraiLabel.Text = $"Darkrai: 0";

        App.UserRepo.Reset_Cards(App.LoggedInUser);
    }
}