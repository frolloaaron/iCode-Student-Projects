using Microsoft.Maui.ApplicationModel;
namespace ArcadeAppCora;

public partial class Platform_Mainpage : ContentPage
{
    private bool gridReady;
    private Player user;
    private Platform[] platformList = new Platform[4];
    public int level = 1;
    public int score = 0;
    public Label scoreLabel;
    public Label levelLabel;
    public double difficulty = 1000;
    public Platform_Mainpage()
	{
		InitializeComponent();
    }

    private void Start_Button_Clicked(object sender, EventArgs e)
    {
        Fill_Grid(true);
        gridReady = true;
        Start_Button.IsEnabled = false;
    }
    private void Reset_Button_Clicked(object sender, EventArgs e)
    {
        gameGrid.Clear();
        Start_Button.IsEnabled = true;
        gridReady = true;
        score = 0;
        level = 1;
        Start_Button.Text = "Play!";
    }

    public async void Fill_Grid(bool start)
    {
        if (start) {
            int rows = 5;
            int columns = 5;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    StackLayout unit = new StackLayout() { ZIndex = 0 };
                    gameGrid.Add(unit, j, i);
                    //Create platforms on the right side
                    if (i < 4 && j == 0)
                    {
                        BoxView newRect = new BoxView()
                        {
                            HeightRequest = 20,
                            Color = Colors.Red,
                            VerticalOptions = LayoutOptions.End,
                            CornerRadius = 10,
                            ZIndex = 1
                        };
                        Platform newPlat = new Platform(newRect, i, j);
                        platformList[i] = newPlat;
                        gameGrid.Add(newRect, newPlat.col, newPlat.row);
                    }
                }
            }

            scoreLabel = new Label()
            {
                Text = "Score: " + score,
                FontSize = 30,
                ZIndex = 1,
                Margin = new Thickness(10),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };

            levelLabel = new Label()
            {
                Text = "Level: " + level,
                FontSize = 30,
                ZIndex = 1,
                Margin = new Thickness(10),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };

            gameGrid.Add(scoreLabel, 0, 4);
            gameGrid.Add(levelLabel, 4, 4);
            user = Create_User();
            gameGrid.Add(user.image, user.col, user.row);
        }
        else
        {
            user.row = 4;
            gameGrid.SetRow(user.image, user.row);
            foreach (Platform plat in platformList)
            {
                plat.col = 0;
                gameGrid.SetColumn(plat.rect, plat.col);
            }

        }

        foreach(Platform plat in platformList)
        {
            plat.isMovingRight = true;
            plat.Oscillate(gameGrid, this);
        }
    }

    private Player Create_User()
    {
        Image userIcon = new Image { Source = "cora.png", ZIndex = 1 };
        user = new Player(userIcon, 4, 2);
        return user;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (gridReady)
        {
            gridReady = user.Junp(gameGrid, platformList, gridReady, this);
            if (gridReady == false) 
            {
                Start_Button.Text = "Game Over!";
            }
        }
    }
}


public class Player
{
    public Image image;
    public int row;
    public int col;

    public Player(Image i, int r, int c) 
    {
       image = i;
        row = r;
        col = c;
       
    }
    public bool Junp(Grid g, Platform[] list, bool con, Platform_Mainpage page)
    {
        if(this.row == 0)
        {
            page.difficulty = page.difficulty * 0.9;
            page.level++;
            page.levelLabel.Text = "Level: " + page.level;
            page.Fill_Grid(false);
        }
        else
        {
            g.SetRow(this.image, this.row -= 1);
            Platform platform = list[this.row];
            if (this.col == platform.col && this.row == platform.row)
            {
                page.score++;
                page.scoreLabel.Text = "Score: " + page.score;
                platform.StopMovement();
            }
            else
            {
                con = false;
            }
        }   return con;
         
        
        
       
    }
    

}

public class Platform
{
    public BoxView rect;
    public int row;
    public int col;
    public bool isMovingLeft;
    public bool isMovingRight;
    public Platform(BoxView rectangle, int r, int c)
    {
        rect = rectangle;
        row = r;
        col = c;
        isMovingLeft = false;
        isMovingRight = true;
    }

    public void StopMovement()
    {
        isMovingLeft = false;   
        isMovingRight = false;
    }

    async public void Oscillate(Grid g, Platform_Mainpage page)
    {
        int boundaryLeft = 0;
        int boundaryRight = 4;
        var rand = new Random();
        await Task.Delay(rand.Next(1000));
        MoveRight(g, boundaryLeft, boundaryRight, page);
    }



    async public void MoveRight(Grid g, int limitLeft, int limitRight, Platform_Mainpage page)
    {
        while(col < limitRight && isMovingRight)
        {
            col++;
            g.SetColumn(rect, col);
            await Task.Delay((int)page.difficulty);
        }
        if (isMovingRight)
        {
            isMovingRight = false;
            isMovingLeft = true;
            MoveLeft(g, limitLeft, limitRight, page);
        }
    }

    async public void MoveLeft(Grid g, int limitLeft, int limitRight, Platform_Mainpage page)
    {
        while (col > limitLeft && isMovingLeft)
        {
            col--;
            g.SetColumn(rect, col);
            await Task.Delay((int)page.difficulty);
        }
        if (isMovingLeft)
        {
            isMovingRight = true;
            isMovingLeft = false;
            MoveRight(g, limitLeft, limitRight, page);
        }
    }

}   



