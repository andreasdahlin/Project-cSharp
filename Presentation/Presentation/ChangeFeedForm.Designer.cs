namespace Presentation
{
    partial class ChangeFeedForm
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
            this.tbNewFeedName = new System.Windows.Forms.TextBox();
            this.lblNewFeedName = new System.Windows.Forms.Label();
            this.lblChoseFeed = new System.Windows.Forms.Label();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbChoseFeed
            // 
            this.cmbChoseFeed.FormattingEnabled = true;
            this.cmbChoseFeed.Location = new System.Drawing.Point(52, 58);
            this.cmbChoseFeed.Name = "cmbChoseFeed";
            this.cmbChoseFeed.Size = new System.Drawing.Size(174, 24);
            this.cmbChoseFeed.TabIndex = 0;
            
            // 
            // tbNewFeedName
            // 
            this.tbNewFeedName.Location = new System.Drawing.Point(52, 139);
            this.tbNewFeedName.Name = "tbNewFeedName";
            this.tbNewFeedName.Size = new System.Drawing.Size(174, 22);
            this.tbNewFeedName.TabIndex = 1;
            // 
            // lblNewFeedName
            // 
            this.lblNewFeedName.AutoSize = true;
            this.lblNewFeedName.Location = new System.Drawing.Point(49, 110);
            this.lblNewFeedName.Name = "lblNewFeedName";
            this.lblNewFeedName.Size = new System.Drawing.Size(117, 17);
            this.lblNewFeedName.TabIndex = 2;
            this.lblNewFeedName.Text = "Välj ett nytt namn";
            // 
            // lblChoseFeed
            // 
            this.lblChoseFeed.AutoSize = true;
            this.lblChoseFeed.Location = new System.Drawing.Point(51, 33);
            this.lblChoseFeed.Name = "lblChoseFeed";
            this.lblChoseFeed.Size = new System.Drawing.Size(83, 17);
            this.lblChoseFeed.TabIndex = 3;
            this.lblChoseFeed.Text = "Välj en feed";
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(71, 190);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(133, 29);
            this.btnChangeCategory.TabIndex = 4;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            // 
            // ChangeFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.lblChoseFeed);
            this.Controls.Add(this.lblNewFeedName);
            this.Controls.Add(this.tbNewFeedName);
            this.Controls.Add(this.cmbChoseFeed);
            this.Name = "ChangeFeedForm";
            this.Text = "ChangeFeedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChoseFeed;
        private System.Windows.Forms.TextBox tbNewFeedName;
        private System.Windows.Forms.Label lblNewFeedName;
        private System.Windows.Forms.Label lblChoseFeed;
        private System.Windows.Forms.Button btnChangeCategory;
    }
}