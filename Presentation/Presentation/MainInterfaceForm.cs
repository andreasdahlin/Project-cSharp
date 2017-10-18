using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Presentation
{
    public partial class MainInterfaceForm : Form
    {
        public MainInterfaceForm()
        {
            InitializeComponent();
            Categories category = new Categories("sport");
            category.CreateNewCategories();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            var newForm = new NewCategoryForm();
            newForm.Show();
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            var newChangeCategoryForm = new ChangeCategoryForm();
            newChangeCategoryForm.Show();
        }

        private void MainInterfaceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
