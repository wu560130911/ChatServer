using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartServer.model
{
    public class OnlineServer
    {
        public int id { set; get; }

        public String ipAddress { set; get; }

        public int port { set; get; }

        public DateTime onlineDate { set; get; }

        public int getId()
        {
            return id;
        }
    }
}
