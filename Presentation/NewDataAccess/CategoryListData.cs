using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDataAccess
{
    public class CategoryListData
    {
        private List<DataCategories> categoryList = new List<DataCategories>();

        public List<DataCategories> CategoryList { get => categoryList; set => categoryList = value; }
    }
}
