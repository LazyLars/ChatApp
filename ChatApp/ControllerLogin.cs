using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ChatApp
{
    class ControllerLogin : Controller
    {
        //Member
        public LoginView LogContrView = new LoginView();

        //Methoden
        public ControllerLogin()
        {            
            RegisterView(LogContrView);
            LogContrView.Show();
            Application.Run(LogContrView);
        }
        public void RegisterView(LoginView GetViewLogin)
        {
            GetViewLogin.LoginAccept += this.TestUserAccess;
        }
        private bool LoadProfile()
        {
            return true;
        }
        private void TestUserAccess(LoginView ViewLogin)
        {
            DataBase = new DataBaseSQLite("Data Source = DBChatApp.bd3");
            DataBase.Open();

            DataBase.Execute("Select cout('Name') from 'Person' where 'Name' = '" + ViewLogin.UserName + "';");

            DataBase.Close();

        }

    }
}
