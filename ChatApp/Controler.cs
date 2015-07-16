using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ChatApp
{
    class Controller
    {
        //Member
        public View ContrView = new View();
        public Model ContrModel = new Model();
        public DataBase DataBase;



        //Methoden
        public Controller()
        {
            RegisterView(ContrView);

            ContrModel.DelegateModelChange += this.WhenModelChanged;
            ContrModel.DelegateWriteToDatabase += this.WriteinDB;

            DataBase = new DataBaseSQLite("Data Source = DBChatApp.db3");
            DataBase.Open();

            DataBase.Execute("CREATE TABLE IF NOT EXISTS Nachricht(idNachricht string primary key, Zeit datetime, Absender integer, Empfaenger integer, Text Varchar);");
            DataBase.Execute("CREATE TABLE IF NOT EXISTS Person( idPerson string primary key, Name Varchar, IpAdresse varchar, Blockiert bool);");
            DataBase.Execute("CREATE TABLE IF NOT EXISTS User( idUser string primary key, IdPerson string, Passwort varchar, foreign key(IdPerson) references Person(IdPerson));");
            DataBase.Execute("CREATE TABLE IF NOT EXISTS UserHasPerson( IdUser string, IdPerson string,foreign key(IdUser) references User(IdUser),foreign key(IdPerson) references Person(IdPerson));");
            DataBase.Execute("CREATE TABLE IF NOT EXISTS PersonHasNachricht( IdNachricht string, IdPerson string, foreign key(IdNachricht) references Nachricht(IdNachricht),foreign key(IdPerson) references Person(IdPerson));");

            //DataBase.Execute("Select ");

            DataBase.Close();
            ContrView.Show();
            Application.Run(ContrView);
        }

        public void RegisterView(View newView)
        {
            newView.DelegateViewHasChanged += this.WhenViewChanged;
        }

        private void WhenModelChanged(string viewString)
        {
            ContrView.SetNachrichtenVerlauf(viewString);
        }

        private void WhenViewChanged(View changeView)
        {
            ContrModel.UpdateModel(ContrView.valText);
        }
        public void WriteinDB(string Time, string Absender, string Empfaenger, string Text)
        {
            
            if (InsertData("Nachricht", Time, Absender, Empfaenger, Text))
            {
                ContrModel.SendtoViewValue += "   ✓";
            }

        }
        public bool InsertData(string Tablename, string saveCol1 = "NULL", string saveCol2 = "NULL", string saveCol3 = "NULL", string saveCol4 = "NULL", string saveCol5 = "NULL")
        {
            DataBase.Open();


            if (DataBase.TableExists(Tablename))
            {
                try
                {
                    string Guid = System.Guid.NewGuid().ToString();
                    switch (Tablename)
                    {
                        case "Nachricht":
                            
                            DataBase.Execute("insert into " + Tablename + " values ('" + Guid + "','" + saveCol1 + "','" + saveCol2 + "','" + saveCol3 + "','" + saveCol4 + "')");
                            break;
                        case "Person":
                            DataBase.Execute("insert into'" + Tablename + "' values ('" + saveCol1 + "','" + saveCol2 + "','" + saveCol3 + "','" + saveCol4 + "')");
                            break;
                        case "PersonHasNachricht":
                            DataBase.Execute("insert into'" + Tablename + "' values ('" + saveCol1 + "','" + saveCol2 + "')");
                            break;
                        case "UserHasPerson":
                            DataBase.Execute("insert into'" + Tablename + "' values ('" + saveCol1 + "','" + saveCol2 + "')");
                            break;
                        case "User":
                            DataBase.Execute("insert into " + Tablename + "(IdPerson,Passwort) SELECT IdPerson,'" + saveCol2 + "' FROM Person WHERE Name = '" + saveCol1 + "'");
                            break;
                    }

                }
                catch
                {
                    DataBase.Close();
                    return false;
                }

            }
            DataBase.Close();
            return true;
        }
    }
}
