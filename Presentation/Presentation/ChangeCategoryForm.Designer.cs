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
            this.cmbCategoryToRemove = new System.Windows.Forms.ComboBox();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.lblPickACategoryToRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategoryToRemove
            // 
            this.cmbCategoryToRemove.FormattingEnabled = true;
            this.cmbCategoryToRemove.Location = new System.Drawing.Point(37, 77);
            this.cmbCategoryToRemove.Name = "cmbCategoryToRemove";
            this.cmbCategoryToRemove.Size = new System.Drawing.Size(194, 24);
            this.cmbCategoryToRemove.TabIndex = 0;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(84, 127);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(96, 38);
            this.btnRemoveCategory.TabIndex = 1;
            this.btnRemoveCategory.Text = "Remove";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // lblPickACategoryToRemove
            // 
            this.lblPickACategoryToRemove.AutoSize = true;
            this.lblPickACategoryToRemove.Location = new System.Drawing.Point(34, 48);
            this.lblPickACategoryToRemove.Name = "lblPickACategoryToRemove";
            this.lblPickACategoryToRemove.Size = new System.Drawing.Size(119, 17);
            this.lblPickACategoryToRemove.TabIndex = 2;
            this.lblPickACategoryToRemove.Text = "Chose a category";
            // 
            // ChangeCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 208);
            this.Controls.Add(this.lblPickACategoryToRemove);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.cmbCategoryToRemove);
            this.Name = "ChangeCategoryForm";
            this.Text = "ChangeCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoryToRemove;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Label lblPickACategoryToRemove;
    }
}