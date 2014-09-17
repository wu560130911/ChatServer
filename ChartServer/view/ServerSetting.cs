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
using System.Net;
using ChartServer.util;

namespace ChartServer.view
{
    public partial class ServerSetting : Form
    {

        public MainForm mainForm { set; get; }
        public ServerSetting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = MainForm.ip;
            this.numericUpDown1.Value = MainForm.port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = true;

            MainForm.ip = this.textBox1.Text;
            MainForm.port = Convert.ToInt32(this.numericUpDown1.Value);

            mainForm.快速启动ToolStripMenuItem_Click(null,null);

            ServerSetting_Load(null, null);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.快速关闭ToolStripMenuItem_Click(this,null);
            ServerSetting_Load(null, null);
        }

        private void ServerSetting_Load(object sender, EventArgs e)
        {
            if (Server.runing)
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
                this.button3.Visible = true;
            }
            else
            {
                this.button1.Visible = true;
                this.button2.Visible = true;
                this.button3.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
