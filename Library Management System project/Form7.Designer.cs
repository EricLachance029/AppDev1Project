namespace Library_Management_System_project
{
    partial class SupplierLogin
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
            this.backButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passLoginLabel = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.librarianLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(255, 182);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 23);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Back to Home Page";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(34, 182);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 25;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(80, 107);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(169, 20);
            this.passTextBox.TabIndex = 24;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(80, 68);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(169, 20);
            this.userTextBox.TabIndex = 23;
            // 
            // passLoginLabel
            // 
            this.passLoginLabel.AutoSize = true;
            this.passLoginLabel.Location = new System.Drawing.Point(18, 110);
            this.passLoginLabel.Name = "passLoginLabel";
            this.passLoginLabel.Size = new System.Drawing.Size(53, 13);
            this.passLoginLabel.TabIndex = 22;
            this.passLoginLabel.Text = "Password";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Location = new System.Drawing.Point(18, 68);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(55, 13);
            this.userLoginLabel.TabIndex = 21;
            this.userLoginLabel.Text = "Username";
            // 
            // librarianLoginLabel
            // 
            this.librarianLoginLabel.AutoSize = true;
            this.librarianLoginLabel.Location = new System.Drawing.Point(12, 22);
            this.librarianLoginLabel.Name = "librarianLoginLabel";
            this.librarianLoginLabel.Size = new System.Drawing.Size(371, 13);
            this.librarianLoginLabel.TabIndex = 20;
            this.librarianLoginLabel.Text = "You need to be logged in as a Supplier to go any further, please sign in below";
            // 
            // SupplierLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 230);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passLoginLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.librarianLoginLabel);
            this.Name = "SupplierLogin";
            this.Text = "Supplier Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label passLoginLabel;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Label librarianLoginLabel;
    }
}