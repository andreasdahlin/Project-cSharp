using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Presentation
{
    public partial class ChangeFeedForm : Form
    {
        public ChangeFeedForm()
        {
            InitializeComponent();
            LoadBox();
            getCategoryInformation();
        }

        public void LoadBox()
        {
            var xmlDocument = XDocument.Load("podcasts.xml");

            var items = from key in xmlDocument.Descendants("name")
                select key.Value;
            cmbChooseFeed.DataSource = items.ToList();
        }

        public void getCategoryInformation()
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

                cmbChangeCategory.Items.Add(name.InnerText);
            }
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            string getInfo = cmbChooseFeed.GetItemText(cmbChooseFeed.SelectedItem);

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
                string stringName = name.InnerText;
                if (getInfo == stringName)
                {
                    XmlNode urlNode = item.SelectSingleNode("url");
                    XmlNode nameNode = item.SelectSingleNode("name");
                    XmlNode intervalNode = item.SelectSingleNode("interval");
                    XmlNode categoryNode = item.SelectSingleNode("category");

                    urlNode.InnerText = tbChangeFeedUrl.Text;
                    nameNode.InnerText = tbChangeFeedName.Text;
                    intervalNode.InnerText = tbChangeFeedInterval.Text;
                    categoryNode.InnerText = cmbChangeCategory.Text;
                }
            }
            dom.Save("podcasts.xml");
            LoadBox();
        }

        private void btnGetFeedInformation_Click(object sender, EventArgs e)
        {
            string getInfo = cmbChooseFeed.GetItemText(cmbChooseFeed.SelectedItem);

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

                var url = item.SelectSingleNode("url");
                var name = item.SelectSingleNode("name");
                var interval = item.SelectSingleNode("interval");
                
                string stringUrl = url.InnerText;
                string stringName = name.InnerText;
                string stringInterval = interval.InnerText;

                if (stringName == getInfo)
                {
                    tbChangeFeedUrl.Text = stringUrl;
                    tbChangeFeedName.Text = stringName;
                    tbChangeFeedInterval.Text = stringInterval;
                }
            }
        }
    }
}
