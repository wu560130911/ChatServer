using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartServer.model
{
    public class TransferProtocol
    {
        public String protocolCode { set; get; }//协议编号

        public String serverId { set; get; }//服务器端编号

        public String clientId { set; get; }//客户端编号

        public String message { set; get; }//协议数据

        public TransferProtocol()
        {
        }

        public TransferProtocol(String protocolCode)
        {
            this.protocolCode = protocolCode;
        }

        
    }
}
