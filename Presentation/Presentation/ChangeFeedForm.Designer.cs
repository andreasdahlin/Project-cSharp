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
            this.cmbChooseFeed = new System.Windows.Forms.ComboBox();
            this.tbChangeFeedUrl = new System.Windows.Forms.TextBox();
            this.lblChangeFeedUrl = new System.Windows.Forms.Label();
            this.lblChooseFeed = new System.Windows.Forms.Label();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.tbChangeFeedName = new System.Windows.Forms.TextBox();
            this.tbChangeFeedInterval = new System.Windows.Forms.TextBox();
            this.lblChangeFeedName = new System.Windows.Forms.Label();
            this.lblChangeFeedInterval = new System.Windows.Forms.Label();
            this.lblChangeFeedCategory = new System.Windows.Forms.Label();
            this.cmbChangeCategory = new System.Windows.Forms.ComboBox();
            this.btnGetFeedInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbChooseFeed
            // 
            this.cmbChooseFeed.FormattingEnabled = true;
            this.cmbChooseFeed.Location = new System.Drawing.Point(52, 58);
            this.cmbChooseFeed.Name = "cmbChooseFeed";
            this.cmbChooseFeed.Size = new System.Drawing.Size(240, 24);
            this.cmbChooseFeed.TabIndex = 0;
            // 
            // tbChangeFeedUrl
            // 
            this.tbChangeFeedUrl.Location = new System.Drawing.Point(52, 184);
            this.tbChangeFeedUrl.Name = "tbChangeFeedUrl";
            this.tbChangeFeedUrl.Size = new System.Drawing.Size(240, 22);
            this.tbChangeFeedUrl.TabIndex = 1;
            // 
            // lblChangeFeedUrl
            // 
            this.lblChangeFeedUrl.AutoSize = true;
            this.lblChangeFeedUrl.Location = new System.Drawing.Point(51, 155);
            this.lblChangeFeedUrl.Name = "lblChangeFeedUrl";
            this.lblChangeFeedUrl.Size = new System.Drawing.Size(102, 17);
            this.lblChangeFeedUrl.TabIndex = 2;
            this.lblChangeFeedUrl.Text = "Write a new url";
            // 
            // lblChooseFeed
            // 
            this.lblChooseFeed.AutoSize = true;
            this.lblChooseFeed.Location = new System.Drawing.Point(51, 33);
            this.lblChooseFeed.Name = "lblChooseFeed";
            this.lblChooseFeed.Size = new System.Drawing.Size(100, 17);
            this.lblChooseFeed.TabIndex = 3;
            this.lblChooseFeed.Text = "Choose a feed";
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(99, 448);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(133, 53);
            this.btnChangeCategory.TabIndex = 4;
            this.btnChangeCategory.Text = "Change feed";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // tbChangeFeedName
            // 
            this.tbChangeFeedName.Location = new System.Drawing.Point(52, 241);
            this.tbChangeFeedName.Name = "tbChangeFeedName";
            this.tbChangeFeedName.Size = new System.Drawing.Size(240, 22);
            this.tbChangeFeedName.TabIndex = 5;
            // 
            // tbChangeFeedInterval
            // 
            this.tbChangeFeedInterval.Location = new System.Drawing.Point(51, 313);
            this.tbChangeFeedInterval.Name = "tbChangeFeedInterval";
            this.tbChangeFeedInterval.Size = new System.Drawing.Size(240, 22);
            this.tbChangeFeedInterval.TabIndex = 6;
            // 
            // lblChangeFeedName
            // 
            this.lblChangeFeedName.AutoSize = true;
            this.lblChangeFeedName.Location = new System.Drawing.Point(52, 218);
            this.lblChangeFeedName.Name = "lblChangeFeedName";
            this.lblChangeFeedName.Size = new System.Drawing.Size(121, 17);
            this.lblChangeFeedName.TabIndex = 8;
            this.lblChangeFeedName.Text = "Write a new name";
            // 
            // lblChangeFeedInterval
            // 
            this.lblChangeFeedInterval.AutoSize = true;
            this.lblChangeFeedInterval.Location = new System.Drawing.Point(51, 283);
            this.lblChangeFeedInterval.Name = "lblChangeFeedInterval";
            this.lblChangeFeedInterval.Size = new System.Drawing.Size(132, 17);
            this.lblChangeFeedInterval.TabIndex = 9;
            this.lblChangeFeedInterval.Text = "Write a new interval";
            // 
            // lblChangeFeedCategory
            // 
            this.lblChangeFeedCategory.AutoSize = true;
            this.lblChangeFeedCategory.Location = new System.Drawing.Point(51, 356);
            this.lblChangeFeedCategory.Name = "lblChangeFeedCategory";
            this.lblChangeFeedCategory.Size = new System.Drawing.Size(156, 17);
            this.lblChangeFeedCategory.TabIndex = 10;
            this.lblChangeFeedCategory.Text = "Choose a new category";
            // 
            // cmbChangeCategory
            // 
            this.cmbChangeCategory.FormattingEnabled = true;
            this.cmbChangeCategory.Location = new System.Drawing.Point(51, 386);
            this.cmbChangeCategory.Name = "cmbChangeCategory";
            this.cmbChangeCategory.Size = new System.Drawing.Size(240, 24);
            this.cmbChangeCategory.TabIndex = 11;
            // 
            // btnGetFeedInformation
            // 
            this.btnGetFeedInformation.Location = new System.Drawing.Point(87, 101);
            this.btnGetFeedInformation.Name = "btnGetFeedInformation";
            this.btnGetFeedInformation.Size = new System.Drawing.Size(160, 35);
            this.btnGetFeedInformation.TabIndex = 12;
            this.btnGetFeedInformation.Text = "Get feed information";
            this.btnGetFeedInformation.UseVisualStyleBackColor = true;
            this.btnGetFeedInformation.Click += new System.EventHandler(this.btnGetFeedInformation_Click);
            // 
            // ChangeFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 554);
            this.Controls.Add(this.btnGetFeedInformation);
            this.Controls.Add(this.cmbChangeCategory);
            this.Controls.Add(this.lblChangeFeedCategory);
            this.Controls.Add(this.lblChangeFeedInterval);
            this.Controls.Add(this.lblChangeFeedName);
            this.Controls.Add(this.tbChangeFeedInterval);
            this.Controls.Add(this.tbChangeFeedName);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.lblChooseFeed);
            this.Controls.Add(this.lblChangeFeedUrl);
            this.Controls.Add(this.tbChangeFeedUrl);
            this.Controls.Add(this.cmbChooseFeed);
            this.Name = "ChangeFeedForm";
            this.Text = "ChangeFeedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseFeed;
        private System.Windows.Forms.TextBox tbChangeFeedUrl;
        private System.Windows.Forms.Label lblChangeFeedUrl;
        private System.Windows.Forms.Label lblChooseFeed;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.TextBox tbChangeFeedName;
        private System.Windows.Forms.TextBox tbChangeFeedInterval;
        private System.Windows.Forms.Label lblChangeFeedName;
        private System.Windows.Forms.Label lblChangeFeedInterval;
        private System.Windows.Forms.Label lblChangeFeedCategory;
        private System.Windows.Forms.ComboBox cmbChangeCategory;
        private System.Windows.Forms.Button btnGetFeedInformation;
    }
}