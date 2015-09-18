using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ChatApp
{

    //Hauptfenster der Chatapplikation
    public partial class View : Form
    {
        //Member
        public string valText = "";     //Speichert string für weitere Verwendung -> mehrfachnutzung
        public string IpAdress;

        public delegate void ViewHasChanged(View callingView);      //Delegat zum Controller zur Bearbeitung der View
        public ViewHasChanged DelegateViewHasChanged;               //Inzialisierung des Delegaten 

        public delegate void StartTCPListenerFromView(View ListView);   //Delegate zum Starten eines TCPListeners  
        public StartTCPListenerFromView StartTcpListener;               //mit Veränderungen an der View
    
        //Methoden
        //Standardkonstruktor zur Initalisierung der View-Elemente
        public View()
        {
            InitializeComponent();          //Liste der Elemente der View
        }
        //Methode zum anfügen verschiedener strings in den Nachrichtenverlauf
        public void SetNachrichtenVerlauf(string viewText)
        {
            Nachrichtenverlauf.AppendText(viewText);    //Fügt neuen string an den vorhandenen string im Textfeld Nachrichtenverlauf
            Nachrichtenverlauf.ScrollToCaret();         //sorgt für ein Autoskroll im Textfeld Nachrichtenverlauf   
        }
        //Methode zum verändern des Statusbuttons des Listener je nach
        //übergebenem String und gibt alten String zurück
        public string SetListenerStatusText(string ListenerButtonText)
        {                       
            string OldListenerText = StartListenerButton.Text;  //Speichert old.String für return
            StartListenerButton.Text = ListenerButtonText;      //Schreibt neuen String in Textfeld
            return OldListenerText;                             //gibt String als return an
        }
        
        //Eventhandling zum Zurücksetzen des Eingabefeldes 
        //!!!!
        //Funtioniert nicht wie gedacht! Manuell in Sendebutton_Click ebenfalls fehlerhaft
        //!!!!
        private void Eingabefeld_TextChanged(object sender, EventArgs e)
        {
            this.Eingabefeld.Text = "";         //setzt Eingabefeld leer
        }
        //Eventhandling bei klicken auf Sendebutton
        private void Sendebutton_Click(object sender, EventArgs e)
        {
            if (this.Eingabefeld.Text != "")           //Eingabefeld leer?
            {
                this.IpAdress = this.IpTextbox.Text;
                valText = this.Eingabefeld.Text;       //Text Eingabefeld wird in string gespeichert
                DelegateViewHasChanged(this);          //Aufruf Delegate Veränderung View 
                this.Eingabefeld.Text = "";            //Text Eingabefeld wird leer gesetzt
                
                //funktioniert wie Methode nicht
            }
        }
        //Eventhandling zu den Shortkeys ENTER+STRG
        private void Eingabefeld_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            //Abfrage beide Tasten gedrückt?
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) && e.Control)
            {
                if (this.Eingabefeld.Text != "")    //Textfeld leer?
                {
                    valText = this.Eingabefeld.Text;       //Text Eingabefeld wird in string gespeichert
                    this.IpAdress = this.IpTextbox.Text;
                    DelegateViewHasChanged(this);          //Aufruf Delegate Veränderung View 
                    this.Eingabefeld.Text = "";            //Text Eingabefeld wird leer gesetzt
                    //funktioniert wie Methode nicht
                }
            }
        }

        //Eventhandling zum starten des Listeners
        private void StartListener_Click(object sender, EventArgs e)
        {
            StartTcpListener(this);         //Aufruf des Delegaten für den TCPListener
        }

        //Invoke-Methode zum Threadübergreifenden Verändern des Nachrichtenverlaufes
        public void AddMessageFromClient(string input)
        {
            if (Nachrichtenverlauf.InvokeRequired)      //Prüfung auf Änderungsanfrage des Threads im Mainthread
            {
                //Nachrichtenverlauf will ändern erneuter Aufruf der Methode
                Nachrichtenverlauf.Invoke((MethodInvoker)(() => AddMessageFromClient(input)));
            }
            else        //Tritt ein wenn Invoke auf Nachrichtenverlauf auftritt
            {
                //Thread.Sleep(1000);             //lässt Thread warten
                SetNachrichtenVerlauf(input);  //ruft Methode der View auf und übergibt string
            }
        }
    }
}