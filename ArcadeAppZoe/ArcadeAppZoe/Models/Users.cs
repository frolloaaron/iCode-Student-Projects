using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ArcadeAppZoe.Models;

[Table("users")]
public class Users
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(250), Unique]
    public string Username { get; set; }
    [MaxLength(250), Unique]
    public string Password { get; set; }

    public int Raichu { get; set; }
    public int Palkia { get; set; }
    public int Darkrai { get; set; }
    public int Gardevoir { get; set; }
    public int Dragonite { get; set; }
    public int Groudon { get; set; }
    public int Venusaur { get; set; }
    public int Galarian_zapdos { get; set; }

    public Users()
    {
        Raichu = 0;
        Darkrai = 0;
        Palkia = 0;
        Groudon = 0;
        Venusaur = 0;
        Dragonite = 0;
        Galarian_zapdos = 0;
        Gardevoir = 0;
    }

}
