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

    public partial class View : Form
    {
        //Member
        public string valText = "";

        public delegate void ViewHasChanged(View callingView);
        public ViewHasChanged DelegateViewHasChanged;
        
        //Methoden
        public View()
        {
            InitializeComponent();
        }

        public void SetNachrichtenVerlauf(string viewText)
        {
            Nachrichtenverlauf.Text += viewText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Eingabefeld_TextChanged(object sender, EventArgs e)
        {
            this.Eingabefeld.Text = "";
        }

        private void Sendebutton_Click(object sender, EventArgs e)
        {
            if (this.Eingabefeld.Text != "")
            {
                valText = this.Eingabefeld.Text;
                valText += "\n";
                DelegateViewHasChanged(this);
                this.Eingabefeld.Text = "";
            }
        }

        private void Eingabefeld_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) && e.Control)
            {
                if (this.Eingabefeld.Text != "")
                {
                    valText = this.Eingabefeld.Text;
                    valText += "\n";
                    DelegateViewHasChanged(this);
                    this.Eingabefeld.Text = "";
                }
            }
        }


    }
}