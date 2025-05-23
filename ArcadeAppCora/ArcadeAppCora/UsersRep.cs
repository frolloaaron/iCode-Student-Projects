using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ArcadeAppCora.Models;

namespace ArcadeAppCora;

public class UsersRep
{
    string dbPath;
    private SQLiteConnection conn;

    public UsersRep(string db)
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
            result = conn.Insert(new Users { Username = username, Password = password });
        }
    }

    public Users GetUser(string username)
    {
        Init();
        return conn.Table<Users>().Where(u => u.Username == username).FirstOrDefault(); 
    }


    public void UpdateUserPokemonCard(string username, string pokemonname)
    {
        Init();

        if (username != null) 
        {
            Users user = conn.Table<Users>().Where(u => u.Username == username).FirstOrDefault();
            if (user != null)  
            {
                var column = typeof(Users).GetProperty(pokemonname);
                if (column != null && column.PropertyType == typeof(int)) 
                {
                    int val = (int)column.GetValue(user);
                    column.SetValue(user, val + 1);
                    conn.Update(user);
                }
            }

        }

    }

}
        

    


