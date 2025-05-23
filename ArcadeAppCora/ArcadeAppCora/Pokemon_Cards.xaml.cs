namespace ArcadeAppCora;
using Models;
public partial class Pokemon_Cards : ContentPage
{
    List<string> cards = new List<string>()
    {
        "blastoise.jpg",
        "charizard.jpg",
        "gyarados.jpg",
        "lapras.jpg",
        "lunala.jpg",
        "mewtwo.jpg",
        "pikachu.png",
        "psyduck.jpg"
    };
    List<string> columns = new List<string>()
    {
        "Blastoise",
        "Charizard",
        "Gyarados",
        "Lapras",
        "Lunala",
        "Mewtwo",
        "Pikachu",
        "Psyduck"
    };
    public Pokemon_Cards()
	{
           
		InitializeComponent();
	}

  async private void OpenPackButton_Clicked(object sender, EventArgs e)
    {

        var rand = new Random();
        int rand1 = rand.Next(8);

        rand = new Random();
        int rand2 = rand.Next(8);

        rand = new Random();
        int rand3 = rand.Next(8);

        rand = new Random();
        int rand4 = rand.Next(8);

        String imageSource1 = cards[rand1];
        String column1 = columns[rand1];
        String imageSource2 = cards[rand2];
        String column2 = columns[rand2];
        String imageSource3 = cards[rand3];
        String column3 = columns[rand3];
        String imageSource4 = cards[rand4];
        String column4 = columns[rand4];

        Users loggedInUser = App.UserRepo.GetUser(App.LoggedInUser);

        App.UserRepo.UpdateUserPokemonCard(App.LoggedInUser, column1);
        App.UserRepo.UpdateUserPokemonCard(App.LoggedInUser, column2);
        App.UserRepo.UpdateUserPokemonCard(App.LoggedInUser, column3);
        App.UserRepo.UpdateUserPokemonCard(App.LoggedInUser, column4);

        Card1.Source = imageSource1;
        Card2.Source = imageSource2;
        Card3.Source = imageSource3;
        Card4.Source = imageSource4;

        //OpenPackButton.Text = $"{val1}{val2}{val3}{val4}";

        await TopPack.TranslateTo(TopPack.X - 340, 0, 2000, Easing.Linear);
		await TopPack.FadeTo(0);

        await BottomPack.TranslateTo(0, BottomPack.Y + 300, 2000, Easing.Linear);
        await BottomPack.FadeTo(0);

		await Card1.TranslateTo(Card1.X - 340, 0);
        await Card4.TranslateTo(Card4.X + 490, 0);
        await Card2.TranslateTo(Card2.X - 60, 0);
        await Card3.TranslateTo(Card3.X + 215, 0);
  }

    async private void ViewInventoryButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("inventory");
    }
}