using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Plugin_Tasks
{
    public class Persistence
    {

        //Guarda aqui o nome para inserção no SQLite.
        private string createTableQuery = @"CREATE TABLE IF NOT EXISTS Tasks (
                          ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          Title NVARCHAR(2048)  NOT NULL,
                          Description VARCHAR(2048)  NULL,
                          DesireDate VARCHAR(2048)  NULL,
                          CloseDate VARCHAR(2048)  NULL,
                          CurrentStatus VARCHAR(2048)  NULL
                          )";
       

        public SQLiteConnection Connection;

        public Persistence()
        {

            try
            {
                if (!File.Exists("JarvisEducatorsDb1.db"))
                {
                    SQLiteConnection.CreateFile("JarvisEducatorsDb1.db");
                }

                Connection = new System.Data.SQLite.SQLiteConnection("data source=JarvisEducatorsDb1.db");

                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(Connection))
                {
                    Connection.Open();
                    com.CommandText = createTableQuery;
                    com.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
