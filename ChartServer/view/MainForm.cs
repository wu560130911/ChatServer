using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartServer.model;
using ChartServer.server;
using ChartServer.util;
using System.Net;
using System.Threading;

namespace ChartServer.view
{

    public delegate void UpdateServer(List<OnlineServer> onlineServers);

    public delegate void UpdateUser(List<OnlineUser> ous);

    public delegate void LogInfo(String message,Font font,Color color);

    public partial class MainForm : Form
    {

        public static String ip="172.26.42.38";

        public static int port=8097;

        public static Boolean isColony = true;

        public static String serverIp = "172.26.42.38";

        public static int serverPort = 8084;

        public static DateTime lastStartTime = DateTime.MinValue;

        public static int MaxTimeExec = 5000;

        public static ServerColony serverColony = null;

        static object locker = new object();


        public MainForm()
        {
            InitializeComponent();
            this.ServerStatusText.HideSelection = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //测试使用
            /*List<OnlineUser> ous = new List<OnlineUser>();
            OnlineUser ou = new OnlineUser();
            ou.id = "201158080111";
            ou.name = "WMS";
            ou.port = 80;
            ou.ip = "10.64.23.145";
            ou.connectionDate = DateTime.Now;
            ous.Add(ou);
            this.onlineUsers.DataSource = ous;*/

            Server.us = new UpdateServer(UpdateServerShow);
            Server.updateUser = new UpdateUser(UpdateUserShow);
            ServerColony.log = Server.log = new LogInfo(LogInfoMessage);
            Control.CheckForIllegalCrossThreadCalls =false;
            this.快速启动ToolStripMenuItem.Enabled = true;
            this.快速关闭ToolStripMenuItem.Enabled = false;
            Server.mainForm = this;
            systemToolStripStatus.Text = "就绪";
        }


        private void UpdateServerShow(List<OnlineServer> onlineServers)
        {

            this.onlineServerGridView.DataSource = new BindingSource(onlineServers, null);
        }

        private void UpdateUserShow(List<OnlineUser> ous)
        {
            this.onlineUsers.DataSource = new BindingSource(ous,null);
        }

        public void LogInfoMessage(String message,Font font,Color color)
        {
            lock (locker)
            {
                if (font != null)
                {
                    this.ServerStatusText.SelectionFont = font;
                }
                if (color != null)
                {
                    this.ServerStatusText.SelectionColor = color;
                }
                this.ServerStatusText.AppendText(message + Environment.NewLine);
            }
            
        }

        #region 显示行号
        private void dataRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                onlineUsers.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                onlineUsers.RowHeadersDefaultCellStyle.Font,
                rectangle,
                onlineUsers.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerColony.runing = false;
            Thread.Sleep(500);

            if (ServerColony.socket != null)
            {
                ServerColony.socket.Close();
                ServerColony.socket = null;
            }
            
            serverColony = null;
            this.快速关闭ToolStripMenuItem_Click(null,null);
            
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerSetting ss = new ServerSetting();
            if (ss != null)
            {
                ss.mainForm = this;
                ss.ShowDialog();
            }
        }

