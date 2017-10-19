using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLogic;

namespace Presentation
{
    public partial class NewCategoryForm : Form
    {
        private MainInterfaceForm mainForm = new MainInterfaceForm();
        private Categories categories = new Categories();

        public NewCategoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbNewName.Text;
            CategorieObjects c1 = new CategorieObjects(name);
            mainForm.categories.categoryList.Add(c1);
            mainForm.Show();
            mainForm.LoadCategories();
            this.Dispose();
        }
    }
}
