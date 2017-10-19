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

        public List<CategorieObjects> categoryList = new List<CategorieObjects>();

        public Categories()
        {
            CategorieObjects c1 = new CategorieObjects("Health");
            CategorieObjects c2 = new CategorieObjects("Music");
            CategorieObjects c3 = new CategorieObjects("Sport");
            categoryList.Add(c1);
            categoryList.Add(c2);
            categoryList.Add(c3);
        }

        public void CreateNewCategories()
        {
            //categoryList.Add(new Categories { name = "Health" });
            //categoryList.Add(new Categories { name = "Economy" });
            //categoryList.Add(new Categories { name = "Sport" });
        }

        public List<CategorieObjects> getList()
        {
            return categoryList;
        }

        public void LoadCategory()
        {

        }
    }
}
