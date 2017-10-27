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
    internal partial class RemoveCategory : Form
    {
        private string xml;
        private string name;
        private string categoryXml;

        public RemoveCategory()
        {
            InitializeComponent();
            LoadCategoryBox();
        }

        public void LoadCategoryBox()
        {
            var xmlDocument = XDocument.Load("categories.xml");

            var items = from key in xmlDocument.Descendants("Name")
                select key.Value;
            cmbCategoryRemove.DataSource = items.ToList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string getFeed = cmbCategoryRemove.GetItemText(cmbCategoryRemove.SelectedItem);

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                categoryXml = client.DownloadString("categories.xml");
            }

            XmlDocument catDoc = new XmlDocument();
            
            catDoc.LoadXml(categoryXml);


            foreach(XmlNode node in catDoc.SelectNodes("//Categories//Name"))
            {

                if (node.InnerText == getFeed)
                {
                    XmlNode parents = node.ParentNode;
                    parents.ParentNode.RemoveChild(parents);
                    catDoc.Save("categories.xml");
                }
            }
            }
        }
}
