using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Categories
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private List<Categories> categoryList = new List<Categories>();

        public Categories()
        {
            CreateNewCategories();
        }

        public void CreateNewCategories()
        {
            categoryList.Add(new Categories { Name = "Health" });
            categoryList.Add(new Categories { Name = "Economy" });
            categoryList.Add(new Categories { Name = "Sport" });
        }

        public List<Categories> getList()
        {
            return categoryList;
        }

        public void LoadCategory()
        {

        }
    }
}
