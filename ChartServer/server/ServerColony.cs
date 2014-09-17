using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using ChartServer.model;
using ChartServer.view;
using ChartServer.util;
using System.Collections;
using ChartServer.handler;
using ChartServer.handler.impl;
using System.IO;

namespace ChartServer.server
{
    public class ServerColony
    {
        public static Hashtable SERVER_RESPONSED = new Hashtable();
     
        public static String id;

        public static Thread thread = null;

        public static TcpClient socket = null;

        public static volatile Boolean runing = false;

        public static LogInfo log;

        public static NetworkStream stream;

        public static StreamReader reader;

        public static StreamWriter writer;

        public static String SERVER_AES_KEY = null;

        //C#静态代码块
        static ServerColony()
        {
            SERVER_RESPONSED.Add("402", new EchoHandler());
            SERVER_RESPONSED.Add("403",new ServerJoinHandler());
            SERVER_RESPONSED.Add("404", new ServerExitHandler());
        }
     

        public ServerColony()
        {
            if (MainForm.isColony)
            {
                log("初始化连接集群服务器...", Constant.info, Constant.infoColor);
                socket = new TcpClient(MainForm.serverIp,MainForm.serverPort);
                stream = socket.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                thread = new Thread(connectionServer);
                runing = true;
                log("初始化连接集群服务器完成，开始获取认证服务器", Constant.info, Constant.infoColor);
                thread.Start();
                log("初始化连接集群服务器完成，发送认证服务器请求", Constant.info, Constant.infoColor);
                //TransferProtocol tp = new TransferProtocol("302");
                //sendMessage(tp);
            }
        }

        public static void sendMessage(TransferProtocol tp)
        {
            String message = LitJson.JsonMapper.ToJson(tp);

            if (writer != null)
            {
                try
                {
                    message = AESCryptos.AESEncrypt(message,SERVER_AES_KEY);

                    writer.WriteLine(message);

                    writer.Flush();

                    stream.Flush();
                }
                catch
                {

                }
            }
        }
      
        public static void connectionServer()
        {
            log("初始化连接集群服务器完成，获取认证服务器线程开启...", Constant.info, Constant.infoColor);
            while (runing)
            {
                String message = null;

                try
                {
                    message = reader.ReadLine();
                }
                catch (System.Exception ex)
                {
                    //Close();
                    break;
                }
                if (message == null)
                {
                   // Close();
                    break;
                }

                if (message.Length < 3)
                {
                    continue;
                }
               
                log(message, Constant.info, Constant.infoColor);
               
                if (SERVER_AES_KEY != null)
                {
                    message = AESCryptos.Decrypt(message, SERVER_AES_KEY);
                }

                //log(SERVER_AES_KEY, Constant.info, Constant.infoColor);

                log(message, Constant.info, Constant.infoColor);
                TransferProtocol tp = null;
                try
                {
                    tp = LitJson.JsonMapper.ToObject<TransferProtocol>(message);
                }
                catch (LitJson.JsonException)
                {

                }
                if (tp == null)
                {
                    continue;
                }
                String code = tp.protocolCode;
                if (code == null || "".Equals(code))
                {
                    continue;
                }
                if (SERVER_RESPONSED.ContainsKey(code))
                {
                    OperatorHandler handler = (OperatorHandler)SERVER_RESPONSED[code];
                    handler.execute(tp);
                }
                
            }
        }
    }
}
