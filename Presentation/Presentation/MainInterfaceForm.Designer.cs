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
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(48, 44);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(283, 22);
            this.tbUrl.TabIndex = 0;
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(47, 139);
            this.tbInterval.Margin = new System.Windows.Forms.Padding(4);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(283, 22);
            this.tbInterval.TabIndex = 1;
            this.tbInterval.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(53, 202);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(276, 24);
            this.cmbCategory.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(47, 92);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(283, 22);
            this.tbName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 260);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(203, 260);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(128, 52);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 336);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 52);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.lbFeeds.SelectedIndexChanged += new System.EventHandler(this.lbFeeds_SelectedIndexChanged);
            // 
            // lbPodcasts
            // 
            this.lbPodcasts.FormattingEnabled = true;
            this.lbPodcasts.ItemHeight = 16;
            this.lbPodcasts.Location = new System.Drawing.Point(857, 44);
            this.lbPodcasts.Margin = new System.Windows.Forms.Padding(4);
            this.lbPodcasts.Name = "lbPodcasts";
            this.lbPodcasts.Size = new System.Drawing.Size(193, 260);
            this.lbPodcasts.TabIndex = 9;
            // 
            // lbDetailedPodcasts
            // 
            this.lbDetailedPodcasts.FormattingEnabled = true;
            this.lbDetailedPodcasts.ItemHeight = 16;
            this.lbDetailedPodcasts.Location = new System.Drawing.Point(1084, 44);
            this.lbDetailedPodcasts.Margin = new System.Windows.Forms.Padding(4);
            this.lbDetailedPodcasts.Name = "lbDetailedPodcasts";
            this.lbDetailedPodcasts.Size = new System.Drawing.Size(244, 260);
            this.lbDetailedPodcasts.TabIndex = 10;
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(337, 324);
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
            this.btnChangeCategory.Location = new System.Drawing.Point(485, 323);
            this.btnChangeCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(128, 52);
            this.btnChangeCategory.TabIndex = 12;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(337, 383);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(128, 52);
            this.btnDeleteCategory.TabIndex = 13;
            this.btnDeleteCategory.Text = "Remove Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnShowAllFeeds
            // 
            this.btnShowAllFeeds.Location = new System.Drawing.Point(485, 383);
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
            this.lblUrl.Location = new System.Drawing.Point(168, 23);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 17);
            this.lblUrl.TabIndex = 15;
            this.lblUrl.Text = "URL";
            this.lblUrl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(168, 73);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Namn";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(159, 118);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(54, 17);
            this.lblInterval.TabIndex = 17;
            this.lblInterval.Text = "Interval";
            this.lblInterval.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(148, 182);
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
            this.lblCategoriesAboveList.Click += new System.EventHandler(this.label5_Click);
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
            this.lblPodcasts.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblPodcastDetails
            // 
            this.lblPodcastDetails.AutoSize = true;
            this.lblPodcastDetails.Location = new System.Drawing.Point(1147, 11);
            this.lblPodcastDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodcastDetails.Name = "lblPodcastDetails";
            this.lblPodcastDetails.Size = new System.Drawing.Size(106, 17);
            this.lblPodcastDetails.TabIndex = 22;
            this.lblPodcastDetails.Text = "Podcast Details";
            // 
            // MainInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 460);
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
    }
}

