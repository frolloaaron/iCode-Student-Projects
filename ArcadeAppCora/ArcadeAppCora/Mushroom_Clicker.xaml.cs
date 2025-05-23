using System.Reflection.Metadata;

namespace ArcadeAppCora;

public partial class Mushroom_Clicker : ContentPage
{
	public Mushroom_Clicker()
	{
		InitializeComponent();
		Updatemushrooms();
	}

	double mushrooms = 0;
	double total_mps = 0;

	Upgrade Fireball = new Upgrade("Fireball", "", 0, 20, 0.1);
    Upgrade Cat = new Upgrade("Cat", "", 0, 70, 1);
    Upgrade Mouse = new Upgrade("Mouse", "", 0, 100, 2);
    Upgrade MarioMushroom = new Upgrade("MarioMushroom", "", 0, 250, 5);
    Upgrade MarioShoes = new Upgrade("MarioShoes", "", 0, 375, 10);
    async void Updatemushrooms()
	{
		var gameTimer = new PeriodicTimer(TimeSpan.FromSeconds(1));
		while (await gameTimer.WaitForNextTickAsync())
		{
			mushrooms += total_mps;
			updateCounter();
		}
	}


	private void Mushroom_Clicked(object sender, EventArgs e)
	{
		mushrooms++;
		updateCounter();
	}

	public class Upgrade
	{
		public string name;
		public string imageSourse;
		public int upgradeCount;
		public int cost;
		public double mushrooms_per_second;

		public Upgrade(string n, string i, int u, int c, double cps)
		{
			name = n;
			imageSourse = i;
			upgradeCount = u;
			cost = c;
			mushrooms_per_second = cps;
		}
	}


	public void updateCounter()
	{
		Mushroom_Counter.Text = "Mushroom: " + Math.Floor(mushrooms).ToString();
	}

	private void FireballButton_Clicked(object sender, EventArgs e)
	{
		if (mushrooms >= Fireball.cost)
		{
			mushrooms -= Fireball.cost;
			Fireball.upgradeCount += 1;
			Fireball.cost = (int)Math.Floor((Fireball.cost * 1.1));
			total_mps += Fireball.mushrooms_per_second;
			updateCounter();
			FireballLabel.Text = $"Owned: {Fireball.upgradeCount}";
			FireballButton.Text = $"Fireball for {Fireball.cost} Mushrooms";
        }
	}

    private void CatButton_Clicked(object sender, EventArgs e)
    {
        if (mushrooms >= Cat.cost)
        {
            mushrooms -= Cat.cost;
            Cat.upgradeCount += 1;
            Cat.cost = (int)Math.Floor((Cat.cost * 1.1));
            total_mps += Cat.mushrooms_per_second;
            updateCounter();
            CatLabel.Text = $"Owned: {Cat.upgradeCount}";
            CatButton.Text = $"Cat for {Cat.cost} Mushrooms";
        }
    }
    private void MouseButton_Clicked(object sender, EventArgs e)
    {
        if (mushrooms >= Cat.cost)
        {
            mushrooms -= Mouse.cost;
            Mouse.upgradeCount += 1;
            Mouse.cost = (int)Math.Floor((Mouse.cost * 1.1));
            total_mps += Mouse.mushrooms_per_second;
            updateCounter();
            MouseLabel.Text = $"Owned: {Mouse.upgradeCount}";
            MouseButton.Text = $"Mouse for {Mouse.cost} Mushrooms";
        }
    }

    private void MarioMushroomButton_Clicked(object sender, EventArgs e)
    {
        if (mushrooms >= MarioMushroom.cost)
        {
            mushrooms -= MarioMushroom.cost;
            MarioMushroom.upgradeCount += 1;
            MarioMushroom.cost = (int)Math.Floor((MarioMushroom.cost * 1.1));
            total_mps += MarioMushroom.mushrooms_per_second;
            updateCounter();
            MarioMushroomLabel.Text = $"Owned: {MarioMushroom.upgradeCount}";
            MarioMushroomButton.Text = $"Mario Mushroom for {MarioMushroom.cost} Mushrooms";
        }
    }

    private void MarioShoesButton_Clicked(object sender, EventArgs e)
    {
        if (mushrooms >= MarioShoes.cost)
        {
            mushrooms -= MarioShoes.cost;
            MarioShoes.upgradeCount += 1;
            MarioShoes.cost = (int)Math.Floor((MarioMushroom.cost * 1.1));
            total_mps += MarioShoes.mushrooms_per_second;
            updateCounter();
            MarioShoesLabel.Text = $"Owned: {MarioShoes.upgradeCount}";
            MarioShoesButton.Text = $"Mario Mushroom for {MarioShoes.cost} Mushrooms";
        }
    }
}
