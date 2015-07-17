using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class LoginView : Form
    {
        //Member
        public delegate void LoginHasAccept(LoginView LogView);
        public LoginHasAccept LoginAccept;
        
        public string UserName = "";
        public string Passwd = "";

        //Methoden
        public LoginView()
        {
            InitializeComponent();
        }

        private void Einloggen_Click(object sender, EventArgs e)
        {
            if ((this.UserFeld.Text != "") && (this.PasswortFeld.Text != ""))
            {
                Name = this.UserFeld.Text;
                Passwd = this.PasswortFeld.Text;
                LoginAccept(this);
            }
        }

        private void UserFeld_TextChanged(object sender, EventArgs e)
        {
            this.UserFeld.Text = "";
        }

        private void PasswortFeld_TextChanged(object sender, EventArgs e)
        {
            this.PasswortFeld.Text = "";
        }
    }
}
