using System;
using System.Windows.Forms;
using RobotKit;

namespace RobotPolish
{
    public partial class Edit_Part : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        bool CreatRecipe=false;
        public string RecipeName = "";
        double[] frame = new double[6];
        double[] offset = new double[6];
        string Remark = "";


        public Edit_Part()
        {
            InitializeComponent();

                this.Text = "（部分路径）另存为产品";
                CBE_Type.EditValue = 1;
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            TxtData.PolishData.PartMatlabFile = null;
            TxtData.PolishData.PartRecipeName = null;
            this.Close();
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {

          TxtData.PolishData.PartRecipeRemark = TE_Remark.Text;
          TxtData.PolishData.PartRecipeName = TE_RecipeName.Text.Trim();
          TxtData.PolishData.PartMatlabFile = TE_File.Text.Trim();

          if (TxtData.PolishData.PartRecipeName == "")
                {
                    MessageBox.Show("名称为空");
                    TxtData.PolishData.PartMatlabFile = null;
                    TxtData.PolishData.PartRecipeName = null;
                    return;
                }
                if (db.ExistRecipe(RecipeName))
                {
                    MessageBox.Show("产品名称已存在！");
                    TxtData.PolishData.PartMatlabFile = null;
                    TxtData.PolishData.PartRecipeName = null;
                    return;
                }
                if (!System.IO.File.Exists(TE_File.Text))
                {
                    MessageBox.Show("文件不存在！");
                    TxtData.PolishData.PartMatlabFile = null;
                    TxtData.PolishData.PartRecipeName = null;
                    return;
                }
            this.Close();

        }

        private void BT_File_Click(object sender, EventArgs e)
        {
            string FileName = null;
            if ((FileName = PublicFunc.OpenDir_Show()) == null)
            {
                return;
            }
            TE_File.Text = FileName;
        }




    }
}
