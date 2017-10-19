﻿using System;
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
        public Categories categories = new Categories();

        public MainInterfaceForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        public void LoadCategories()
        {
            lbCategories.Items.Clear();

            List<CategorieObjects> list = categories.getList();
            foreach (CategorieObjects cat in list)
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
