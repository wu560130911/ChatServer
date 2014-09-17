using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartServer.model
{
    public class OnlineUser
    {
        public User user { set; get; }

        public String ipAddress { set; get; }

        public int port{set;get;}

        public String serverId { set; get; }

        public String id { set; get; }

        public DateTime joinDate { set; get; }
    }
}
