using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Categories
    {
        private string name;

        public Categories(string name)
        {
            this.name = name;
        }

        public void CreateNewCategories()
        {
            Categories sport = new Categories(name);
            Categories health = new Categories(name);
            Categories economy = new Categories(name);
        }
    }
}
