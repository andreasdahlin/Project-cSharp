namespace Presentation
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.lbFeeds = new System.Windows.Forms.ListBox();
            this.lbPodcasts = new System.Windows.Forms.ListBox();
            this.lbDetailedPodcasts = new System.Windows.Forms.ListBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(36, 36);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(213, 20);
            this.tbUrl.TabIndex = 0;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(35, 113);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(213, 20);
            this.tbInterval.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(40, 164);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(208, 21);
            this.cmbCategory.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(35, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(213, 20);
            this.tbName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(152, 211);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(96, 42);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(90, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(282, 35);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(145, 212);
            this.lbCategories.TabIndex = 7;
            // 
            // lbFeeds
            // 
            this.lbFeeds.FormattingEnabled = true;
            this.lbFeeds.Location = new System.Drawing.Point(462, 36);
            this.lbFeeds.Name = "lbFeeds";
            this.lbFeeds.Size = new System.Drawing.Size(149, 212);
            this.lbFeeds.TabIndex = 8;
            // 
            // lbPodcasts
            // 
            this.lbPodcasts.FormattingEnabled = true;
            this.lbPodcasts.Location = new System.Drawing.Point(643, 36);
            this.lbPodcasts.Name = "lbPodcasts";
            this.lbPodcasts.Size = new System.Drawing.Size(146, 212);
            this.lbPodcasts.TabIndex = 9;
            // 
            // lbDetailedPodcasts
            // 
            this.lbDetailedPodcasts.FormattingEnabled = true;
            this.lbDetailedPodcasts.Location = new System.Drawing.Point(813, 36);
            this.lbDetailedPodcasts.Name = "lbDetailedPodcasts";
            this.lbDetailedPodcasts.Size = new System.Drawing.Size(184, 212);
            this.lbDetailedPodcasts.TabIndex = 10;
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(253, 263);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(96, 42);
            this.btnCategoryAdd.TabIndex = 11;
            this.btnCategoryAdd.Text = "Add Category";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(364, 262);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(96, 42);
            this.btnChangeCategory.TabIndex = 12;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(253, 311);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(96, 42);
            this.btnDeleteCategory.TabIndex = 13;
            this.btnDeleteCategory.Text = "Remove Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnShowAllFeeds
            // 
            this.btnShowAllFeeds.Location = new System.Drawing.Point(364, 311);
            this.btnShowAllFeeds.Name = "btnShowAllFeeds";
            this.btnShowAllFeeds.Size = new System.Drawing.Size(96, 42);
            this.btnShowAllFeeds.TabIndex = 14;
            this.btnShowAllFeeds.Text = "Show All Feeds";
            this.btnShowAllFeeds.UseVisualStyleBackColor = true;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(126, 19);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 15;
            this.lblUrl.Text = "URL";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(126, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Namn";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(119, 96);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(42, 13);
            this.lblInterval.TabIndex = 17;
            this.lblInterval.Text = "Interval";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(111, 148);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(57, 13);
            this.lblCategories.TabIndex = 18;
            this.lblCategories.Text = "Categories";
            // 
            // lblCategoriesAboveList
            // 
            this.lblCategoriesAboveList.AutoSize = true;
            this.lblCategoriesAboveList.Location = new System.Drawing.Point(320, 9);
            this.lblCategoriesAboveList.Name = "lblCategoriesAboveList";
            this.lblCategoriesAboveList.Size = new System.Drawing.Size(57, 13);
            this.lblCategoriesAboveList.TabIndex = 19;
            this.lblCategoriesAboveList.Text = "Categories";
            // 
            // lblFeeds
            // 
            this.lblFeeds.AutoSize = true;
            this.lblFeeds.Location = new System.Drawing.Point(524, 9);
            this.lblFeeds.Name = "lblFeeds";
            this.lblFeeds.Size = new System.Drawing.Size(36, 13);
            this.lblFeeds.TabIndex = 20;
            this.lblFeeds.Text = "Feeds";
            // 
            // lblPodcasts
            // 
            this.lblPodcasts.AutoSize = true;
            this.lblPodcasts.Location = new System.Drawing.Point(699, 9);
            this.lblPodcasts.Name = "lblPodcasts";
            this.lblPodcasts.Size = new System.Drawing.Size(51, 13);
            this.lblPodcasts.TabIndex = 21;
            this.lblPodcasts.Text = "Podcasts";
            // 
            // lblPodcastDetails
            // 
            this.lblPodcastDetails.AutoSize = true;
            this.lblPodcastDetails.Location = new System.Drawing.Point(860, 9);
            this.lblPodcastDetails.Name = "lblPodcastDetails";
            this.lblPodcastDetails.Size = new System.Drawing.Size(81, 13);
            this.lblPodcastDetails.TabIndex = 22;
            this.lblPodcastDetails.Text = "Podcast Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "label2";
            // 
            // MainInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.lbDetailedPodcasts);
            this.Controls.Add(this.lbPodcasts);
            this.Controls.Add(this.lbFeeds);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainInterfaceForm";
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.MainInterfaceForm_Load);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.ListBox lbFeeds;
        private System.Windows.Forms.ListBox lbPodcasts;
        private System.Windows.Forms.ListBox lbDetailedPodcasts;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

