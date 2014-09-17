using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartServer.model
{
    public class Protocol
    {
        public String Code { set; get; }

        public String Message { set; get; }

        public Protocol() { }

        public Protocol(String Code, String Message)
        {
            this.Code = Code;
            this.Message = Message;
        }

        public Protocol(String message)
        {
            if (message == null)
            {
                return;
            }
            if (message.Length < 3)
            {
                return;
            }
            this.Code = message.Substring(0, 3);
            this.Message = message.Substring(3);
        }
    }
}
