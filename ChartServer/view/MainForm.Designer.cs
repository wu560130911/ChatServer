namespace ChartServer.view
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集群设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快速启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快速关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onlineUsers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.onlineServerGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.systemToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServerStatusText = new System.Windows.Forms.RichTextBox();
            this.ServerStatusContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.chatNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.chatNotifycontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatProgressBar = new System.Windows.Forms.ProgressBar();
            this.portDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineServerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登录地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.服务器编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登录时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineUsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineServerGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ServerStatusContextMenuStrip.SuspendLayout();
            this.chatNotifycontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineServerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.快速启动ToolStripMenuItem,
            this.快速关闭ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.集群设置ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.菜单ToolStripMenuItem.Text = "设置";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click);
            // 
            // 集群设置ToolStripMenuItem
            // 
            this.集群设置ToolStripMenuItem.Name = "集群设置ToolStripMenuItem";
            this.集群设置ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.集群设置ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.集群设置ToolStripMenuItem.Text = "集群设置";
            this.集群设置ToolStripMenuItem.Click += new System.EventHandler(this.集群设置ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统帮助ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 系统帮助ToolStripMenuItem
            // 
            this.系统帮助ToolStripMenuItem.Name = "系统帮助ToolStripMenuItem";
            this.系统帮助ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.系统帮助ToolStripMenuItem.Text = "系统帮助";
            // 
            // 快速启动ToolStripMenuItem
            // 
            this.快速启动ToolStripMenuItem.Name = "快速启动ToolStripMenuItem";
            this.快速启动ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.快速启动ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.快速启动ToolStripMenuItem.Text = "快速启动";
            this.快速启动ToolStripMenuItem.ToolTipText = "快速启动服务器,快捷键F5";
            this.快速启动ToolStripMenuItem.Click += new System.EventHandler(this.快速启动ToolStripMenuItem_Click);
            // 
            // 快速关闭ToolStripMenuItem
            // 
            this.快速关闭ToolStripMenuItem.Name = "快速关闭ToolStripMenuItem";
            this.快速关闭ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.快速关闭ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.快速关闭ToolStripMenuItem.Text = "快速关闭";
            this.快速关闭ToolStripMenuItem.ToolTipText = "快速关闭服务器，快捷键F10";
            this.快速关闭ToolStripMenuItem.Click += new System.EventHandler(this.快速关闭ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onlineUsers);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "在线用户";
            // 
            // onlineUsers
            // 
            this.onlineUsers.AllowUserToAddRows = false;
            this.onlineUsers.AutoGenerateColumns = false;
            this.onlineUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlineUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.onlineUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.onlineUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.登录地址,
            this.portDataGridViewTextBoxColumn,
            this.服务器编号,
            this.登录时间});
            this.onlineUsers.DataSource = this.onlineUserBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.onlineUsers.DefaultCellStyle = dataGridViewCellStyle7;
            this.onlineUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineUsers.Location = new System.Drawing.Point(3, 17);
            this.onlineUsers.Name = "onlineUsers";
            this.onlineUsers.ReadOnly = true;
            this.onlineUsers.RowTemplate.Height = 23;
            this.onlineUsers.Size = new System.Drawing.Size(608, 208);
            this.onlineUsers.TabIndex = 0;
            this.onlineUsers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataRowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.onlineServerGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务器列表";
            // 
            // onlineServerGridView
            // 
            this.onlineServerGridView.AllowUserToAddRows = false;
            this.onlineServerGridView.AllowUserToDeleteRows = false;
            this.onlineServerGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlineServerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.onlineServerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.onlineServerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ipAddress,
            this.portDataGridViewTextBoxColumn1,
            this.onlineDate});
            this.onlineServerGridView.DataSource = this.onlineServerBindingSource;
            this.onlineServerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineServerGridView.Location = new System.Drawing.Point(3, 17);
            this.onlineServerGridView.Name = "onlineServerGridView";
            this.onlineServerGridView.ReadOnly = true;
            this.onlineServerGridView.RowTemplate.Height = 23;
            this.onlineServerGridView.Size = new System.Drawing.Size(608, 109);
            this.onlineServerGridView.TabIndex = 0;
            this.onlineServerGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataRowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 102;
            // 
            // ipAddress
            // 
            this.ipAddress.DataPropertyName = "ipAddress";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ipAddress.DefaultCellStyle = dataGridViewCellStyle10;
            this.ipAddress.HeaderText = "服务器地址";
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.ReadOnly = true;
            this.ipAddress.Width = 183;
            // 
            // onlineDate
            // 
            this.onlineDate.DataPropertyName = "onlineDate";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "F";
            dataGridViewCellStyle12.NullValue = null;
            this.onlineDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.onlineDate.HeaderText = "上线时间";
            this.onlineDate.Name = "onlineDate";
            this.onlineDate.ReadOnly = true;
            this.onlineDate.Width = 160;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(637, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // systemToolStripStatus
            // 
            this.systemToolStripStatus.Name = "systemToolStripStatus";
            this.systemToolStripStatus.Size = new System.Drawing.Size(31, 17);
            this.systemToolStripStatus.Text = "就绪";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ServerStatusText);
            this.groupBox3.Location = new System.Drawing.Point(15, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "服务器信息";
            // 
            // ServerStatusText
            // 
            this.ServerStatusText.AcceptsTab = true;
            this.ServerStatusText.ContextMenuStrip = this.ServerStatusContextMenuStrip;
            this.ServerStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerStatusText.EnableAutoDragDrop = true;
            this.ServerStatusText.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerStatusText.Location = new System.Drawing.Point(3, 17);
            this.ServerStatusText.Name = "ServerStatusText";
            this.ServerStatusText.ReadOnly = true;
            this.ServerStatusText.Size = new System.Drawing.Size(602, 90);
            this.ServerStatusText.TabIndex = 0;
            this.ServerStatusText.Text = "";
            // 
            // ServerStatusContextMenuStrip
            // 
            this.ServerStatusContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.复制ToolStripMenuItem});
            this.ServerStatusContextMenuStrip.Name = "ServerStatusContextMenuStrip";
            this.ServerStatusContextMenuStrip.Size = new System.Drawing.Size(143, 48);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.撤销ToolStripMenuItem.Text = "清空";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // chatNotifyIcon
            // 
            this.chatNotifyIcon.ContextMenuStrip = this.chatNotifycontextMenuStrip;
            this.chatNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("chatNotifyIcon.Icon")));
            this.chatNotifyIcon.Text = "在线聊天系统";
            this.chatNotifyIcon.Visible = true;
            this.chatNotifyIcon.DoubleClick += new System.EventHandler(this.chatNotifycontextMenuStrip_DoubleClick);
            // 
            // chatNotifycontextMenuStrip
            // 
            this.chatNotifycontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.隐藏主界面ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.chatNotifycontextMenuStrip.Name = "chatNotifycontextMenuStrip";
            this.chatNotifycontextMenuStrip.Size = new System.Drawing.Size(135, 70);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Enabled = false;
            this.显示主界面ToolStripMenuItem.Image = global::ChartServer.Properties.Resources._20140914040437752_easyicon_net_64;
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.chatNotifycontextMenuStrip_DoubleClick);
            // 
            // 隐藏主界面ToolStripMenuItem
            // 
            this.隐藏主界面ToolStripMenuItem.Image = global::ChartServer.Properties.Resources._20140915015024213_easyicon_net_24;
            this.隐藏主界面ToolStripMenuItem.Name = "隐藏主界面ToolStripMenuItem";
            this.隐藏主界面ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.隐藏主界面ToolStripMenuItem.Text = "隐藏主界面";
            this.隐藏主界面ToolStripMenuItem.Click += new System.EventHandler(this.隐藏主界面ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Image = global::ChartServer.Properties.Resources._20140914041658457_easyicon_net_48;
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // chatProgressBar
            // 
            this.chatProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatProgressBar.Location = new System.Drawing.Point(357, 513);
            this.chatProgressBar.Name = "chatProgressBar";
            this.chatProgressBar.Size = new System.Drawing.Size(250, 18);
            this.chatProgressBar.TabIndex = 5;
            // 
            // portDataGridViewTextBoxColumn1
            // 
            this.portDataGridViewTextBoxColumn1.DataPropertyName = "port";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.portDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.portDataGridViewTextBoxColumn1.HeaderText = "端口";
            this.portDataGridViewTextBoxColumn1.Name = "portDataGridViewTextBoxColumn1";
            this.portDataGridViewTextBoxColumn1.ReadOnly = true;
            this.portDataGridViewTextBoxColumn1.Width = 120;
            // 
            // onlineServerBindingSource
            // 
            this.onlineServerBindingSource.DataSource = typeof(ChartServer.model.OnlineServer);
            // 
            // onlineUserBindingSource
            // 
            this.onlineUserBindingSource.DataSource = typeof(ChartServer.model.OnlineUser);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "账号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 登录地址
            // 
            this.登录地址.DataPropertyName = "ipAddress";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.登录地址.DefaultCellStyle = dataGridViewCellStyle3;
            this.登录地址.HeaderText = "登录地址";
            this.登录地址.Name = "登录地址";
            this.登录地址.ReadOnly = true;
            this.登录地址.Width = 140;
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "port";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.portDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.portDataGridViewTextBoxColumn.HeaderText = "端口";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            this.portDataGridViewTextBoxColumn.ReadOnly = true;
            this.portDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.portDataGridViewTextBoxColumn.Width = 80;
            // 
            // 服务器编号
            // 
            this.服务器编号.DataPropertyName = "serverId";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.服务器编号.DefaultCellStyle = dataGridViewCellStyle5;
            this.服务器编号.HeaderText = "服务器编号";
            this.服务器编号.Name = "服务器编号";
            this.服务器编号.ReadOnly = true;
            // 
            // 登录时间
            // 
            this.登录时间.DataPropertyName = "joinDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "F";
            dataGridViewCellStyle6.NullValue = null;
            this.登录时间.DefaultCellStyle = dataGridViewCellStyle6;
            this.登录时间.HeaderText = "登录时间";
            this.登录时间.Name = "登录时间";
            this.登录时间.ReadOnly = true;
            this.登录时间.Width = 145;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 531);
            this.Controls.Add(this.chatProgressBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线聊天系统服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.onlineUsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.onlineServerGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ServerStatusContextMenuStrip.ResumeLayout(false);
            this.chatNotifycontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.onlineServerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集群设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统帮助ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel systemToolStripStatus;
        private System.Windows.Forms.DataGridView onlineUsers;
        private System.Windows.Forms.BindingSource onlineUserBindingSource;
        private System.Windows.Forms.DataGridView onlineServerGridView;
        private System.Windows.Forms.BindingSource onlineServerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox ServerStatusText;
        private System.Windows.Forms.ContextMenuStrip ServerStatusContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.ToolStripMenuItem 快速启动ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 快速关闭ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon chatNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip chatNotifycontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar chatProgressBar;
        private System.Windows.Forms.ToolStripMenuItem 隐藏主界面ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登录地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服务器编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登录时间;
    }
}