using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using ChartServer.model;
using ChartServer.view;
using ChartServer.util;
using System.Windows.Forms;
using System.Drawing;

namespace ChartServer.server
{
    public class Server
    {
        public static Hashtable onlineServers = new Hashtable();

        public static Hashtable OnlineUsers = new Hashtable();//在线用户数,基于IP和端口号来存储

        public static Hashtable IpPortToUser = new Hashtable();//通过用户账号来查找IP和端口号，从而查找TcpClient

        public static TcpListener tcpListener;

        public static Thread thread;

        public static UpdateServer us;

        public static UpdateUser updateUser;

        public static volatile Boolean runing = false;

        static Object locker = new Object();

        public static LogInfo log;

        public static MainForm mainForm;

        public static void  ListenerClient(){



            log("TCPListener开始启动监听，线程启动中...", Constant.info, Constant.infoColor);

            if (tcpListener == null)
            {
                log("TCPListener开始启动监听，线程启动中...", Constant.error, Constant.errorColor);
                //错误
                return;
            }
            try
            {
                tcpListener.Start();//开始侦听
            }
            catch
            {
                log("TCPListener监听失败,请检查端口是否被占", Constant.error, Constant.errorColor);
                mainForm.快速关闭ToolStripMenuItem_Click(null,null);
                return;
            }
            
            //us(onlineServers);//刷新数据显示
            log("开始监听用户连接...", Constant.info, Constant.infoColor);
            while (runing)
            {
                try
                {
                    TcpClient tc = tcpListener.AcceptTcpClient();
                    OnlineUserClient ouc = new OnlineUserClient(tc);
                    String id = ouc.getId();
                    OnlineUsers.Add(id, ouc);
                    UpdateUsers();
                    ouc.start();
                }
                catch (SocketException)
                {
                    if (!runing)
                    {
                        log("监听关闭，线程结束", Constant.info, Constant.infoColor);
                        return;
                    }
                }
                catch
                {
                    log("未知错误", Constant.error, Constant.errorColor);
                    return;
                }
            }
            //tcpListener.Stop();
        }

        public static void UpdateUsers()
        {
            List<OnlineUser> ous = new List<OnlineUser>();
            foreach (OnlineUserClient ouc in OnlineUsers.Values)
            {
                ous.Add(ouc.ou);
            }
            log("更新连接用户信息", Constant.info, Constant.infoColor);
           // MessageBox.Show(ous.Count.ToString());
            lock (locker)
            {
                updateUser(ous);
            }
        }

        public static void UpdateServers(List<OnlineServer> oss)
        {
            onlineServers.Clear();

            foreach (OnlineServer os in oss)
            {
                onlineServers.Add(os.id,os);
            }
            log("更新在线服务器信息", Constant.info, Constant.infoColor);
            lock (locker)
            {
                us(oss);
            }
        }

    }
}
