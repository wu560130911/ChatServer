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
using ChartServer.view;
using ChartServer.util;
using ChartServer.server;

namespace ChartServer.view
{
    public partial class ChatColonySetting : Form
    {

        private static String serverIp = "172.26.42.38";

        private static int serverPort = 8084;

        public ChatColonySetting()
        {
            InitializeComponent();
            this.checkBox1.Checked = MainForm.isColony;
            this.colonygroupBox.Enabled = MainForm.isColony;
            this.colonyServerIpTextBox.Text = MainForm.serverIp;
            this.colonyServerPortNumericUpDown.Value = MainForm.serverPort;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.colonygroupBox.Enabled = true;
            }
            else
            {
                this.colonygroupBox.Enabled = false;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            MainForm.isColony = this.checkBox1.Checked;
            if (this.checkBox1.Checked)
            {
                MainForm.serverIp = this.colonyServerIpTextBox.Text;
                MainForm.serverPort = Convert.ToInt32(this.colonyServerPortNumericUpDown.Value);
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = MainForm.isColony;
            this.colonygroupBox.Enabled = MainForm.isColony;
            this.colonyServerIpTextBox.Text = serverIp;
            this.colonyServerPortNumericUpDown.Value = serverPort;
        }
    }
}
