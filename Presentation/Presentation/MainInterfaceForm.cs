using NewLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
            GetInformation();
        }

        public void GetInformation()
        {
            //Ladda hem XML.
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("podcasts.xml");
            }

            //Skapa en objektrepresentation.
            var dom = new XmlDocument();
            dom.LoadXml(xml);

            //Iterera igenom elementet item.
            foreach (XmlNode item
                in dom.DocumentElement.SelectNodes("Podcast"))
            {
                //Skriv ut dess titel.
                var name = item.SelectSingleNode("name");
                
                lbFeeds.Items.Add(name.InnerText);
            }

            

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

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            string text = lbFeeds.GetItemText(lbFeeds.SelectedItem);
            string newUrl = "";
            var xml = "";
            var choosedXml = "";

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("podcasts.xml");
            }

            //Skapa en objektrepresentation.
            var dom = new XmlDocument();
            dom.LoadXml(xml);

            //Iterera igenom elementet item.
            foreach (XmlNode item
                in dom.DocumentElement.SelectNodes("Podcast"))
            {
                //Skriv ut dess titel.
                var url = item.SelectSingleNode("url");
                newUrl = url.InnerText;
            }

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                choosedXml = client.DownloadString(newUrl);
            }

            //Skapa en objektrepresentation.
            var newDom = new XmlDocument();
            newDom.LoadXml(choosedXml);

            //Iterera igenom elementet item.
            foreach (XmlNode item
                in newDom.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                lbPodcasts.Items.Add(title.InnerText);
            }
        }
    }
}
