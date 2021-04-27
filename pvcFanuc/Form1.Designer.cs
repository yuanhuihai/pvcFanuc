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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nowfault = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.joint = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xyz = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.endRead = new System.Windows.Forms.Button();
            this.robotName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.robotConn = new System.Windows.Forms.Button();
            this.robotIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据查看ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1565, 53);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据查看ToolStripMenuItem
            // 
            this.数据查看ToolStripMenuItem.Name = "数据查看ToolStripMenuItem";
            this.数据查看ToolStripMenuItem.Size = new System.Drawing.Size(149, 43);
            this.数据查看ToolStripMenuItem.Text = "数据查看";
            this.数据查看ToolStripMenuItem.Click += new System.EventHandler(this.数据查看ToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(25, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1462, 671);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "机器人信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nowfault);
            this.groupBox3.Location = new System.Drawing.Point(863, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 554);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实时报警信息";
            // 
            // nowfault
            // 
            this.nowfault.Location = new System.Drawing.Point(44, 64);
            this.nowfault.Multiline = true;
            this.nowfault.Name = "nowfault";
            this.nowfault.Size = new System.Drawing.Size(503, 455);
            this.nowfault.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.joint);
            this.groupBox2.Location = new System.Drawing.Point(427, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 554);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Joint";
            // 
            // joint
            // 
            this.joint.Location = new System.Drawing.Point(34, 64);
            this.joint.Multiline = true;
            this.joint.Name = "joint";
            this.joint.Size = new System.Drawing.Size(305, 455);
            this.joint.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xyz);
            this.groupBox1.Location = new System.Drawing.Point(40, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 554);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xyzwpr";
            // 
            // xyz
            // 
            this.xyz.Location = new System.Drawing.Point(34, 64);
            this.xyz.Multiline = true;
            this.xyz.Name = "xyz";
            this.xyz.Size = new System.Drawing.Size(297, 455);
            this.xyz.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.endRead);
            this.groupBox5.Controls.Add(this.robotName);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.startRecord);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.comTime);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.robotConn);
            this.groupBox5.Controls.Add(this.robotIp);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(25, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1148, 298);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "与机器人建立连接";
            // 
            // endRead
            // 
            this.endRead.Location = new System.Drawing.Point(628, 181);
            this.endRead.Margin = new System.Windows.Forms.Padding(8);
            this.endRead.Name = "endRead";
            this.endRead.Size = new System.Drawing.Size(188, 58);
            this.endRead.TabIndex = 19;
            this.endRead.Text = "结束读取";
            this.endRead.UseVisualStyleBackColor = true;
            // 
            // robotName
            // 
            this.robotName.Location = new System.Drawing.Point(614, 87);
            this.robotName.Margin = new System.Windows.Forms.Padding(8);
            this.robotName.Name = "robotName";
            this.robotName.Size = new System.Drawing.Size(228, 42);
            this.robotName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "机器人名称";
            // 
            // startRecord
            // 
            this.startRecord.Location = new System.Drawing.Point(387, 181);
            this.startRecord.Margin = new System.Windows.Forms.Padding(8);
            this.startRecord.Name = "startRecord";
            this.startRecord.Size = new System.Drawing.Size(188, 58);
            this.startRecord.TabIndex = 16;
            this.startRecord.Text = "开始读取";
            this.startRecord.UseVisualStyleBackColor = true;
            this.startRecord.Click += new System.EventHandler(this.startRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "ms";
            // 
            // comTime
            // 
            this.comTime.Location = new System.Drawing.Point(194, 192);
            this.comTime.Margin = new System.Windows.Forms.Padding(8);
            this.comTime.Name = "comTime";
            this.comTime.Size = new System.Drawing.Size(114, 42);
            this.comTime.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "通讯周期";
            // 
            // robotConn
            // 
            this.robotConn.Location = new System.Drawing.Point(883, 80);
            this.robotConn.Margin = new System.Windows.Forms.Padding(8);
            this.robotConn.Name = "robotConn";
            this.robotConn.Size = new System.Drawing.Size(166, 58);
            this.robotConn.TabIndex = 12;
            this.robotConn.Text = "建立连接";
            this.robotConn.UseVisualStyleBackColor = true;
            this.robotConn.Click += new System.EventHandler(this.robotConn_Click);
            // 
            // robotIp
            // 
            this.robotIp.Location = new System.Drawing.Point(156, 87);
            this.robotIp.Margin = new System.Windows.Forms.Padding(8);
            this.robotIp.Name = "robotIp";
            this.robotIp.Size = new System.Drawing.Size(234, 42);
            this.robotIp.TabIndex = 11;
            this.robotIp.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ip地址";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 1181);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "C#-涂装二车间机器人信息采集监控系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据查看ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nowfault;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox joint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox xyz;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button endRead;
        private System.Windows.Forms.TextBox robotName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox comTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button robotConn;
        private System.Windows.Forms.TextBox robotIp;
        private System.Windows.Forms.Label label1;
    }
}

