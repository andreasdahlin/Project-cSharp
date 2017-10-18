using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Categories
    {
        private string name;
        private List<Categories> categoryList = new List<Categories>();

        public Categories(string name)
        {
            this.name = name;
            
        }

        public void CreateNewCategories()
        {

            Categories c1 = new Categories("sport");
            Categories c2 = new Categories("health");
            Categories c3 = new Categories("economy");

            categoryList.Add(c1);
            categoryList.Add(c2);
            categoryList.Add(c3);
        }

        public void LoadCategory()
        {

        }
    }
}
