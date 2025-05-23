namespace ArcadeAppZoe;

public partial class Ghost_Clicker_Game : ContentPage
{
	public Ghost_Clicker_Game()
	{
		InitializeComponent();
		UpdateGhost();
	}
	double ghost = 0;
	double total_gps = 0;

	Upgrade Vacuum = new Upgrade("Vacuum", "", 0, 100, 1);
    Upgrade Radar = new Upgrade("Radar", "", 0, 500, 5);
    Upgrade Cleaner = new Upgrade("Cleaner", "", 0, 750, 75);
    Upgrade Gloves = new Upgrade("Gloves", "", 0, 1000, 100);
    Upgrade Suit = new Upgrade("Suit", "", 0, 1500, 150);
    async void UpdateGhost()
	{
		var gameTimer = new PeriodicTimer(TimeSpan.FromSeconds(0.1));
		while (await gameTimer.WaitForNextTickAsync())
		{
			ghost += total_gps/10;
			updateCounter();
		}
	}

	private void Bartholomew_Clicked(object sender, EventArgs e)
	{
		ghost++;
		updateCounter();
	}

	public class Upgrade
	{
		public string name;
		public string imagesource;
		public int upgradeCount;
		public int cost;
		public double ghostpersecond;

		public Upgrade(string n, string i, int u, int c, double cps)
		{
			name = n;
			imagesource = i;
			upgradeCount = u;
			cost = c;
			ghostpersecond = cps;
		}
	}

	public void updateCounter()
	{
        GhostCounter.Text = "ghost: " + Math.Floor(ghost).ToString();
    }

    private void VacuumButton_Clicked(object sender, EventArgs e)
    {
		if (ghost >= Vacuum.cost)
		{
			ghost -= Vacuum.cost;
			Vacuum.upgradeCount += 1;
			Vacuum.cost = (int)Math.Floor((Vacuum.cost * 1.15));
			total_gps += Vacuum.ghostpersecond;
			updateCounter();
			VacuumLabel.Text = $"Owned {Vacuum.upgradeCount}";
            VacuumButton.Text = $"Vacuum | {Vacuum.cost} ghosts";
        }
    }
    private void RadarButton_Clicked(object sender, EventArgs e)
    {
        if (ghost >= Radar.cost)
        {
            ghost -= Radar.cost;
            Radar.upgradeCount += 1;
            Radar.cost = (int)Math.Floor((Radar.cost * 1.15));
            total_gps += Radar.ghostpersecond;
            updateCounter();
            RadarLabel.Text = $"Owned {Radar.upgradeCount}";
            RadarButton.Text = $"Radar | {Radar.cost} ghosts";
        }
    }
    private void CleanerButton_Clicked(object sender, EventArgs e)
    {
        if (ghost >= Cleaner.cost)
        {
            ghost -= Cleaner.cost;
            Cleaner.upgradeCount += 1;
            Cleaner.cost = (int)Math.Floor((Cleaner.cost * 1.15));
            total_gps += Cleaner.ghostpersecond;
            updateCounter();
            CleanerLabel.Text = $"Owned {Cleaner.upgradeCount}";
            CleanerButton.Text = $"Cleaner | {Cleaner.cost} ghosts";
        }
    }
    private void GlovesButton_Clicked(object sender, EventArgs e)
    {
        if (ghost >= Gloves.cost)
        {
            ghost -= Gloves.cost;
            Gloves.upgradeCount += 1;
            Gloves.cost = (int)Math.Floor((Gloves.cost * 1.15));
            total_gps += Gloves.ghostpersecond;
            updateCounter();
            GlovesLabel.Text = $"Owned {Gloves.upgradeCount}";
            GlovesButton.Text = $"Gloves | {Gloves.cost} ghosts";
        }
    }
    private void SuitButton_Clicked(object sender, EventArgs e)
    {
        if (ghost >= Suit.cost)
        {
            ghost -= Suit.cost;
            Suit.upgradeCount += 1;
            Suit.cost = (int)Math.Floor((Suit.cost * 1.15));
            total_gps += Suit.ghostpersecond;
            updateCounter();
            SuitLabel.Text = $"Owned {Suit.upgradeCount}";
            SuitButton.Text = $"Suit | {Suit.cost} ghosts";
        }
    }
}

