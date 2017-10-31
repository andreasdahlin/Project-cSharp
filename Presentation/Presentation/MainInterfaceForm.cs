using NewLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Presentation
{
    public partial class MainInterfaceForm : Form
    {


        //public Categories categories = new Categories();
        private List<Podcast> podcasts = new List<Podcast>();
        private List<Categories> categories = new List<Categories>();
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
        private XmlSerializer serializerForCat = new XmlSerializer(typeof(List<Categories>));
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private string newUrl = "";
        private string newestText = "";
        private string choosedXml = "";
        private string url = "";
        private string newMp3Text = "";
        private int intervalInt;




        public MainInterfaceForm()
        {
            InitializeComponent();
            //LoadCategories();
            GetInformation();
            GetCategoryInformation();
            LoadCategoryBox();
            CleanAll();
            LoadXML();


        }


        private void LoadXML()
        {
            using (var stream = new StreamReader("podcasts.xml")) // Läser från XML filen.
            {
                podcasts = (List<Podcast>) serializer.Deserialize(stream);
            }

            using(var stream = new StreamReader("categories.xml")) // Läser från XML filen.
            {
                categories = (List<Categories>)serializerForCat.Deserialize(stream);
            }
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
            LoadXML();
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

        public void ClearCategoryList()
        {
            lbCategories.Items.Clear();
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
        private Categories AddNewCategory(string categoryName)
        {
            Categories category = new Categories { Name = categoryName };
            return category;
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (Validering.EmptyTextField(tbAddCategory))
            {
                ClearCategoryList();

                string category = tbAddCategory.Text;
                Categories categoryNew = AddNewCategory(category);
                categories.Add(categoryNew);



                using (var stream = new StreamWriter("categories.xml")) // Skapar XML filen.
                {
                    serializerForCat.Serialize(stream, categories);
                }
                GetCategoryInformation();
                LoadCategoryBox();
            }
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            var newChangeCategoryForm = new ChangeCategoryForm();
            newChangeCategoryForm.Show();
        }

        private Podcast AddNewPodcast(string url, string name, int interval, string category)
        {
            Podcast podcast = new Podcast
            {
                url = url,
                name = name,
                interval = interval * 60000,
                category = category,
               
            };
            return podcast;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validering.EmptyTextField(tbUrl) && Validering.IsUrlCorrect(tbUrl) && Validering.EmptyTextField(tbName) && Validering.EmptyTextField(tbInterval) && Validering.EmptyInterval(tbInterval)
                && Validering.isComboBoxEmpty(cmbCategory))
            {
                string url = tbUrl.Text;
                string name = tbName.Text;
                int interval = Convert.ToInt32(tbInterval.Text);
                string category = cmbCategory.SelectedItem.ToString();



                Podcast podcast = AddNewPodcast(url, name, interval, category);
                podcasts.Add(podcast);


                using (var stream = new StreamWriter("podcasts.xml")) // Skapar XML filen.
                {
                    serializer.Serialize(stream, podcasts);
                }

                MessageBox.Show("Feed added.");
                ClearListBox();
            }
        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                FillWithPodcasts();
                string newText = lbFeeds.GetItemText(lbFeeds.SelectedItem);
                var newXml = "";

                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    newXml = client.DownloadString("podcasts.xml");
                }

                var newTextDom = new XmlDocument();
                newTextDom.LoadXml(newXml);

                foreach (XmlNode item
                    in newTextDom.DocumentElement.SelectNodes("Podcast"))
                {

                    var newTextTwo = item.SelectSingleNode("name");
                    newestText = newTextTwo.InnerText;
                    if (newestText == newText)
                    {
                        string interval = item.SelectSingleNode("interval").InnerText;
                        intervalInt = Convert.ToInt32(interval);
                        break;
                    }
                }
                timer.Interval = intervalInt;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();

            }
            catch (Exception)
            {
                MessageBox.Show("Du har inte valt någon feed.");
            }
            
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            FillWithPodcasts();
        }

        private void FillWithPodcasts()
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
            try
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
            catch (Exception)
            {
                MessageBox.Show("Du har inte valt en podcast.");
            }
           

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            
            try
            {
                MessageBox.Show("Nedladdning pågår.");

                using (var client = new WebClient())
                {
                    client.DownloadFile(newMp3Text, "podcast.mp3");
                    
                }
                MessageBox.Show("Nedladdning klar. Finns att hämta i debug-mappen.");

            }
            catch (Exception)
            {
                MessageBox.Show("No file to download");
            }
        }

        private void btnShowAllFeeds_Click(object sender, EventArgs e)
        {
            try
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
                        MessageBox.Show("There are no feeds in this category.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Du har inga feeds.");
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

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var deleteForm = new RemoveCategory();
            deleteForm.Show();
             
        }

        private void tbInterval_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
