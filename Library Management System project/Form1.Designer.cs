namespace Library_Management_System_project
{
    partial class WelcomePage
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.iAmLabel = new System.Windows.Forms.Label();
            this.librarianButton = new System.Windows.Forms.Button();
            this.memberButton = new System.Windows.Forms.Button();
            this.nonMemberButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(140, 28);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(175, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the Library of Montreal!";
            // 
            // iAmLabel
            // 
            this.iAmLabel.AutoSize = true;
            this.iAmLabel.Location = new System.Drawing.Point(205, 75);
            this.iAmLabel.Name = "iAmLabel";
            this.iAmLabel.Size = new System.Drawing.Size(30, 13);
            this.iAmLabel.TabIndex = 1;
            this.iAmLabel.Text = "I am:";
            // 
            // librarianButton
            // 
            this.librarianButton.Location = new System.Drawing.Point(143, 107);
            this.librarianButton.Name = "librarianButton";
            this.librarianButton.Size = new System.Drawing.Size(152, 67);
            this.librarianButton.TabIndex = 2;
            this.librarianButton.Text = "a Librarian";
            this.librarianButton.UseVisualStyleBackColor = true;
            this.librarianButton.Click += new System.EventHandler(this.librarianButton_Click);
            // 
            // memberButton
            // 
            this.memberButton.Location = new System.Drawing.Point(143, 192);
            this.memberButton.Name = "memberButton";
            this.memberButton.Size = new System.Drawing.Size(152, 67);
            this.memberButton.TabIndex = 3;
            this.memberButton.Text = "a Member";
            this.memberButton.UseVisualStyleBackColor = true;
            this.memberButton.Click += new System.EventHandler(this.memberButton_Click);
            // 
            // nonMemberButton
            // 
            this.nonMemberButton.Location = new System.Drawing.Point(143, 277);
            this.nonMemberButton.Name = "nonMemberButton";
            this.nonMemberButton.Size = new System.Drawing.Size(152, 67);
            this.nonMemberButton.TabIndex = 4;
            this.nonMemberButton.Text = "not a Member";
            this.nonMemberButton.UseVisualStyleBackColor = true;
            this.nonMemberButton.Click += new System.EventHandler(this.nonmemberButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.Location = new System.Drawing.Point(143, 362);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(152, 67);
            this.supplierButton.TabIndex = 5;
            this.supplierButton.Text = "a Supplier";
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.supplierButton);
            this.Controls.Add(this.nonMemberButton);
            this.Controls.Add(this.memberButton);
            this.Controls.Add(this.librarianButton);
            this.Controls.Add(this.iAmLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "WelcomePage";
            this.Text = "Welcome Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label iAmLabel;
        private System.Windows.Forms.Button librarianButton;
        private System.Windows.Forms.Button memberButton;
        private System.Windows.Forms.Button nonMemberButton;
        private System.Windows.Forms.Button supplierButton;
    }
}

