using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_YoutubeExplode
{
    abstract class Command
    {
        public abstract void GetInfo(string url);
        public abstract void Download(string url);
    }
}
