using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartServer.model
{
    public class User
    {
        public string id { set; get; }
        public string name { set; get; }
        public string password { set; get; }
        public DateTime registerDate { set; get; }
        public String ip { set; get; }


        public User() { }

       public User(String id)
        {
            this.id = id;
        }

       public User(String id, String password)
       {
           this.id = id;
           this.password = password;
       }
    }
}
