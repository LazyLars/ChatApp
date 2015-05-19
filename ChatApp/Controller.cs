using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatApp
{
    class Controller
    {
        //Member
        public View ContrView = new View();
        public Model ContrModel = new Model();
        public DataBaseSQLite DataBase;

        public string Datatest ="";

        //Methoden
        public Controller()
        {
            RegisterView(ContrView);
            
            ContrModel.DelegateModelChange += this.WhenModelChanged;
            DataBase = new DataBaseSQLite("Data Source = DBChatApp.db3");
            ContrView.Show();
            Application.Run(ContrView);
        }
        
        public void RegisterView(View newView)
        {
            newView.DelegateViewHasChanged += this.WhenViewChanged;    
        }

        private void WhenModelChanged(string viewString)
        {   
            DataBase.Open();
            if (DataBase.InsertData("User","2","Timm"))
            {
                Datatest = "Daten geschrieben";
            }
            DataBase.Close();

            ContrView.SetNachrichtenVerlauf(Datatest);
            //ContrView.SetNachrichtenVerlauf(viewString);
        }

        private void WhenViewChanged(View changeView)
        {
            ContrModel.UpdateModel(ContrView.valText);
        }
    }
}
