namespace Library_Management_System_project
{
    partial class SupplierForm
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
            this.showWelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 23);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back to Home Page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // showWelcomeLabel
            // 
            this.showWelcomeLabel.AutoSize = true;
            this.showWelcomeLabel.Location = new System.Drawing.Point(12, 30);
            this.showWelcomeLabel.Name = "showWelcomeLabel";
            this.showWelcomeLabel.Size = new System.Drawing.Size(129, 13);
            this.showWelcomeLabel.TabIndex = 22;
            this.showWelcomeLabel.Text = "hidden welcome message";
            this.showWelcomeLabel.Visible = false;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showWelcomeLabel);
            this.Controls.Add(this.backButton);
            this.Name = "SupplierForm";
            this.Text = "Supplier Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label showWelcomeLabel;
    }
}