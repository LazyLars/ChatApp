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
        public List<List<string>> ResultList;
        public int Rows;
        public int Cols; 

        //Methoden
        public DataBaseSQLite()
        {
            ResultList = new List<List<string>>();
        }
        public DataBaseSQLite(string conString)
        {
            ResultList = new List<List<string>>();
            connectionString = conString;
        }
        public bool Open()
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
        public bool TableExists(string strTableName)
        {
            String strCommand;
            strCommand = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' and name='"+strTableName+"'";
 
            Execute(strCommand);

            if (ResultList[0][0] == "1")
                return true;
            else
                return false;
        }
        public bool Execute(string strCommand)
        {
            bool retVal = false;

            SQLiteCommand cmdSQLite = connection.CreateCommand();
            cmdSQLite.CommandText = strCommand;
            SQLiteDataReader reader = cmdSQLite.ExecuteReader();

            ResultList.Clear();
            Rows = 0;
            Cols = 0;
            while (reader.Read())
            {
                List<string> rowList = new List<string>();
                int pos = 0;
                int curCols = 0;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    rowList.Add(reader[pos++].ToString());
                    curCols++;
                }
                Cols = Math.Max(curCols, Cols);

                ResultList.Add(rowList);
                Rows++;
            }

            // Beenden des Readers und Freigabe aller Ressourcen.
            reader.Close();
            reader.Dispose();
            cmdSQLite.Dispose();
            return retVal;
        }
        public bool InsertData(string Tablename, string saveCol1 = "NULL", string saveCol2 = "NULL", string saveCol3 = "NULL", string saveCol4 = "NULL", string saveCol5 = "NULL")
        {
            bool retVal = false;

            return retVal;
        }
    }
}
