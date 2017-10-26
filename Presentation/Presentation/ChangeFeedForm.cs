using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentation
{
    public partial class ChangeFeedForm : Form
    {
        public ChangeFeedForm()
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

       
    }
}
