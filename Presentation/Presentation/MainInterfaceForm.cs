using NewLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Presentation
{
    public partial class MainInterfaceForm : Form
    {
        private updateIntervall updateIntervall;

        //public Categories categories = new Categories();
        private List<Podcast> podcasts = new List<Podcast>();

        private string newUrl = "";
        private string newestText = "";
        private string choosedXml = "";
        private string url = "";
        private string newMp3Text = "";



        public MainInterfaceForm()
        {
            InitializeComponent();
            //LoadCategories();
            //GetInformation();
            GetCategoryInformation();
            updateIntervall = new updateIntervall();
            updateIntervall.EnableIntervalUpdateForFeeds(podcasts);
            LoadCategoryBox();
            CleanAll();
        }

        public void CleanAll()
        {
            lbFeeds.Items.Clear();
            lbPodcasts.Items.Clear();
            rtbDetails.Text = "";

        }

        public void GetInformation()
        {
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("podcasts.xml");
            }

            var dom = new XmlDocument();
            dom.LoadXml(xml);

            foreach (XmlNode item
                in dom.DocumentElement.SelectNodes("Podcast"))
            {

                var name = item.SelectSingleNode("name");

                lbFeeds.Items.Add(name.InnerText);
            }

        }

        public void GetCategoryInformation()
        {
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("categories.xml");
            }

            var dom = new XmlDocument();
            dom.LoadXml(xml);

            foreach (XmlNode item
                in dom.DocumentElement.SelectNodes("Categories"))
            {

                var name = item.SelectSingleNode("Name");

                lbCategories.Items.Add(name.InnerText);
            }

        }

        public void LoadCategoryBox()
        {
            var xmlDocument = XDocument.Load("categories.xml");

            var items = from key in xmlDocument.Descendants("Name")
                select key.Value;
            cmbCategory.DataSource = items.ToList();
        }

        public void ClearRichTextBox()
        {
            rtbDetails.Text = "";
        }

        public void ClearListBox()
        {
            lbFeeds.Items.Clear();

        }

        public void ClearListBoxTwo()
        {
            lbPodcasts.Items.Clear();
        }

        //public void LoadCategories()
        //{
        //    lbCategories.Items.Clear();

        //    List<CategorieObjects> list = categories.getList();
        //    foreach (CategorieObjects cat in list)
        //    {
        //        lbCategories.Items.Add(cat.Name);
        //    }
        //}

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

        private Podcast AddNewPodcast(string url, string name, double interval, string category)
        {
            Podcast podcast = new Podcast {url = url, name = name, interval = interval, category = category};
            return podcast;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text;
            string name = tbName.Text;
            double interval = Convert.ToDouble(tbInterval.Text);
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
                var dePodcasts = (List<Podcast>) serializer.Deserialize(stream);
            }
            ClearListBox();
            GetInformation();

        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            ClearListBoxTwo();
            string text = lbFeeds.GetItemText(lbFeeds.SelectedItem);
            var xml = "";

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("podcasts.xml");
            }

            var textDom = new XmlDocument();
            textDom.LoadXml(xml);

            foreach (XmlNode item
                in textDom.DocumentElement.SelectNodes("Podcast"))
            {

                var newText = item.SelectSingleNode("name");
                newestText = newText.InnerText;
                if (text == newestText)
                {
                    url = item.SelectSingleNode("url").InnerText;

                    break;
                }

            }


            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                choosedXml = client.DownloadString(url);
            }

            var newDom = new XmlDocument();
            newDom.LoadXml(choosedXml);

            foreach (XmlNode item
                in newDom.DocumentElement.SelectNodes("channel/item"))
            {

                var title = item.SelectSingleNode("title");
                lbPodcasts.Items.Add(title.InnerText);
            }
        }




        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            ClearRichTextBox();
            string text = lbPodcasts.GetItemText(lbPodcasts.SelectedItem);
            var xml = "";


            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            var newDomTest = new XmlDocument();
            newDomTest.LoadXml(xml);

            foreach (XmlNode item
                in newDomTest.DocumentElement.SelectNodes("channel/item"))
            {

                var titleName = item.SelectSingleNode("title");
                string specTitle = titleName.InnerText;

                if (specTitle == text)
                {
                    var date = item.SelectSingleNode("pubDate");
                    var newDesc = item.SelectSingleNode("description");
                    var link = item.SelectSingleNode("link");
                    var mp3 = item.SelectSingleNode("enclosure[@url]");
                    if (mp3 != null)
                    {
                        string mp3Text = mp3.OuterXml;
                        Char Delimiter = '"';
                        String[] substrings = mp3Text.Split(Delimiter);
                        newMp3Text = substrings[1];
                    }
                    rtbDetails.AppendText("Släpptes: \n" + date.InnerText + " \n \n" + "Om avsnittet: \n" +
                                          newDesc.InnerText + "\n \n" + "Länk till avsnitt: \n" + link.InnerText +
                                          "\n");
                }
            }

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(newMp3Text, "podcast.mp3");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Det finns ingen fil att ladda ner.");
            }
        }

        private void btnShowAllFeeds_Click(object sender, EventArgs e)
        {
            CleanAll();
            string getCategory = lbCategories.GetItemText(lbCategories.SelectedItem);
            string newestCategory = "";
            string name = "";

            var xml = "";

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("podcasts.xml");
            }

            var textDom = new XmlDocument();
            textDom.LoadXml(xml);

            foreach (XmlNode item
                in textDom.DocumentElement.SelectNodes("Podcast"))
            {

                var newCategory = item.SelectSingleNode("category");
                newestCategory = newCategory.InnerText;
                if (getCategory == newestCategory)
                {
                    name = item.SelectSingleNode("name").InnerText;
                    lbFeeds.Items.Add(name);
                }

                else
                {
                    MessageBox.Show("Inga feeds i vald kategori.");
                }



            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var newForm = new ChangeFeedForm();
            newForm.Show();
        }

        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {
            var newForm = new RemoveFeedForm();
            newForm.Show();
        }
    }
}
