namespace Presentation
{
    partial class RemoveCategory
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
            this.cmbCategoryRemove = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCategoryRemove
            // 
            this.cmbCategoryRemove.FormattingEnabled = true;
            this.cmbCategoryRemove.Location = new System.Drawing.Point(76, 55);
            this.cmbCategoryRemove.Name = "cmbCategoryRemove";
            this.cmbCategoryRemove.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoryRemove.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(73, 35);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(93, 103);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // RemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 298);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategoryRemove);
            this.Name = "RemoveCategory";
            this.Text = "RemoveCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoryRemove;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button Remove;
    }
}