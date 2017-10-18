using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainInterfaceForm : Form
    {
        public MainInterfaceForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void lbFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAllFeeds_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            var newForm = new NewCategoryForm();
            newForm.Show();
        }
    }
}
