using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apiboilerplate.DAL.Models;
using Dapper;

namespace apiboilerplate.DAL
{
    public class Repo : IRepo
    {
        public string con_str = "Data Source = " + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "base.sqlite");
        public Repo() { }
        public User GetOne(int Id)
        {
            string req = @"
SELECT *
FROM users
WHERE ID=@Id";
            using (SQLiteConnection db = new SQLiteConnection(con_str))
            {
                return db.QuerySingleOrDefault<User>(req, new { Id });
                // throw exception if multiple rows found
                // return null if no row found
            }
        }
    }
}
