using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeAppCora.Models;

public class BoardSquare
{
    public ImageButton square;
    public int squareNumber;
    public bool isX = false;
    public bool isO = false;
    public string imageSource;

    public BoardSquare(ImageButton ib, int number)
    {
        square = ib;
        squareNumber = number;
    }


    public void PlayerTurn()
    {
        isX = true;
        imageSource = "x_ttt.png";
        square.IsEnabled = false;
        square.Source = imageSource;
    }

    public void AITurn()
    {
        isO = true;
        imageSource = "o_ttt.jpg";
        square.IsEnabled = false;
        square.Source = imageSource;
    }
}
