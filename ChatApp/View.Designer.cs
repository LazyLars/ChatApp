namespace ChatApp
{
    partial class View
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.Nachrichtenverlauf = new System.Windows.Forms.RichTextBox();
            this.Eingabefeld = new System.Windows.Forms.RichTextBox();
            this.Sendebutton = new System.Windows.Forms.Button();
            this.Freundesliste = new System.Windows.Forms.ListBox();
            this.StartListenerButton = new System.Windows.Forms.Button();
            this.IpTextbox = new System.Windows.Forms.TextBox();
            this.EmpfeangerIpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nachrichtenverlauf
            // 
            this.Nachrichtenverlauf.Location = new System.Drawing.Point(16, 16);
            this.Nachrichtenverlauf.Name = "Nachrichtenverlauf";
            this.Nachrichtenverlauf.ReadOnly = true;
            this.Nachrichtenverlauf.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Nachrichtenverlauf.Size = new System.Drawing.Size(460, 240);
            this.Nachrichtenverlauf.TabIndex = 0;
            this.Nachrichtenverlauf.Text = "Herzlich Willkommen in der ChatApp!! ;-)\n\nBitte Starten Sie den Listener mit dem Button weiter unten!\n\nZur Vertestung bitte in das Empfänger-Ip Feld 127.0.0.1 eintragen!\nBei doppelter Nachricht mit unterschiedlichem Zeitstempel erfolgreich!\n";
            // 
            // Eingabefeld
            // 
            this.Eingabefeld.Location = new System.Drawing.Point(16, 292);
            this.Eingabefeld.Name = "Eingabefeld";
            this.Eingabefeld.Size = new System.Drawing.Size(340, 50);
            this.Eingabefeld.TabIndex = 1;
            this.Eingabefeld.Text = "Hier Text eingeben!";
            this.Eingabefeld.GotFocus += new System.EventHandler(this.Eingabefeld_TextChanged);
            this.Eingabefeld.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Eingabefeld_PreviewKeyDown_1);
            // 
            // Sendebutton
            // 
            this.Sendebutton.Location = new System.Drawing.Point(397, 301);
            this.Sendebutton.Name = "Sendebutton";
            this.Sendebutton.Size = new System.Drawing.Size(78, 40);
            this.Sendebutton.TabIndex = 2;
            this.Sendebutton.Text = "SENDEN";
            this.Sendebutton.UseVisualStyleBackColor = true;
            this.Sendebutton.Click += new System.EventHandler(this.Sendebutton_Click);
            // 
            // Freundesliste
            // 
            this.Freundesliste.FormattingEnabled = true;
            this.Freundesliste.Location = new System.Drawing.Point(529, 16);
            this.Freundesliste.Name = "Freundesliste";
            this.Freundesliste.Size = new System.Drawing.Size(163, 329);
            this.Freundesliste.TabIndex = 3;
            // 
            // StartListenerButton
            // 
            this.StartListenerButton.Location = new System.Drawing.Point(358, 262);
            this.StartListenerButton.Name = "StartListenerButton";
            this.StartListenerButton.Size = new System.Drawing.Size(117, 24);
            this.StartListenerButton.TabIndex = 4;
            this.StartListenerButton.Text = "Start Listener";
            this.StartListenerButton.UseVisualStyleBackColor = true;
            this.StartListenerButton.Click += new System.EventHandler(this.StartListener_Click);
            // 
            // IpTextbox
            // 
            this.IpTextbox.Location = new System.Drawing.Point(209, 266);
            this.IpTextbox.Name = "IpTextbox";
            this.IpTextbox.Size = new System.Drawing.Size(100, 20);
            this.IpTextbox.TabIndex = 5;
            // 
            // EmpfeangerIpLabel
            // 
            this.EmpfeangerIpLabel.AutoSize = true;
            this.EmpfeangerIpLabel.Location = new System.Drawing.Point(133, 269);
            this.EmpfeangerIpLabel.Name = "EmpfeangerIpLabel";
            this.EmpfeangerIpLabel.Size = new System.Drawing.Size(82, 13);
            this.EmpfeangerIpLabel.TabIndex = 6;
            this.EmpfeangerIpLabel.Text = "Empfänger- Ip : ";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 359);
            this.Controls.Add(this.EmpfeangerIpLabel);
            this.Controls.Add(this.IpTextbox);
            this.Controls.Add(this.StartListenerButton);
            this.Controls.Add(this.Freundesliste);
            this.Controls.Add(this.Sendebutton);
            this.Controls.Add(this.Eingabefeld);
            this.Controls.Add(this.Nachrichtenverlauf);
            this.Name = "View";
            this.Text = "ChatApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Nachrichtenverlauf;
        private System.Windows.Forms.RichTextBox Eingabefeld;
        private System.Windows.Forms.Button Sendebutton;
        private System.Windows.Forms.ListBox Freundesliste;
        private System.Windows.Forms.Button StartListenerButton;
        private System.Windows.Forms.TextBox IpTextbox;
        private System.Windows.Forms.Label EmpfeangerIpLabel;
    }
}

