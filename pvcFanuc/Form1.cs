using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslCommunication.Robot.FANUC;
using HslCommunication;
using HslCommunication.BasicFramework;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using generalDatabase;


namespace pvcFanuc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FanucInterfaceNet fanuc;
       oracleWEBKF weboracle = new oracleWEBKF();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private async void robotConn_Click(object sender, EventArgs e)
        {

            try
            {
                // 连接
                fanuc = new FanucInterfaceNet(robotIp.Text, 60008);
                fanuc.ConnectTimeOut = 2000;


                OperateResult connect = await fanuc.ConnectServerAsync();

                if (connect.IsSuccess)
                {

                    robotConn.Enabled = false;
                    connStatus.Text = "连接已经建立!";
              

                }
                else
                {
                    robotConn.Enabled = true;
                    MessageBox.Show("连接失败");
                }
            }
            catch (Exception ex)
            {
                SoftBasic.ShowExceptionMessage(ex);
            }
        }



       

       

        private void startRecord_Click(object sender, EventArgs e)
        {
            if(comTime.Text!="")
            {
                timer1.Start();
                startRecord.Enabled = false;
            }
            else
            {
                MessageBox.Show("请输入时间");
            }

       

  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt16( comTime.Text);

          

            OperateResult<string> actpos = fanuc.ReadString("CurrentPose");
            JObject acTpos = (JObject)JsonConvert.DeserializeObject(actpos.Content);

            xyz.Text = acTpos["Xyzwpr"].ToString();
            joint.Text = acTpos["Joint"].ToString();

            OperateResult<string> actfault = fanuc.ReadString("AlarmCurrent");
            JObject actFault = (JObject)JsonConvert.DeserializeObject(actfault.Content);
            nowfault.Text = actFault["Time"].ToString() + actFault["AlarmMessage"].ToString();




            string sql = "insert into PVCFANUC values('" + robotName.Text + "','" + acTpos["Xyzwpr"][0].ToString() + "','" + acTpos["Xyzwpr"][1].ToString() + "','" + acTpos["Xyzwpr"][2].ToString() + "','" + acTpos["Xyzwpr"][3].ToString() + "','" + acTpos["Xyzwpr"][4].ToString() + "','" + acTpos["Xyzwpr"][5].ToString() + "','" + acTpos["Xyzwpr"][6].ToString() + "','" + acTpos["Joint"][0].ToString() + "','" + acTpos["Joint"][1].ToString() + "','" + acTpos["Joint"][2].ToString() + "','" + acTpos["Joint"][3].ToString() + "','" + acTpos["Joint"][4].ToString() + "','" + acTpos["Joint"][5].ToString() + "','" + acTpos["Joint"][6].ToString() + "','  "+DateTime.Now.ToString()+"')";

            weboracle.connOpen();
            weboracle.OrcGetCom(sql);
            weboracle.connClose();






        }

        private void endRead_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startRecord.Enabled = true;
        }

        private void 数据查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://10.228.141.253:9080/sc/website/pvcfanuc/list.php");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            toolStripStatusLabel1.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void stopConn_Click(object sender, EventArgs e)
        {
            fanuc.ConnectClose();
            robotConn.Enabled = true;
            connStatus.Text = "连接已经断开!";

        }
    }
}








