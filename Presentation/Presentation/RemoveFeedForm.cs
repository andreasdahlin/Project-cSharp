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
    public partial class RemoveFeedForm : Form
    {
        private string xml;
        private string name;

        public RemoveFeedForm()
        {
            InitializeComponent();
            LoadBox();
        }

        public void LoadBox()
        {
            var xmlDocument = XDocument.Load("podcasts.xml");

            var items = from key in xmlDocument.Descendants("name")
                        select key.Value;
            cmbChoseFeed.DataSource = items.ToList();
        }

        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {
            if (Validering.isComboBoxEmpty(cmbChoseFeed))
            {
                string getFeed = cmbChoseFeed.GetItemText(cmbChoseFeed.SelectedItem);

                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString("podcasts.xml");
                }

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);

                foreach (XmlNode node in doc.SelectNodes("//Podcast//name"))
                {

                    if (node.InnerText == getFeed)
                    {
                        XmlNode parents = node.ParentNode;
                        parents.ParentNode.RemoveChild(parents);
                        doc.Save("podcasts.xml");
                        MessageBox.Show("Feed är borttagen.");
                    }
                }
            }


        }
    }
}
