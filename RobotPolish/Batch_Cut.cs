using System;
using System.Windows.Forms;
using RobotKit;
using System.Threading;

namespace RobotPolish
{
    public partial class Batch_Cut : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        string Trajname;
        bool[] PointType = new bool[3];
        bool[] ParaType = new bool[5];
        private bool bthread;

        private double[] Buffdata;
        public Batch_Cut()
        {
            InitializeComponent();
        }
        public Batch_Cut(string traj)
        {
            InitializeComponent();
            Trajname = traj;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CE_Set_CheckedChanged(object sender, EventArgs e)
        {
            CE_Replace.Checked = !CE_Set.Checked;
            TE_A4.Enabled = TE_A2.Enabled = TE_A6.Enabled = TE_A8.Enabled = CE_Replace.Checked;
        }

        private void CE_Replace_CheckedChanged(object sender, EventArgs e)
        {
            CE_Set.Checked=!CE_Replace.Checked ;
            TE_A4.Enabled = TE_A2.Enabled = TE_A6.Enabled = TE_A8.Enabled = CE_Replace.Checked;
        }

        private void Batch_Speed_Load(object sender, EventArgs e)
        {LL_RecipeName.Text = "路径名称:" + Trajname;
            int TrajCount = db.GetTrajPosCount(Trajname);
            if (TrajCount != 0)
            {
                string[] Traj = new string[TrajCount];
                for (int i = 0; i < TrajCount; i++)
                {
                    Traj[i] = (i + 1).ToString();


                }
                CBE_id.Properties.Items.Clear();
                CBE_id.Properties.Items.AddRange((object[])Traj);
                CBE_idend.Properties.Items.Clear();
                CBE_idend.Properties.Items.AddRange((object[])Traj);
                CBE_id.SelectedIndex = 0;
                CBE_idend.SelectedIndex = TrajCount - 1;
                //CBE_id_SelectedIndexChanged(this, null);
            }
            TE_A4.Enabled = TE_A2.Enabled = TE_A6.Enabled = TE_A8.Enabled = CE_Replace.Checked;
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            if (CBE_id.SelectedIndex > CBE_idend.SelectedIndex)
            {

                MessageBox.Show("开始序号不能超过结束序号");

                return;
            }
            bool Flag = false;
            ////for (int i = 0; i < Clb_Check.ItemCount; i++)
            ////{
            ////   PointType[i] =Clb_Check.GetItemChecked(i);
            ////   Flag = PointType[i] ? true : Flag;
            ////}
            //if (!Flag)
            //{

            //    MessageBox.Show("请进行点位选择");

            //    return;
            //}
           // Flag = false;
            for (int i = 0; i <CBK_Para.ItemCount; i++)
            {
                ParaType[i] = CBK_Para.GetItemChecked(i);
                Flag = ParaType[i] || Flag;
            }
            if (!Flag)
            {

                MessageBox.Show("请进行参数选择");

                return;
            }

            //2015.02.04
            if (CBK_Para.GetItemChecked(3))
            {
                if (MessageBox.Show("确定需要修改RZ吗？\n 修改RZ可能导致机械手臂姿态异常！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
  
            double[] data=new double[10];
            double.TryParse(TE_A1.Text,out data[0]);
            double.TryParse(TE_A2.Text, out data[1]); 
            double.TryParse(TE_A3.Text, out data[2]);
            double.TryParse(TE_A4.Text, out data[3]);
            double.TryParse(TE_A5.Text, out data[4]);
            double.TryParse(TE_A6.Text, out data[5]);
            double.TryParse(TE_A7.Text, out data[6]);
            double.TryParse(TE_A8.Text, out data[7]);
            //data[6] = (int)SE1.Value;
            //data[7] = (int)SE2.Value;
            //data[8] = (int)SE3.Value;
            //data[9] = (int)SE4.Value;

            if (data[0]<=0||data[2]<=0||data[4]<0||data[5]<0)
            {MessageBox.Show("速度与加速度,延时不能小于0");
                return;
            }
            if (bthread)
            {
                return;
            }

           // string Mess = db.BatchCut(Trajname,CBE_id.SelectedIndex+1,CBE_idend.SelectedIndex+1,ParaType,data,CE_Replace.Checked) ? "成功" : "操作异常";
          //  MessageBox.Show(Mess);
            Buffdata = data;
            //string Mess = db.BatchSpeed(RecipeName,CBE_id.SelectedIndex+1,CBE_idend.SelectedIndex+1,PointType,ParaType,data,CE_Replace.Checked) ? "成功" : "操作异常";
            //MessageBox.Show(Mess);
            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait();
            frm.ShowDialog();

        }

        private void Poll(object target)
        {
            bthread = true;
            TxtData.PublicData.ErrorCode = (db.BatchCut(Trajname,CBE_id.SelectedIndex+1,CBE_idend.SelectedIndex+1,ParaType,Buffdata,CE_Replace.Checked)) ? 40 : 60;
            bthread = false;


        }


        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this,null);
            BT_Cancle_Click(this, null);
            
        }
    }
}
