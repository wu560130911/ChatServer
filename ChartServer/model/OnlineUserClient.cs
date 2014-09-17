using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;//为了IPEndPoint而添加的引用
using System.Threading;
using ChartServer.server;
using System.Windows.Forms;

namespace ChartServer.model
{
    public class OnlineUserClient
    {
        public TcpClient client { set; get; }

        public OnlineUser ou { set; get; }

        private NetworkStream stream;

        StreamWriter sw ;

        StreamReader sr;

        Thread thread;
        public OnlineUserClient(TcpClient client)
        {
            this.client = client;
            this.stream = client.GetStream();

            sw = new StreamWriter(stream);
            sr = new StreamReader(stream);

            ou = new OnlineUser();

            var ip = (client.Client.RemoteEndPoint as IPEndPoint).Address;
            var port = (client.Client.RemoteEndPoint as IPEndPoint).Port;

        }

        public void start()
        {
            thread = new Thread(this.run);
            thread.Start();
        }

        public Boolean sendMessage(String message)
        {
            try
            {
                sw.WriteLine(message);
                sw.Flush();
                stream.Flush();

            }catch(IOException e){
                return false;
            }
            
            return true;
        }

        public String getId()
        {
            return ou.id;
        }

        public void run()
        {
            while (true)
            {
                String message = null;
                try
                {
                    message = sr.ReadLine();
                }
                catch (IOException)
                {
                    quit();
                    //处理退出事件
                    return;
                }
                if (message == null)
                {
                    quit();
                    //处理退出时间
                }
                //处理逻辑
                MessageBox.Show(message);
            }
        }

        private void quit()
        {
            Server.OnlineUsers.Remove(getId());
            //client.Close();
            Server.UpdateUsers();
        }
    }
}
