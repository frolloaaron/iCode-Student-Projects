using ArcadeAppCora.Models;

namespace ArcadeAppCora;

public partial class TicTacToe : ContentPage
{
    public BoardSquare sq0;
    public BoardSquare sq1;
    public BoardSquare sq2;
    public BoardSquare sq3;
    public BoardSquare sq4;
    public BoardSquare sq5;
    public BoardSquare sq6;
    public BoardSquare sq7;
    public BoardSquare sq8;
    List<BoardSquare> squares = new List<BoardSquare>();
    public int currentTurn = 0;

	public TicTacToe()
	{
		InitializeComponent();
        InitGame();
    }
    public void InitGame()
    {
        squares.Clear();
        Reset_Button.IsVisible = false;

        sq0 = new BoardSquare(Square0, 0);
        sq1 = new BoardSquare(Square1, 1);
        sq2 = new BoardSquare(Square2, 2);
        sq3 = new BoardSquare(Square3, 3);
        sq4 = new BoardSquare(Square4, 4);
        sq5 = new BoardSquare(Square5, 5);
        sq6 = new BoardSquare(Square6, 6);
        sq7 = new BoardSquare(Square7, 7);
        sq8 = new BoardSquare(Square8, 8);
        squares.Add(sq0);
        squares.Add(sq1);
        squares.Add(sq2);
        squares.Add(sq3);
        squares.Add(sq4);
        squares.Add(sq5);
        squares.Add(sq6);
        squares.Add(sq7);
        squares.Add(sq8);
    }
    private void Square0_Clicked(object sender, EventArgs e)
    {
        sq0.PlayerTurn();
        currentTurn++;
        squares.Remove(sq0);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    private void Square1_Clicked(object sender, EventArgs e)
    {
        sq1.PlayerTurn();
        currentTurn++;
        squares.Remove(sq1);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    private void Square2_Clicked(object sender, EventArgs e)
    {
        sq2.PlayerTurn();
        currentTurn++;
        squares.Remove(sq2);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    private void Square3_Clicked(object sender, EventArgs e)
    {
        sq3.PlayerTurn();
        currentTurn++;
        squares.Remove(sq3);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    private void Square4_Clicked(object sender, EventArgs e)
    {
        sq4.PlayerTurn();
        currentTurn++;
        squares.Remove(sq4);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    private void Square5_Clicked(object sender, EventArgs e)
    {
        sq5.PlayerTurn();
        currentTurn++;
        squares.Remove(sq5);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    private void Square6_Clicked(object sender, EventArgs e)
    {
        sq6.PlayerTurn();
        currentTurn++;
        squares.Remove(sq6);
        CheckForWin();
        AiPick();
        CheckForWin();

    }

    private void Square7_Clicked(object sender, EventArgs e)
    {
        sq7.PlayerTurn();
        currentTurn++;
        squares.Remove(sq7);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    private void Square8_Clicked(object sender, EventArgs e)
    {
        sq8.PlayerTurn();
        currentTurn++;
        squares.Remove(sq8);
        CheckForWin();
        AiPick();
        CheckForWin();
    }

    public void AiPick()
    {
        foreach (var boardsquare in squares)
        {
            if (boardsquare.squareNumber == 0)
            {
                if (sq1.isX && sq2.isX ||
                   sq1.isO && sq2.isO ||
                   sq3.isX && sq6.isX ||
                   sq3.isO && sq6.isO ||
                   sq4.isX && sq8.isX ||
                   sq4.isO && sq8.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 2)
            {
                if (sq1.isX && sq0.isX ||
                   sq1.isO && sq0.isO ||
                   sq5.isX && sq8.isX ||
                   sq5.isO && sq8.isO ||
                   sq4.isX && sq6.isX ||
                   sq4.isO && sq6.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 6)
            {
                if (sq3.isX && sq0.isX ||
                   sq3.isO && sq0.isO ||
                   sq7.isX && sq8.isX ||
                   sq7.isO && sq8.isO ||
                   sq4.isX && sq2.isX ||
                   sq4.isO && sq2.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 8)
            {
                if (sq4.isX && sq0.isX ||
                   sq4.isO && sq0.isO ||
                   sq5.isX && sq2.isX ||
                   sq5.isO && sq2.isO ||
                   sq7.isX && sq6.isX ||
                   sq7.isO && sq6.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 1)
            {
                if (sq2.isX && sq0.isX ||
                   sq2.isO && sq0.isO ||
                   sq4.isX && sq7.isX ||
                   sq4.isO && sq7.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 3)
            {
                if (sq6.isX && sq0.isX ||
                   sq6.isO && sq0.isO ||
                   sq4.isX && sq5.isX ||
                   sq4.isO && sq5.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 5)
            {
                if (sq2.isX && sq8.isX ||
                   sq2.isO && sq8.isO ||
                   sq4.isX && sq3.isX ||
                   sq4.isO && sq3.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 7)
            {
                if (sq6.isX && sq8.isX ||
                   sq6.isO && sq8.isO ||
                   sq4.isX && sq1.isX ||
                   sq4.isO && sq1.isO)
                {
                    boardsquare.AITurn();
                    squares.Remove(boardsquare);
                    return;
                }
            }
            if (boardsquare.squareNumber == 4)
            {
                boardsquare.AITurn();
                squares.Remove(boardsquare);
                return;
            }
        }

        if (squares.Count > 0)
        {
            var rand = new Random();
            int loc = rand.Next(squares.Count);
            squares[loc].AITurn();
            squares.Remove(squares[loc]);
        }
    }


    public void CheckForWin()
    {
        if (sq0.isX && sq1.isX && sq2.isX ||
           sq3.isX && sq4.isX && sq5.isX ||
           sq6.isX && sq7.isX && sq8.isX ||
           sq0.isX && sq3.isX && sq6.isX ||
           sq1.isX && sq4.isX && sq7.isX ||
           sq2.isX && sq5.isX && sq8.isX ||
           sq0.isX && sq4.isX && sq8.isX ||
           sq2.isX && sq4.isX && sq6.isX

           )
        {
            GameOver("user");
        }

        else if (sq0.isO && sq1.isO && sq2.isO ||
          sq3.isO && sq4.isO && sq5.isO ||
          sq6.isO && sq7.isO && sq8.isO ||
          sq0.isO && sq3.isO && sq6.isO ||
          sq1.isO && sq4.isO && sq7.isO ||
          sq2.isO && sq5.isO && sq8.isO ||
          sq0.isO && sq4.isO && sq8.isO ||
          sq2.isO && sq4.isO && sq6.isO
          )
        {
            GameOver("ai");
        }

        else if (squares.Count == 0)
        {
            GameOver("tie");
        }
    }

    public void GameOver(string id)
    {
        if (squares.Count > 0)
        {
            foreach (var boardSquare in squares)
            {
                boardSquare.square.IsEnabled = false;

            }
        }

        squares.Clear();

        if (id == "user")
        {
            Winner_Label.Text = "The player has won!";
        }
        if (id == "ai")
        {
            Winner_Label.Text = "The ai has won!";
        }
        if (id == "tie")
        {
            Winner_Label.Text = "It's a draw!";
        }
        Reset_Button.IsVisible = true;

    }

    private void Reset_Button_Clicked(object sender, EventArgs e)
    {
        Winner_Label.Text = "";
        InitGame();
        foreach (var boardSquare in squares)
        {
            boardSquare.square.Source = "";
            boardSquare.square.IsEnabled = true;
        }
    }
}
