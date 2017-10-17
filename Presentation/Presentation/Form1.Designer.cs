namespace Presentation
{
    partial class Form1
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
            this.tbInterval.Location = new System.Drawing.Point(36, 111);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(213, 20);
            this.tbInterval.TabIndex = 1;
            this.tbInterval.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
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
            this.lbFeeds.SelectedIndexChanged += new System.EventHandler(this.lbFeeds_SelectedIndexChanged);
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
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(364, 263);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(96, 42);
            this.btnChangeCategory.TabIndex = 12;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.button5_Click);
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
            this.btnShowAllFeeds.Click += new System.EventHandler(this.btnShowAllFeeds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 460);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

