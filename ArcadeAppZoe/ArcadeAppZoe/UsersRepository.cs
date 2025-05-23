using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ArcadeAppZoe.Models;
using static SQLite.TableMapping;

namespace ArcadeAppZoe;

public class UsersRepository
{
    string dbPath;
    private SQLiteConnection conn;

    List<String> columns = new List<String>()
    {
        "Venusaur",
        "Darkrai",
        "Dragonite",
        "Galarian_zapdos",
        "Gardevoir",
        "Groudon",
        "Palkia",
        "Raichu"
    };

    public UsersRepository(string db)
    {
        dbPath = db;
    }

    private void Init()
    {
        if (conn != null) 
            return;
        conn = new SQLiteConnection(dbPath);
        conn.CreateTable<Users>();
    }

    public void AddUser(string username, string password)
    {
        int result = 0;
        Init();

        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
               result = conn.Insert(new Users {  Username = username, Password = password } );
        }
    }

    public Users GetUser(string username)
    {
        Init();
        return conn.Table<Users>().Where(u => u.Username == username).FirstOrDefault();
    }

    public void UpdateUserPokemon_Cards(string username, string cardname)
    {
        Init();

        if (username != null)
        {
            Users user = conn.Table<Users>().Where(u => u.Username == username).FirstOrDefault();

            if (user != null)
            {
                var column = typeof(Users).GetProperty(cardname);
                if(column != null && column.PropertyType == typeof(int))
                {
                    int val = (int)column.GetValue(user);
                    column.SetValue(user, val + 1);
                    conn.Update(user);
                }
            }
        }
    }

    public void Reset_Cards(string username)
    {
        Init();

        if (username != null)
        {
            Users user = conn.Table<Users>().Where(u => u.Username == username).FirstOrDefault();

            if (user != null)
            {
                for (int i = 0; i<8; i++)
                {
                    var column = typeof(Users).GetProperty(columns[i]);
                    column.SetValue(user, 0);
                    conn.Update(user);
                }
            }
        }
    }
}
