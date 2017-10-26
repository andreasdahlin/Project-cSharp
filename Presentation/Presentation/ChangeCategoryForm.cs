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

namespace Presentation
{
    public partial class ChangeCategoryForm : Form
    {
        public ChangeCategoryForm()
        {
            InitializeComponent();
            getCategoryInformation();
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {

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

                cmbCategories.Items.Add(name.InnerText);
            }
        }
    }
}
