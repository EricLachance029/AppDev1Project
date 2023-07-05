namespace Library_Management_System_project
{
    partial class PopupLibrarianLogin
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
            this.librarianLoginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passLoginLabel = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // librarianLoginLabel
            // 
            this.librarianLoginLabel.AutoSize = true;
            this.librarianLoginLabel.Location = new System.Drawing.Point(11, 9);
            this.librarianLoginLabel.Name = "librarianLoginLabel";
            this.librarianLoginLabel.Size = new System.Drawing.Size(369, 13);
            this.librarianLoginLabel.TabIndex = 0;
            this.librarianLoginLabel.Text = "You need to be logged in as a librarian to go any further, please sign in below";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(33, 169);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(79, 94);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(169, 20);
            this.passTextBox.TabIndex = 9;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(79, 55);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(169, 20);
            this.userTextBox.TabIndex = 8;
            // 
            // passLoginLabel
            // 
            this.passLoginLabel.AutoSize = true;
            this.passLoginLabel.Location = new System.Drawing.Point(17, 97);
            this.passLoginLabel.Name = "passLoginLabel";
            this.passLoginLabel.Size = new System.Drawing.Size(53, 13);
            this.passLoginLabel.TabIndex = 7;
            this.passLoginLabel.Text = "Password";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Location = new System.Drawing.Point(17, 55);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(55, 13);
            this.userLoginLabel.TabIndex = 6;
            this.userLoginLabel.Text = "Username";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(254, 169);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back to Home Page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PopupLibrarianLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 218);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passLoginLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.librarianLoginLabel);
            this.Name = "PopupLibrarianLogin";
            this.Text = "Librarian Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label librarianLoginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label passLoginLabel;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Button backButton;
    }
}