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
        private Categories categories = new Categories();

        public MainInterfaceForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        public void LoadCategories()
        {
            List<Categories> list = categories.getList();
            foreach (Categories cat in list)
            {
                lbCategories.Items.Add(cat.Name);
            }
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
