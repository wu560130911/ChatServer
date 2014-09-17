using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartServer.model
{
    public class Message
    {
        public User fromUser { set; get; }

        public List<User> toUser { get; set; }

        public String message { set; get; }

        public DateTime sendDate { set; get; }

        public Message(){}

        public Message(User fromUser, List<User> toUser)
        {
            this.fromUser = fromUser;
            this.toUser = toUser;
        }
    }
}
