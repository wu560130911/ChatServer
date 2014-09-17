namespace ChartServer.view
{
    partial class ChatColonySetting
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
            this.colonygroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colonyServerIpTextBox = new System.Windows.Forms.TextBox();
            this.colonyServerPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.colonygroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colonyServerPortNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // colonygroupBox
            // 
            this.colonygroupBox.Controls.Add(this.label2);
            this.colonygroupBox.Controls.Add(this.label1);
            this.colonygroupBox.Controls.Add(this.colonyServerPortNumericUpDown);
            this.colonygroupBox.Controls.Add(this.colonyServerIpTextBox);
            this.colonygroupBox.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colonygroupBox.Location = new System.Drawing.Point(12, 62);
            this.colonygroupBox.Name = "colonygroupBox";
            this.colonygroupBox.Size = new System.Drawing.Size(412, 189);
            this.colonygroupBox.TabIndex = 0;
            this.colonygroupBox.TabStop = false;
            this.colonygroupBox.Text = "启用集群";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(12, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "启用集群";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // colonyServerIpTextBox
            // 
            this.colonyServerIpTextBox.Location = new System.Drawing.Point(195, 43);
            this.colonyServerIpTextBox.Name = "colonyServerIpTextBox";
            this.colonyServerIpTextBox.Size = new System.Drawing.Size(194, 27);
            this.colonyServerIpTextBox.TabIndex = 0;
            // 
            // colonyServerPortNumericUpDown
            // 
            this.colonyServerPortNumericUpDown.Location = new System.Drawing.Point(198, 120);
            this.colonyServerPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.colonyServerPortNumericUpDown.Name = "colonyServerPortNumericUpDown";
            this.colonyServerPortNumericUpDown.Size = new System.Drawing.Size(191, 27);
            this.colonyServerPortNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "集群服务器地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "集群服务器端口:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(70, 280);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(82, 38);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "确认";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(233, 280);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(86, 38);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "重置";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChatColonySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 330);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.colonygroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatColonySetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "集群设置";
            this.colonygroupBox.ResumeLayout(false);
            this.colonygroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colonyServerPortNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox colonygroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown colonyServerPortNumericUpDown;
        private System.Windows.Forms.TextBox colonyServerIpTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}