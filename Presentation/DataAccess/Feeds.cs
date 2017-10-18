using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Feeds
    {
        private string url;
        private string name;
        private int interval;
        private Categories categoryName;
        private string hej; // ta bort sedan

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
        public string Hej { get => hej; set => hej = value; }
        internal Categories CategoryName { get => categoryName; set => categoryName = value; } // ta bort sedan
    }
}
