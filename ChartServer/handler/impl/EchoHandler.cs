using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartServer.model;
using ChartServer.server;
using ChartServer.util;

namespace ChartServer.handler.impl
{
   public class EchoHandler:OperatorHandler
    {
       public void execute(TransferProtocol tp)
       {
           ServerColony.id = tp.serverId;
           ServerColony.SERVER_AES_KEY = tp.message;
           ServerColony.log("集群服务器认证完成,本服务器编号:" + ServerColony.id, Constant.info, Constant.infoColor);
           Server.thread.Start();
       }
    }
}
