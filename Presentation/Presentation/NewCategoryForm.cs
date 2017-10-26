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
using System.Xml.Serialization;
using NewLogic;
using System.IO;
using System.Xml.Linq;

namespace Presentation
{
    public partial class NewCategoryForm : Form
    {
        
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Categories>));
        private List<Categories> categories = new List<Categories>();

        public NewCategoryForm()
        {
            InitializeComponent();
            LoadXML();
        }

        private void LoadXML()
        {
            using (var stream = new StreamReader("categories.xml")) // Läser från XML filen.
            {
                categories = (List<Categories>)serializer.Deserialize(stream);
            }
        }

        private Categories AddNewCategory(string categoryName)
        {
            Categories category = new Categories { Name = categoryName };
            return category;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string category = tbNewName.Text;
            Categories categoryNew = AddNewCategory(category);
            categories.Add(categoryNew);
           


            using (var stream = new StreamWriter("categories.xml")) // Skapar XML filen.
            {
                serializer.Serialize(stream, categories);
            }
            

        }
    }

     

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string name = tbNewName.Text;
        //    CategorieObjects c1 = new CategorieObjects(name);
        //    mainForm.categories.categoryList.Add(c1);
        //    mainForm.Show();
        //    mainForm.LoadCategories();
        //    this.Dispose();
        //}
    }

