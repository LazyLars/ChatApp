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
        private void InitializeComponent()
        {
            this.Nachrichtenverlauf = new System.Windows.Forms.RichTextBox();
            this.Eingabefeld = new System.Windows.Forms.RichTextBox();
            this.Sendebutton = new System.Windows.Forms.Button();
            this.Freundesliste = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Nachrichtenverlauf
            // 
            this.Nachrichtenverlauf.Location = new System.Drawing.Point(16, 16);
            this.Nachrichtenverlauf.Name = "Nachrichtenverlauf";
            this.Nachrichtenverlauf.Size = new System.Drawing.Size(460, 240);
            this.Nachrichtenverlauf.TabIndex = 0;
            this.Nachrichtenverlauf.Text = "Herzlich Willkommen in der ChatApp!! ;-)\n";
            // 
            // Eingabefeld
            // 
            this.Eingabefeld.Location = new System.Drawing.Point(16, 292);
            this.Eingabefeld.Name = "Eingabefeld";
            this.Eingabefeld.Size = new System.Drawing.Size(340, 50);
            this.Eingabefeld.TabIndex = 1;
            this.Eingabefeld.Text = "Hier Text eingeben!";
            this.Eingabefeld.GotFocus += new System.EventHandler(this.Eingabefeld_TextChanged);
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
            this.Freundesliste.Size = new System.Drawing.Size(163, 433);
            this.Freundesliste.TabIndex = 3;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 465);
            this.Controls.Add(this.Freundesliste);
            this.Controls.Add(this.Sendebutton);
            this.Controls.Add(this.Eingabefeld);
            this.Controls.Add(this.Nachrichtenverlauf);
            this.Name = "View";
            this.Text = "ChatApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Nachrichtenverlauf;
        private System.Windows.Forms.RichTextBox Eingabefeld;
        private System.Windows.Forms.Button Sendebutton;
        private System.Windows.Forms.ListBox Freundesliste;
    }
}

