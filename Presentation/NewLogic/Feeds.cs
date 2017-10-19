using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLogic
{
    class Feeds
    {
        private string url;
        private string name;
        private int interval;
        private Categories categoryName;

        public Feeds(string url, string name, int interval, Categories categoryName)
        {
            this.Url = url;
            this.Name = name;
            this.Interval = interval;
            this.CategoryName = categoryName;
        }

        public string Url { get => url; set => url = value; }
        public string Name { get => name; set => name = value; }
        public int Interval { get => interval; set => interval = value; }
        internal Categories CategoryName { get => categoryName; set => categoryName = value; } 
    }
}
