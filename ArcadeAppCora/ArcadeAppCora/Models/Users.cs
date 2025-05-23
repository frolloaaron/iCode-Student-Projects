using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Windows.System;

namespace ArcadeAppCora.Models;

[Table("users")]
public class Users
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(250), Unique]
    public string Username { get; set; }

    [MaxLength(250), Unique]
    public string Password { get; set; }

    public int Blastoise { get; set; }
    public int Charizard { get; set; }
    public int Gyarados { get; set; }
    public int Lapras { get; set; }
    public int Lunala { get; set; }
    public int Mewtwo { get; set; }
    public int Pikachu { get; set; }
    public int Psyduck { get; set; }

    public Users() 
    {
        Blastoise = 0;
        Charizard = 0;
        Gyarados = 0;
        Lapras = 0;
        Lunala = 0;
        Mewtwo = 0;
        Pikachu = 0;
        Psyduck = 0;
    }

}
