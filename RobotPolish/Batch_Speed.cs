using System;
using System.Windows.Forms;
using RobotKit;
using System.Threading;
namespace RobotPolish
{
    public partial class Batch_Speed : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        string RecipeName;
        bool[] PointType = new bool[3];
        bool[] ParaType = new bool[5];

        private double[] Buffdata;
        private bool Bthread;
        private bool OffLine;

        public Batch_Speed()
        {
            InitializeComponent();
        }
        public Batch_Speed(string Recipe)
        {
            InitializeComponent();
            RecipeName = Recipe;

            OffLine = (db.IsMatlabFile(Recipe) == 2);
            CBK_Para.Items.Clear();
            string[] buff;
            if (OffLine)
            {
                buff = new string[] {"速度","加速度","RZ"};
                CBK_Para.Items.AddRange(buff);
            }
     
            
            else
            {


                buff = new string[] { "速度", "加速度"};
                CBK_Para.Items.AddRange(buff);
                TE_A5.Visible = TE_A6.Visible = labelControl4.Visible = labelControl6.Visible = false;

            }
            // OffLine=db.re
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CE_Set_CheckedChanged(object sender, EventArgs e)
        {
            CE_Replace.Checked = !CE_Set.Checked;
            TE_A6.Enabled = TE_A4.Enabled = TE_A2.Enabled = CE_Replace.Checked;
        }

        private void CE_Replace_CheckedChanged(object sender, EventArgs e)
        {
            CE_Set.Checked=!CE_Replace.Checked ;
            TE_A6.Enabled = TE_A4.Enabled = TE_A2.Enabled = CE_Replace.Checked;
        }

        private void Batch_Speed_Load(object sender, EventArgs e)
        {
            LL_RecipeName.Text = "产品名称:" + RecipeName;
            int TrajCount = db.GetTrajCount(RecipeName);
            if (TrajCount != 0)
            {
                string[] Traj = new string[TrajCount];
                for (int i = 0; i < TrajCount; i++)
                {
                    Traj[i] = (i + 1).ToString();


                }
                CBE_id.Properties.Items.Clear();
                CBE_id.Properties.Items.AddRange((object[])Traj);
                CBE_id.SelectedIndex = 0;

                CBE_idend.Properties.Items.Clear();
                CBE_idend.Properties.Items.AddRange((object[])Traj);
                CBE_idend.SelectedIndex = Traj.Length - 1;

            }
           TE_A4.Enabled = TE_A2.Enabled = CE_Replace.Checked;
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
            if (CBE_id.SelectedIndex > CBE_idend.SelectedIndex)
            {

                MessageBox.Show("开始序号不能超过结束序号");

                return;
            }
            bool Flag = false;
            for (int i = 0; i < Clb_Check.ItemCount; i++)
            {
               PointType[i] =Clb_Check.GetItemChecked(i);
               Flag = PointType[i] ? true : Flag;
            }
            if (!Flag)
            {

                MessageBox.Show("请进行点位选择");

                return;
            }
            Flag = false;
            for (int i = 0; i <CBK_Para.ItemCount; i++)
            {
                ParaType[i] = CBK_Para.GetItemChecked(i);
                Flag = ParaType[i] ? true : Flag;
            }
            if (!Flag)
            {

                MessageBox.Show("请进行参数选择");

                return;
            }

            double[] data=new double[10];
            double.TryParse(TE_A1.Text,out data[0]);
            double.TryParse(TE_A2.Text, out data[1]); 
            double.TryParse(TE_A3.Text, out data[2]);
            double.TryParse(TE_A4.Text, out data[3]);
            double.TryParse(TE_A5.Text, out data[4]);
            double.TryParse(TE_A6.Text, out data[5]);
            //data[6] = (int)SE1.Value;
            //data[7] = (int)SE2.Value;
            //data[8] = (int)SE3.Value;
            //data[9] = (int)SE4.Value;

            if (data[0]<=0||data[2]<=0||data[4]<0)
            {
                MessageBox.Show("速度与加速度不能小于0");
                return;
            }
            if (Bthread)
            {
                return;
            }
            Buffdata = data;
            //string Mess = db.BatchSpeed(RecipeName,CBE_id.SelectedIndex+1,CBE_idend.SelectedIndex+1,PointType,ParaType,data,CE_Replace.Checked) ? "成功" : "操作异常";
            //MessageBox.Show(Mess);
            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait();
            frm.ShowDialog();
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this,null);
            BT_Cancle_Click(this, null);
            
        }

        void Poll(object target)
        {
            Bthread = true;
            TxtData.PublicData.ErrorCode = (db.BatchSpeed(RecipeName, CBE_id.SelectedIndex + 1, CBE_idend.SelectedIndex + 1, PointType, ParaType, Buffdata, CE_Replace.Checked)) ? 40 : 60;
          
          //  string Mess = db.BatchSpeed(RecipeName, CBE_id.SelectedIndex + 1, CBE_idend.SelectedIndex + 1, PointType, ParaType, data, CE_Replace.Checked) ? "成功" : "操作异常";
           // MessageBox.Show(Mess);

            Bthread = false;
        }
    }
}
