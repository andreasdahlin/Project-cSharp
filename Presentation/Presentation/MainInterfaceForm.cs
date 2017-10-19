using NewLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Presentation
{
    public partial class MainInterfaceForm : Form
    {
        public Categories categories = new Categories();

        public MainInterfaceForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadXml();
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

        private void LoadXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://vokalnow.com/static/feeds/podcast.xml");

            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("*");

            foreach (XmlNode node in nodes)
            {
                string title = node["title"].InnerText;
                string desc = node["description"].InnerText;

                lbFeeds.Items.Add(title);
                lbDetailedPodcasts.Items.Add(desc);



            }
        }
    }
}
