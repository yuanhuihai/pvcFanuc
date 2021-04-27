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
                    robotConn.BackColor = Color.Green;

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

            timer1.Start();

         



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt16( comTime.Text);

          

            OperateResult<string> pos = fanuc.ReadString("CurrentPose");
            JObject jo = (JObject)JsonConvert.DeserializeObject(pos.Content);

            string sql = "insert into PVCFANUC values('" + robotName.Text + "','" + jo["Xyzwpr"][0].ToString() + "','" + jo["Xyzwpr"][1].ToString() + "','" + jo["Xyzwpr"][2].ToString() + "','" + jo["Xyzwpr"][3].ToString() + "','" + jo["Xyzwpr"][4].ToString() + "','" + jo["Xyzwpr"][5].ToString() + "','" + jo["Xyzwpr"][6].ToString() + "','" + jo["Joint"][0].ToString() + "','" + jo["Joint"][1].ToString() + "','" + jo["Joint"][2].ToString() + "','" + jo["Joint"][3].ToString() + "','" + jo["Joint"][4].ToString() + "','" + jo["Joint"][5].ToString() + "','" + jo["Joint"][6].ToString() + "','  "+DateTime.Now.ToString()+"')";

            weboracle.connOpen();
            weboracle.OrcGetCom(sql);
            weboracle.connClose();
        }

        private void endRead_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void 数据查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://10.228.141.253:9080/sc/website/pvcfanuc/list.php");
        }
    }
}








