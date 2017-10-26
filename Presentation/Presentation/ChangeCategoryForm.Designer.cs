namespace Presentation
{
    partial class ChangeCategoryForm
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
            this.lblChooseACategory = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChooseACategory
            // 
            this.lblChooseACategory.AutoSize = true;
            this.lblChooseACategory.Location = new System.Drawing.Point(41, 57);
            this.lblChooseACategory.Name = "lblChooseACategory";
            this.lblChooseACategory.Size = new System.Drawing.Size(127, 17);
            this.lblChooseACategory.TabIndex = 0;
            this.lblChooseACategory.Text = "Choose a category";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(44, 87);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(186, 24);
            this.cmbCategories.TabIndex = 1;
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(60, 216);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(146, 40);
            this.btnChangeCategory.TabIndex = 2;
            this.btnChangeCategory.Text = "Change category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(44, 165);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(186, 22);
            this.tbNewName.TabIndex = 3;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(41, 135);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(121, 17);
            this.lblNewName.TabIndex = 4;
            this.lblNewName.Text = "Write a new name";
            // 
            // ChangeCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 316);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblChooseACategory);
            this.Name = "ChangeCategoryForm";
            this.Text = "ChangeCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseACategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnChangeCategory;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label lblNewName;
    }
}