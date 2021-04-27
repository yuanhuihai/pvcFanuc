namespace pvcFanuc
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.robotIp = new System.Windows.Forms.TextBox();
            this.robotConn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startRecord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.robotName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.endRead = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip地址";
            // 
            // robotIp
            // 
            this.robotIp.Location = new System.Drawing.Point(185, 115);
            this.robotIp.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.robotIp.Name = "robotIp";
            this.robotIp.Size = new System.Drawing.Size(332, 42);
            this.robotIp.TabIndex = 1;
            // 
            // robotConn
            // 
            this.robotConn.Location = new System.Drawing.Point(1145, 110);
            this.robotConn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.robotConn.Name = "robotConn";
            this.robotConn.Size = new System.Drawing.Size(188, 58);
            this.robotConn.TabIndex = 2;
            this.robotConn.Text = "建立连接";
            this.robotConn.UseVisualStyleBackColor = true;
            this.robotConn.Click += new System.EventHandler(this.robotConn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1390, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "通讯周期";
            // 
            // comTime
            // 
            this.comTime.Location = new System.Drawing.Point(1538, 108);
            this.comTime.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.comTime.Name = "comTime";
            this.comTime.Size = new System.Drawing.Size(114, 42);
            this.comTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1672, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "ms";
            // 
            // startRecord
            // 
            this.startRecord.Location = new System.Drawing.Point(1730, 105);
            this.startRecord.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.startRecord.Name = "startRecord";
            this.startRecord.Size = new System.Drawing.Size(188, 58);
            this.startRecord.TabIndex = 6;
            this.startRecord.Text = "开始读取";
            this.startRecord.UseVisualStyleBackColor = true;
            this.startRecord.Click += new System.EventHandler(this.startRecord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "机器人名称";
            // 
            // robotName
            // 
            this.robotName.Location = new System.Drawing.Point(748, 110);
            this.robotName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.robotName.Name = "robotName";
            this.robotName.Size = new System.Drawing.Size(332, 42);
            this.robotName.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // endRead
            // 
            this.endRead.Location = new System.Drawing.Point(1970, 108);
            this.endRead.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.endRead.Name = "endRead";
            this.endRead.Size = new System.Drawing.Size(188, 58);
            this.endRead.TabIndex = 9;
            this.endRead.Text = "结束读取";
            this.endRead.UseVisualStyleBackColor = true;
            this.endRead.Click += new System.EventHandler(this.endRead_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据查看ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2775, 53);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据查看ToolStripMenuItem
            // 
            this.数据查看ToolStripMenuItem.Name = "数据查看ToolStripMenuItem";
            this.数据查看ToolStripMenuItem.Size = new System.Drawing.Size(149, 48);
            this.数据查看ToolStripMenuItem.Text = "数据查看";
            this.数据查看ToolStripMenuItem.Click += new System.EventHandler(this.数据查看ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 42);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2775, 1372);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.endRead);
            this.Controls.Add(this.robotName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.robotConn);
            this.Controls.Add(this.robotIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.Text = "C#-基于HslCommunication实现Fanuc机器人通讯";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox robotIp;
        private System.Windows.Forms.Button robotConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox robotName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button endRead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据查看ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

