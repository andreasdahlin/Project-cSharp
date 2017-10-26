namespace Presentation
{
    partial class RemoveFeedForm
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
            this.cmbChoseFeed = new System.Windows.Forms.ComboBox();
            this.lblChoseFeed = new System.Windows.Forms.Label();
            this.btnDeleteFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbChoseFeed
            // 
            this.cmbChoseFeed.FormattingEnabled = true;
            this.cmbChoseFeed.Location = new System.Drawing.Point(45, 75);
            this.cmbChoseFeed.Name = "cmbChoseFeed";
            this.cmbChoseFeed.Size = new System.Drawing.Size(181, 24);
            this.cmbChoseFeed.TabIndex = 0;
            // 
            // lblChoseFeed
            // 
            this.lblChoseFeed.AutoSize = true;
            this.lblChoseFeed.Location = new System.Drawing.Point(42, 46);
            this.lblChoseFeed.Name = "lblChoseFeed";
            this.lblChoseFeed.Size = new System.Drawing.Size(100, 17);
            this.lblChoseFeed.TabIndex = 1;
            this.lblChoseFeed.Text = "Choose a feed";
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(71, 125);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(126, 49);
            this.btnDeleteFeed.TabIndex = 2;
            this.btnDeleteFeed.Text = "Delete Feed";
            this.btnDeleteFeed.UseVisualStyleBackColor = true;
            this.btnDeleteFeed.Click += new System.EventHandler(this.btnDeleteFeed_Click);
            // 
            // RemoveFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 226);
            this.Controls.Add(this.btnDeleteFeed);
            this.Controls.Add(this.lblChoseFeed);
            this.Controls.Add(this.cmbChoseFeed);
            this.Name = "RemoveFeedForm";
            this.Text = "RemoveFeedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChoseFeed;
        private System.Windows.Forms.Label lblChoseFeed;
        private System.Windows.Forms.Button btnDeleteFeed;
    }
}