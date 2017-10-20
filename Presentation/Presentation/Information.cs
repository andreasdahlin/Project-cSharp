using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class Information
    {
        private string url;
        private string name;
        private string interval;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Interval
        {
            get { return interval; }
            set { interval = value; }
        }
    }
}
