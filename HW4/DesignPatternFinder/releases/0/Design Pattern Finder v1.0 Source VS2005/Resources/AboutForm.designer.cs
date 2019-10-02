namespace DesignPatternFinder
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.applicationTitleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.jonasEmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.jonasWebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // applicationTitleLabel
            // 
            this.applicationTitleLabel.AutoSize = true;
            this.applicationTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.applicationTitleLabel.Name = "applicationTitleLabel";
            this.applicationTitleLabel.Size = new System.Drawing.Size(142, 13);
            this.applicationTitleLabel.TabIndex = 3;
            this.applicationTitleLabel.Text = "Design Pattern Finder v1.0";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 29);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(93, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "3 december 2007";
            // 
            // jonasEmailLinkLabel
            // 
            this.jonasEmailLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.jonasEmailLinkLabel.AutoSize = true;
            this.jonasEmailLinkLabel.Location = new System.Drawing.Point(12, 48);
            this.jonasEmailLinkLabel.Name = "jonasEmailLinkLabel";
            this.jonasEmailLinkLabel.Size = new System.Drawing.Size(124, 13);
            this.jonasEmailLinkLabel.TabIndex = 6;
            this.jonasEmailLinkLabel.TabStop = true;
            this.jonasEmailLinkLabel.Text = "Jonas.Butt@gmail.com";
            this.jonasEmailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jonasEmailLinkLabel_LinkClicked);
            // 
            // jonasWebsiteLinkLabel
            // 
            this.jonasWebsiteLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.jonasWebsiteLinkLabel.AutoSize = true;
            this.jonasWebsiteLinkLabel.Location = new System.Drawing.Point(12, 68);
            this.jonasWebsiteLinkLabel.Name = "jonasWebsiteLinkLabel";
            this.jonasWebsiteLinkLabel.Size = new System.Drawing.Size(149, 13);
            this.jonasWebsiteLinkLabel.TabIndex = 7;
            this.jonasWebsiteLinkLabel.TabStop = true;
            this.jonasWebsiteLinkLabel.Text = "JonasButt on CodePlex.com";
            this.jonasWebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jonasWebsiteLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 91);
            this.Controls.Add(this.jonasWebsiteLinkLabel);
            this.Controls.Add(this.jonasEmailLinkLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.applicationTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label applicationTitleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.LinkLabel jonasEmailLinkLabel;
        private System.Windows.Forms.LinkLabel jonasWebsiteLinkLabel;
    }
}