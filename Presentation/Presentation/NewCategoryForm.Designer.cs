namespace Presentation
{
    partial class NewCategoryForm
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
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(32, 68);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(185, 22);
            this.tbNewName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(29, 38);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(188, 17);
            this.lblNewCategory.TabIndex = 2;
            this.lblNewCategory.Text = "Välj ett namn på din kategori";
            // 
            // NewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 214);
            this.Controls.Add(this.lblNewCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNewName);
            this.Name = "NewCategoryForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNewCategory;
    }
}