        public void 快速启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Server.runing)
            {
               if (lastStartTime == DateTime.MinValue)
                {
                    lastStartTime = DateTime.Now;
                }
                else
                {
                    int date = (int)((DateTime.Now.ToFileTime() - lastStartTime.ToFileTime()) / 10000);
                    if (date < MaxTimeExec)
                    {
                        LogInfoMessage("系统不能在连续5秒内启动多次", Constant.error, Constant.errorColor);
                        return;
                    }
                    lastStartTime = DateTime.Now;
                }
                
                
                lock (locker)
                {
                    if (!Server.runing)
                    {
                        this.快速启动ToolStripMenuItem.Enabled = false;
                        this.快速关闭ToolStripMenuItem.Enabled = true;
                        try
                        {
                            Server.tcpListener = null;
                            Server.thread = null;
                            LogInfoMessage("系统快速启动中...", Constant.info, Constant.infoColor);
                            Server.tcpListener = new System.Net.Sockets.TcpListener(new IPEndPoint(IPAddress.Parse(MainForm.ip), MainForm.port));
                            Server.thread = new System.Threading.Thread(Server.ListenerClient);
                            Server.runing = true;
                            if (serverColony == null&&MainForm.isColony==true)
                            {
                                serverColony = new ServerColony();
                            }
                            else if (MainForm.isColony == false)
                            {
                                Server.thread.Start();
                            }
                            else if (serverColony != null && ServerColony.runing == true)
                            {
                                Server.thread.Start();
                            }
                            systemToolStripStatus.Text = "服务器启动完成";
                        }
                        catch (ArgumentNullException)
                        {
                            LogInfoMessage("请填写IP地址或者初始化TcpListener错误", Constant.error, Constant.errorColor);
                            MessageBox.Show("请填写IP地址或者初始化TcpListener错误", "错误");
                            Server.runing = false;
                            this.快速启动ToolStripMenuItem.Enabled = true;
                            this.快速关闭ToolStripMenuItem.Enabled = false;
                            Server.tcpListener = null;
                            Server.thread = null;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("IP地址格式错误", "错误");
                            LogInfoMessage("IP地址格式错误", Constant.error, Constant.errorColor);
                            Server.runing = false;
                            this.快速启动ToolStripMenuItem.Enabled = true;
                            this.快速关闭ToolStripMenuItem.Enabled = false;
                            Server.tcpListener = null;
                            Server.thread = null;
                        }
                        catch
                        {
                            LogInfoMessage("请检查集群服务器错误", Constant.error, Constant.errorColor);
                            Server.tcpListener = null;
                            Server.thread = null;
                            Server.runing = false;
                            this.快速启动ToolStripMenuItem.Enabled = true;
                            this.快速关闭ToolStripMenuItem.Enabled = false;
                        }
                    }
                }
                
            }
            else
            {
                LogInfoMessage("服务已经启动", Constant.error, Constant.errorColor);
                MessageBox.Show("服务已经启动", "警告");
            }

            
        }

        public void 快速关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (Server.runing)
            {

                if (sender != null)
                {
                    if (lastStartTime == DateTime.MinValue)
                    {
                        lastStartTime = DateTime.Now;
                    }
                    else
                    {
                        int date = (int)((DateTime.Now.ToFileTime() - lastStartTime.ToFileTime()) / 10000);
                        if (date < MaxTimeExec)
                        {
                            LogInfoMessage("系统不能在启动后5秒内被关闭", Constant.error, Constant.errorColor);
                            return;
                        }
                        lastStartTime = DateTime.Now;
                    }
                }

                if (Server.tcpListener == null)
                {
                    return;
                }

                lock (locker)
                {
                    if (Server.runing)
                    {
                        lastStartTime = DateTime.Now;
                        LogInfoMessage("系统快速关闭中...", Constant.info, Constant.infoColor);
                                                
                        Server.runing = false;
                        try
                        {
                            Server.tcpListener.Stop();
                            //Server.thread.Interrupt();
                        }
                        catch
                        {
                        }
                        if (Server.tcpListener.Server.LocalEndPoint != null)
                        {
                            String ip = (Server.tcpListener.Server.LocalEndPoint as IPEndPoint).Address.ToString();
                            int port = (Server.tcpListener.Server.LocalEndPoint as IPEndPoint).Port;
                            
                        }
                        
                        systemToolStripStatus.Text = "服务器关闭";
                        this.快速启动ToolStripMenuItem.Enabled = true;
                        this.快速关闭ToolStripMenuItem.Enabled = false;
                        Server.tcpListener = null;
                        Server.thread = null;
                    }
                }
                
            }
            else
            {
                LogInfoMessage("系统未启动", Constant.info, Constant.infoColor);
            }
            
        }

        
        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*IDataObject data = System.Windows.Forms.Clipboard.GetDataObject();
            String[] lengths = data.GetFormats();
            foreach (String t in lengths)
            {
                MessageBox.Show("ok" + t + "+and+");
                var temp = data.GetData(t);
                MessageBox.Show(temp+"Test");
            }
            MessageBox.Show("ok" + Clipboard.ContainsData("FileDrop") + "+and+");
            String[] objec = (String[])data.GetData("FileDrop");
            MessageBox.Show("ok" + objec[0] + "and");
            MessageBox.Show("ok" + ((String[])data.GetData("FileNameW"))[0] + "and");
            MessageBox.Show("ok" + ((String[])data.GetData("FileName"))[0] + "and");*/
            // this.ServerStatusText.CreateGraphics().DrawImage();


            if (Clipboard.ContainsData(DataFormats.FileDrop))
            {
                IDataObject data = Clipboard.GetDataObject();
                String path = ((String[])data.GetData("FileDrop"))[0];
                Image image = Image.FromFile(path);
                Clipboard.SetDataObject(image,false);
                this.ServerStatusText.Paste();
            }


            /*
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.CommaSeparatedValue));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Dib));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Dif));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.EnhancedMetafile));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.FileDrop));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Html));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Locale));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.MetafilePict));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.OemText));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Palette));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.PenData));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Riff));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Rtf));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Serializable));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.StringFormat));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.SymbolicLink));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Text));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Tiff));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.UnicodeText));
            this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.WaveAudio));
            //this.ServerStatusText.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
             * */
        }

        private void 集群设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ServerColony.runing == false && Server.runing == false)
            {
                ChatColonySetting ccs = new ChatColonySetting();
                if (ccs != null)
                {
                    ccs.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(this,"服务器已经启动，不允许设置集群","提示");
            }

            
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
            chatNotifycontextMenuStrip_VisibleChanged(null, null);
        }

        private void chatNotifycontextMenuStrip_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //chatNotifycontextMenuStrip_VisibleChanged(null, null);
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void 隐藏主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           // chatNotifycontextMenuStrip_VisibleChanged(null,null);
        }

        private void chatNotifycontextMenuStrip_VisibleChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.隐藏主界面ToolStripMenuItem.Enabled = false;
                this.显示主界面ToolStripMenuItem.Enabled = true;
                this.chatNotifyIcon.ShowBalloonTip(2000, "提示", "界面最小化", ToolTipIcon.Info);
            }
            else
            {
                this.显示主界面ToolStripMenuItem.Enabled = false;
                this.隐藏主界面ToolStripMenuItem.Enabled = true;
                this.chatNotifyIcon.ShowBalloonTip(2000, "提示", "界面显示", ToolTipIcon.Info);
            }
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ServerStatusText.Text = "";
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ServerStatusText.Copy();
        }

           
    }
}
