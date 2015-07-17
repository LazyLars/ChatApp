namespace ChatApp
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserFeld = new System.Windows.Forms.RichTextBox();
            this.PasswortFeld = new System.Windows.Forms.RichTextBox();
            this.Einloggen = new System.Windows.Forms.Button();
            this.UserAnlegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserFeld
            // 
            this.UserFeld.Location = new System.Drawing.Point(47, 40);
            this.UserFeld.Name = "UserFeld";
            this.UserFeld.Size = new System.Drawing.Size(171, 18);
            this.UserFeld.TabIndex = 0;
            this.UserFeld.Text = "Username";
            this.UserFeld.Enter += new System.EventHandler(this.UserFeld_TextChanged);
            // 
            // PasswortFeld
            // 
            this.PasswortFeld.Location = new System.Drawing.Point(47, 78);
            this.PasswortFeld.Name = "PasswortFeld";
            this.PasswortFeld.Size = new System.Drawing.Size(171, 18);
            this.PasswortFeld.TabIndex = 1;
            this.PasswortFeld.Text = "Password";
            this.PasswortFeld.Enter += new System.EventHandler(this.PasswortFeld_TextChanged);
            // 
            // Einloggen
            // 
            this.Einloggen.Location = new System.Drawing.Point(142, 103);
            this.Einloggen.Name = "Einloggen";
            this.Einloggen.Size = new System.Drawing.Size(75, 23);
            this.Einloggen.TabIndex = 2;
            this.Einloggen.Text = "Einloggen";
            this.Einloggen.UseVisualStyleBackColor = true;
            this.Einloggen.Click += new System.EventHandler(this.Einloggen_Click);
            // 
            // UserAnlegen
            // 
            this.UserAnlegen.Location = new System.Drawing.Point(47, 103);
            this.UserAnlegen.Name = "UserAnlegen";
            this.UserAnlegen.Size = new System.Drawing.Size(75, 23);
            this.UserAnlegen.TabIndex = 3;
            this.UserAnlegen.Text = "Anlegen";
            this.UserAnlegen.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.UserAnlegen);
            this.Controls.Add(this.Einloggen);
            this.Controls.Add(this.PasswortFeld);
            this.Controls.Add(this.UserFeld);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox UserFeld;
        private System.Windows.Forms.RichTextBox PasswortFeld;
        private System.Windows.Forms.Button Einloggen;
        private System.Windows.Forms.Button UserAnlegen;
    }
}