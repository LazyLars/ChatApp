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
            this.BenutzernameTextbox = new System.Windows.Forms.RichTextBox();
            this.PasswortTextbox = new System.Windows.Forms.RichTextBox();
            this.BenutzernameLoginLabel = new System.Windows.Forms.Label();
            this.PasswortLoginLabel = new System.Windows.Forms.Label();
            this.SendeLoginButton = new System.Windows.Forms.Button();
            this.SendeRegistrierungButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BenutzernameTextbox
            // 
            this.BenutzernameTextbox.Location = new System.Drawing.Point(47, 40);
            this.BenutzernameTextbox.Name = "BenutzernameTextbox";
            this.BenutzernameTextbox.Size = new System.Drawing.Size(171, 18);
            this.BenutzernameTextbox.TabIndex = 0;
            this.BenutzernameTextbox.Text = "";
            // 
            // PasswortTextbox
            // 
            this.PasswortTextbox.Location = new System.Drawing.Point(47, 77);
            this.PasswortTextbox.Name = "PasswortTextbox";
            this.PasswortTextbox.Size = new System.Drawing.Size(171, 18);
            this.PasswortTextbox.TabIndex = 1;
            this.PasswortTextbox.Text = "";
            // 
            // BenutzernameLoginLabel
            // 
            this.BenutzernameLoginLabel.AutoSize = true;
            this.BenutzernameLoginLabel.Location = new System.Drawing.Point(44, 24);
            this.BenutzernameLoginLabel.Name = "BenutzernameLoginLabel";
            this.BenutzernameLoginLabel.Size = new System.Drawing.Size(81, 13);
            this.BenutzernameLoginLabel.TabIndex = 2;
            this.BenutzernameLoginLabel.Text = "Benutzername :";
            this.BenutzernameLoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswortLoginLabel
            // 
            this.PasswortLoginLabel.AutoSize = true;
            this.PasswortLoginLabel.Location = new System.Drawing.Point(44, 61);
            this.PasswortLoginLabel.Name = "PasswortLoginLabel";
            this.PasswortLoginLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswortLoginLabel.TabIndex = 3;
            this.PasswortLoginLabel.Text = "Passwort :";
            this.PasswortLoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SendeLoginButton
            // 
            this.SendeLoginButton.Location = new System.Drawing.Point(164, 111);
            this.SendeLoginButton.Name = "SendeLoginButton";
            this.SendeLoginButton.Size = new System.Drawing.Size(75, 23);
            this.SendeLoginButton.TabIndex = 4;
            this.SendeLoginButton.Text = "Login";
            this.SendeLoginButton.UseVisualStyleBackColor = true;
            this.SendeLoginButton.Click += new System.EventHandler(this.SendeLoginButton_Click);
            // 
            // SendeRegistrierungButton
            // 
            this.SendeRegistrierungButton.Location = new System.Drawing.Point(47, 111);
            this.SendeRegistrierungButton.Name = "SendeRegistrierungButton";
            this.SendeRegistrierungButton.Size = new System.Drawing.Size(75, 23);
            this.SendeRegistrierungButton.TabIndex = 5;
            this.SendeRegistrierungButton.Text = "Registrieren";
            this.SendeRegistrierungButton.UseVisualStyleBackColor = true;
            this.SendeRegistrierungButton.Click += new System.EventHandler(this.SendeRegistrierungButton_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.SendeRegistrierungButton);
            this.Controls.Add(this.SendeLoginButton);
            this.Controls.Add(this.PasswortLoginLabel);
            this.Controls.Add(this.BenutzernameLoginLabel);
            this.Controls.Add(this.PasswortTextbox);
            this.Controls.Add(this.BenutzernameTextbox);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox BenutzernameTextbox;
        private System.Windows.Forms.RichTextBox PasswortTextbox;
        private System.Windows.Forms.Label BenutzernameLoginLabel;
        private System.Windows.Forms.Label PasswortLoginLabel;
        private System.Windows.Forms.Button SendeLoginButton;
        private System.Windows.Forms.Button SendeRegistrierungButton;
    }
}