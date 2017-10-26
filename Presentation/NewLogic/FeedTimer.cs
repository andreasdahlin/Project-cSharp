using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLogic
{
    public class FeedTimer : System.Timers.Timer
    {
        public FeedTimer(double intervall) : base(intervall) { }

        public object Podcast { get; set; }
    }
}
