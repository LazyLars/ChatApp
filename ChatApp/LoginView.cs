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
        public delegate bool LoginViewHasChanged(string Username, string Passwort, bool RegOrLogin);      //Delegat zum Controller zur Bearbeitung der LoginView
        public LoginViewHasChanged DelegateLoginViewHasChanged;

        public delegate void DelegateLoginAccept();
        public DelegateLoginAccept delegateLoginAccept;


        //Methoden

        //Standardkostruktor
        public LoginView()
        {
            InitializeComponent();          //Liste der Elemente der View
        }

        private void SendeLoginButton_Click(object sender, EventArgs e)
        {
            DelegateLoginViewHasChanged(this.BenutzernameTextbox.Text, this.PasswortTextbox.Text, true);
        }

        private void SendeRegistrierungButton_Click(object sender, EventArgs e)
        {
            if (DelegateLoginViewHasChanged(this.BenutzernameTextbox.Text, this.PasswortTextbox.Text, false))
            {
                delegateLoginAccept();
                this.Close();
            }

            else
            {
                MessageBox.Show("Keine User angelegt!\nBitte versuchen Sie es erneut.");
            }
        }
    }
}
