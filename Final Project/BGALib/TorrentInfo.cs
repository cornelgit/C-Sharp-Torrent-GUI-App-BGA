using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGALib
{
    public class TorrentInfo
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Speed { get; set; }
        public double Progress { get; set; }
        public string Eta { get; set; }
    }
}
