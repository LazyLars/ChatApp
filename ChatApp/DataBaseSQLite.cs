using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ChatApp
{

    //Klasse zum Aufbau, Nutzung und Schließen einer SQLite-DB Verbindung
    //Abgeleitet von der DataBase-Klasse
    class DataBaseSQLite : DataBase
    {
        //Member
        public SQLiteConnection connection;         //Definition eines SQLiteConnection Objektes     


        //Methoden
        
        //Standardkostruktor für erstellung einer ResultList zum Speichern von Abfragen
        public DataBaseSQLite()
        {
            ResultList = new List<List<string>>();          //2 Dimensionale Stringliste 
        }
        //Konstruktor mit einem String zur Übergabe der Pfade der SQLite-DB
        public DataBaseSQLite(string conString)
        {
            ResultList = new List<List<string>>();          //2 Dimensionale Stringliste 
            connectionString = conString;                   //Speicherung des Pfadstrings durch nutzung der Elternklasse
        }
        //Methode der Mutterklasse überschrieben
        //Methode zum öffnen einer DB-Verbindung
        public override bool Open()
        {
            bool retVal = false;                //returnvariable der Methode

            if (connectionString.Length > 0)        //Überprüfung des Connectionsstring ob vorhanden
            {
                connection = new SQLiteConnection(connectionString);        //Zuweisen des Connectionstrings zum jetzt definierten Objekt von SQLiteConnection
                
                if (connection != null)                 //überprüfung des Pfades von connection zur DB
                {
                    connection.Open();                  //öffnen der DB
                    retVal = true;                      //erfolgreiches öffnen der DB setzt return bool true
                }
            }
            return retVal;          //gibt returnvariable der Methode zurück
        }
        //Methode der Mutterklasse überschrieben
        //Methode zum schließen einer Connection zu DB
        public override void Close()
        {
            connection.Close();             //schließt die DB-Connection
        }
        //Methode der Mutterklasse überschrieben
        //Methode zum überprüfen auf existierende Tabelle in der DB
        public override bool TableExists(string strTableName)
        {
            //Standardabfrage auf SQLite-DB ob eine Tabelle mit dem Namen existiert
            String strCommand= "SELECT COUNT(*) FROM sqlite_master WHERE type='table' and name='" + strTableName + "'";
            
            Execute(strCommand);        //Aufruf der Methode zum Ausführen von SQL-Statements

            if (ResultList[0][0] == "1")        //Überprüfung der ResultList auf Ergebnis, wenn Tabelle existiert (muss ==1)
                return true;                    
            else
                return false;
        }
        //Methode der Mutterklasse überschrieben
        //Methode zum Ausführen von SQL-Statements
        public override bool Execute(string strCommand)
        {
            bool retVal = false;                        //Variable zum Return der Methode

            SQLiteCommand cmdSQLite = connection.CreateCommand();       //Objekt für Commandübergabe an DB
            cmdSQLite.CommandText = strCommand;                         //Zuweisung des Commandstrings an die CMD der DB
            SQLiteDataReader reader = cmdSQLite.ExecuteReader();        //Erstellung eines Encoders für DB-Resultate von der CMD

            ResultList.Clear();                 //Leeren der Resultlist
            Rows = 0;                           //Nutzung der Mutterklassenvariable
            Cols = 0;                           //Nutzung der Mutterklassenvariable
            
            while (reader.Read())               //Schleife zum Auslesen des CMD Ergebnisses
            {
                List<string> rowList = new List<string>();      //Liste für Speicherung einer Dimension
                int pos = 0;                                    //x-Positionsvariable
                int curCols = 0;                                //y-Positionsvariable
                
                for (int i = 0; i < reader.FieldCount; i++) //Schleife zum Speichern von Rows
                {
                    rowList.Add(reader[pos++].ToString());      //Hinzufügen der Rows der Position zur Liste
                    curCols++;                                  //Hochsetzen der Position der Cols
                }
                Cols = Math.Max(curCols, Cols);                 //Weiterrechnung der jetzigen Cols um Position x

                ResultList.Add(rowList);                        //Hinzufügend der rowListen zur Resultliste
                Rows++;                             //Hochsetzen der Rows
            }

            // Beenden des Readers und Freigabe aller Ressourcen.
            reader.Close();             //Schließen des CMD
            reader.Dispose();           //Löschen des Cache
            cmdSQLite.Dispose();        //Löschen des Cache
           
            return retVal;          //Return schreiben erfolgreich
        }
        
    }
}
