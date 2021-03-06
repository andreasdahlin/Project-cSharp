﻿namespace Presentation
{
    partial class MainInterfaceForm
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.lbFeeds = new System.Windows.Forms.ListBox();
            this.lbPodcasts = new System.Windows.Forms.ListBox();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnShowAllFeeds = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblCategoriesAboveList = new System.Windows.Forms.Label();
            this.lblFeeds = new System.Windows.Forms.Label();
            this.lblPodcasts = new System.Windows.Forms.Label();
            this.lblPodcastDetails = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddPodcast = new System.Windows.Forms.Button();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDeleteFeed = new System.Windows.Forms.Button();
            this.tbAddCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(30, 133);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(283, 22);
            this.tbUrl.TabIndex = 0;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(30, 228);
            this.tbInterval.Margin = new System.Windows.Forms.Padding(4);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(282, 22);
            this.tbInterval.TabIndex = 2;
            this.tbInterval.TextChanged += new System.EventHandler(this.tbInterval_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(30, 291);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(281, 24);
            this.cmbCategory.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(30, 181);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(282, 22);
            this.tbName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 349);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(185, 349);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(127, 52);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 16;
            this.lbCategories.Location = new System.Drawing.Point(376, 43);
            this.lbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(192, 260);
            this.lbCategories.TabIndex = 7;
            // 
            // lbFeeds
            // 
            this.lbFeeds.FormattingEnabled = true;
            this.lbFeeds.ItemHeight = 16;
            this.lbFeeds.Location = new System.Drawing.Point(616, 44);
            this.lbFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.lbFeeds.Name = "lbFeeds";
            this.lbFeeds.Size = new System.Drawing.Size(197, 260);
            this.lbFeeds.TabIndex = 8;
            // 
            // lbPodcasts
            // 
            this.lbPodcasts.FormattingEnabled = true;
            this.lbPodcasts.ItemHeight = 16;
            this.lbPodcasts.Location = new System.Drawing.Point(857, 44);
            this.lbPodcasts.Margin = new System.Windows.Forms.Padding(4);
            this.lbPodcasts.Name = "lbPodcasts";
            this.lbPodcasts.Size = new System.Drawing.Size(526, 260);
            this.lbPodcasts.TabIndex = 9;
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(197, 43);
            this.btnCategoryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(128, 52);
            this.btnCategoryAdd.TabIndex = 11;
            this.btnCategoryAdd.Text = "Add Category";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(33, 537);
            this.btnChangeCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(128, 52);
            this.btnChangeCategory.TabIndex = 12;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(197, 537);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(128, 52);
            this.btnDeleteCategory.TabIndex = 13;
            this.btnDeleteCategory.Text = "Remove Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnShowAllFeeds
            // 
            this.btnShowAllFeeds.Location = new System.Drawing.Point(411, 320);
            this.btnShowAllFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllFeeds.Name = "btnShowAllFeeds";
            this.btnShowAllFeeds.Size = new System.Drawing.Size(128, 52);
            this.btnShowAllFeeds.TabIndex = 14;
            this.btnShowAllFeeds.Text = "Show All Feeds";
            this.btnShowAllFeeds.UseVisualStyleBackColor = true;
            this.btnShowAllFeeds.Click += new System.EventHandler(this.btnShowAllFeeds_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(150, 112);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 17);
            this.lblUrl.TabIndex = 15;
            this.lblUrl.Text = "URL";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 162);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Namn";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(141, 207);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(54, 17);
            this.lblInterval.TabIndex = 17;
            this.lblInterval.Text = "Interval";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(130, 271);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(76, 17);
            this.lblCategories.TabIndex = 18;
            this.lblCategories.Text = "Categories";
            // 
            // lblCategoriesAboveList
            // 
            this.lblCategoriesAboveList.AutoSize = true;
            this.lblCategoriesAboveList.Location = new System.Drawing.Point(427, 11);
            this.lblCategoriesAboveList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriesAboveList.Name = "lblCategoriesAboveList";
            this.lblCategoriesAboveList.Size = new System.Drawing.Size(76, 17);
            this.lblCategoriesAboveList.TabIndex = 19;
            this.lblCategoriesAboveList.Text = "Categories";
            // 
            // lblFeeds
            // 
            this.lblFeeds.AutoSize = true;
            this.lblFeeds.Location = new System.Drawing.Point(699, 11);
            this.lblFeeds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeeds.Name = "lblFeeds";
            this.lblFeeds.Size = new System.Drawing.Size(47, 17);
            this.lblFeeds.TabIndex = 20;
            this.lblFeeds.Text = "Feeds";
            // 
            // lblPodcasts
            // 
            this.lblPodcasts.AutoSize = true;
            this.lblPodcasts.Location = new System.Drawing.Point(932, 11);
            this.lblPodcasts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodcasts.Name = "lblPodcasts";
            this.lblPodcasts.Size = new System.Drawing.Size(66, 17);
            this.lblPodcasts.TabIndex = 21;
            this.lblPodcasts.Text = "Podcasts";
            // 
            // lblPodcastDetails
            // 
            this.lblPodcastDetails.AutoSize = true;
            this.lblPodcastDetails.Location = new System.Drawing.Point(1074, 383);
            this.lblPodcastDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodcastDetails.Name = "lblPodcastDetails";
            this.lblPodcastDetails.Size = new System.Drawing.Size(106, 17);
            this.lblPodcastDetails.TabIndex = 22;
            this.lblPodcastDetails.Text = "Podcast Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1458, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.Location = new System.Drawing.Point(648, 324);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(138, 52);
            this.btnAddPodcast.TabIndex = 25;
            this.btnAddPodcast.Text = "Show Podcasts";
            this.btnAddPodcast.UseVisualStyleBackColor = true;
            this.btnAddPodcast.Click += new System.EventHandler(this.btnAddPodcast_Click);
            // 
            // rtbDetails
            // 
            this.rtbDetails.Location = new System.Drawing.Point(851, 408);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.Size = new System.Drawing.Size(532, 265);
            this.rtbDetails.TabIndex = 26;
            this.rtbDetails.Text = "";
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.Location = new System.Drawing.Point(1026, 324);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(184, 44);
            this.btnAddDetails.TabIndex = 27;
            this.btnAddDetails.Text = "Show Details";
            this.btnAddDetails.UseVisualStyleBackColor = true;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(702, 623);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(119, 23);
            this.btnDownload.TabIndex = 28;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDeleteFeed
            // 
            this.btnDeleteFeed.Location = new System.Drawing.Point(118, 427);
            this.btnDeleteFeed.Name = "btnDeleteFeed";
            this.btnDeleteFeed.Size = new System.Drawing.Size(101, 42);
            this.btnDeleteFeed.TabIndex = 29;
            this.btnDeleteFeed.Text = "Delete";
            this.btnDeleteFeed.UseVisualStyleBackColor = true;
            this.btnDeleteFeed.Click += new System.EventHandler(this.btnDeleteFeed_Click);
            // 
            // tbAddCategory
            // 
            this.tbAddCategory.Location = new System.Drawing.Point(33, 59);
            this.tbAddCategory.Name = "tbAddCategory";
            this.tbAddCategory.Size = new System.Drawing.Size(135, 22);
            this.tbAddCategory.TabIndex = 31;
            // 
            // MainInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 702);
            this.Controls.Add(this.tbAddCategory);
            this.Controls.Add(this.btnDeleteFeed);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnAddDetails);
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.btnAddPodcast);
            this.Controls.Add(this.lblPodcastDetails);
            this.Controls.Add(this.lblPodcasts);
            this.Controls.Add(this.lblFeeds);
            this.Controls.Add(this.lblCategoriesAboveList);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnShowAllFeeds);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.lbPodcasts);
            this.Controls.Add(this.lbFeeds);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainInterfaceForm";
            this.Text = "MainInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.ListBox lbFeeds;
        private System.Windows.Forms.ListBox lbPodcasts;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnShowAllFeeds;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblCategoriesAboveList;
        private System.Windows.Forms.Label lblFeeds;
        private System.Windows.Forms.Label lblPodcasts;
        private System.Windows.Forms.Label lblPodcastDetails;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAddPodcast;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDeleteFeed;
        private System.Windows.Forms.TextBox tbAddCategory;
    }
}

