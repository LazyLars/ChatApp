using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.SQLite;

namespace ChatApp
{
    class DataBaseSQLite
    {
        //Member
        public string connectionString;
        public SQLiteConnection connection;

        //Methoden
        public DataBaseSQLite(string conString)
        {
            connectionString = conString;
        }
        public override bool Open()
        {
            bool retVal = false;
            if (connectionString.Length > 0)
            {
                connection = new SQLiteConnection(connectionString);
                if (connection != null)
                {
                    connection.Open();
                    retVal = true;
                }
            }
            return retVal;
        }
        public void Close()
        {
            connection.Close();
        }
    }
}
