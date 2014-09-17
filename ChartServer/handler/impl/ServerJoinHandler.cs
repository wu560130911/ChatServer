using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartServer.model;
using ChartServer.server;

namespace ChartServer.handler.impl
{
    class ServerJoinHandler:OperatorHandler
    {
        public void execute(TransferProtocol tp)
        {
            List<OnlineServer> oss = LitJson.JsonMapper.ToObject<List<OnlineServer>>(tp.message);
            if (oss != null)
            {
                Server.UpdateServers(oss);
            }
        }
    }

    class ServerExitHandler : OperatorHandler
    {
        public void execute(TransferProtocol tp)
        {
            List<OnlineServer> oss = LitJson.JsonMapper.ToObject<List<OnlineServer>>(tp.message);
            if (oss != null)
            {
                Server.UpdateServers(oss);
            }
        }
    }
}
