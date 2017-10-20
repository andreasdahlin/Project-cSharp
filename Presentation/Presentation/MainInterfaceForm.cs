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
        List<Podcast> podcasts = new List<Podcast>();

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

        private Podcast AddNewPodcast(string url, string name, string interval, string category)
        {
            Podcast podcast = new Podcast { url = url, name = name, interval = interval, category = category };
            return podcast;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text;
            string name = tbName.Text;
            string interval = tbInterval.Text;
            string category = cmbCategory.SelectedItem.ToString();

            
            Podcast podcast = AddNewPodcast(url, name, interval, category);
            podcasts.Add(podcast);

            var serializer = new XmlSerializer(typeof(List<Podcast>));

            using (var stream = new StreamWriter("podcasts.xml")) // Skapar XML filen.
            {
                serializer.Serialize(stream, podcasts);
            }

            using (var stream = new StreamReader("podcasts.xml")) // Läser från XML filen.
            {
                var dePodcasts = (List<Podcast>)serializer.Deserialize(stream);
            }
        }
    }
}
