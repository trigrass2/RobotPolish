using System;
using System.Windows.Forms;
using RobotKit;

namespace RobotPolish
{
    public partial class Edit_Cut : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        double[] Point=new double[6];
        double[] MovC=new double[6];
        double[] Para=new double[6];
        bool IsMovC = false;
        string Trajname;
        int CutIndex;
        public Edit_Cut()
        {
            InitializeComponent();
        }

        public Edit_Cut(string Traj, int Index)
        {
            InitializeComponent();
            Trajname = Traj;

            CutIndex = Index;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {

            double.TryParse(TE_A1.Text, out Para[0]);
            double.TryParse(TE_A2.Text, out Para[1]);

           string Buff=db.EditCutInfor(Trajname,CBE_id.SelectedIndex+1,Para)?"成功":"错误";
            MessageBox.Show(Buff);


        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this,null);
            BT_Cancle_Click(this, null);
        }

        private void Edit_Traj_Load(object sender, EventArgs e)
        {
            string[] Item = new string[51];
            for (int i = 0; i <= 50; i++)
            {
                Item[i] = i.ToString();
            }
         

            LL_RecipeName.Text = "路径名称:" +Trajname;
            int TrajCount = db.GetTrajPosCount(Trajname);
            if (TrajCount!=0)
            {
                string[] Traj=new string[TrajCount];
                for (int i = 0; i < TrajCount;i++ )
                {
                    Traj[i] = (i + 1).ToString();


                }
                CBE_id.Properties.Items.Clear();
                CBE_id.Properties.Items.AddRange((object[])Traj);
                CBE_id.SelectedIndex = CutIndex - 1;
                CBE_id_SelectedIndexChanged(this,null);
            }
      
        }


        private void CBE_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point = db.GetCutInfor(Trajname, CBE_id.SelectedIndex + 1, ref MovC, ref Para, ref IsMovC);
            if (Point != null)
            {
                TE_O1.Text = Point[0].ToString();
                TE_O2.Text = Point[1].ToString();
                TE_O3.Text = Point[2].ToString();
                TE_O4.Text = Point[3].ToString();
                TE_O5.Text = Point[4].ToString();
                TE_O6.Text = Point[5].ToString();

                TE_A1.Text = Para[0].ToString();
                TE_A2.Text = Para[1].ToString();
            }
        }

    }
}
