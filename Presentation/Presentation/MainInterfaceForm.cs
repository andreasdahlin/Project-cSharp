using NewLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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
            if (File.Exists("myXmlDoc.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream read = new FileStream("myXmlDoc.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information info = (Information)xs.Deserialize(read);

                tbUrl.Text = info.Url;
                var test = tbName.Text = info.Name;
                tbInterval.Text = info.Interval;

                lbFeeds.Items.Add(test);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Information info = new Information();
                info.Url = tbUrl.Text;
                info.Name = tbName.Text;
                info.Interval = tbInterval.Text;
                SaveXML.SaveData(info, "myXmlDoc.xml");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
