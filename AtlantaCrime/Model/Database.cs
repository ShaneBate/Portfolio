using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using Dapper;

namespace AtlantaCrime.Model
{
    public class Database
    {
        const string DB_FILE = "crime_atlanta.db";

        static string MAPPED_DATA;
        static string CONNECTION_STRING;

        static Database()
        {
            MAPPED_DATA = HttpContext.Current.Server.MapPath("~/App_Data/");
            CONNECTION_STRING = $"Data Source={MAPPED_DATA + DB_FILE}";
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(CONNECTION_STRING);
        }
        
    }
}