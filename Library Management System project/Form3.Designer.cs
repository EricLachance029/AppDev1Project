namespace Library_Management_System_project
{
    partial class LibrarianForm
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
            this.showWelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showWelcomeLabel
            // 
            this.showWelcomeLabel.AutoSize = true;
            this.showWelcomeLabel.Location = new System.Drawing.Point(43, 24);
            this.showWelcomeLabel.Name = "showWelcomeLabel";
            this.showWelcomeLabel.Size = new System.Drawing.Size(39, 13);
            this.showWelcomeLabel.TabIndex = 0;
            this.showWelcomeLabel.Text = "hidden";
            this.showWelcomeLabel.Visible = false;
            this.showWelcomeLabel.Click += new System.EventHandler(this.showWelcomeLabel_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showWelcomeLabel);
            this.Name = "LibrarianForm";
            this.Text = "Librarian Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showWelcomeLabel;
    }
}