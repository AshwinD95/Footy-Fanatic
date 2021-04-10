using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using Dapper;
using LeagueTable.Models;

namespace LeagueTable.Data
{
    public class DBDataAccess
    {
        public static List<Table> GetStandings ()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString(), true))
            {
                //Table table = connection.QueryFirstOrDefault<Track>();
                var tableList = new List<Table>();
                var query = "SELECT * FROM EPL_Table";
                tableList = connection.Query<Table>(query).ToList();
                return tableList;
            }
        }

        private static string LoadConnectionString (string id = "Default")
        {
            id = "EPLDB";
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}