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

        private List<CategorieObjects> categoryList = new List<CategorieObjects>();

        public Categories()
        {
            CategorieObjects c1 = new CategorieObjects("Health");
            categoryList.Add(c1);
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
