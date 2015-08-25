using System;
using System.Windows.Forms;
using RobotKit;
using System.Text.RegularExpressions;

namespace RobotPolish
{
    public partial class Edit_Recipe : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        bool CreatRecipe=false;
        public string RecipeName = "";
        double[] frame = new double[6];
        double[] offset = new double[6];
        string Remark = "";
        public Edit_Recipe(string RecipeName)
        {
            InitializeComponent();
            this.RecipeName = RecipeName;
            TE_RecipeName.Text = RecipeName;
            TE_RecipeName.Enabled = false;
        }

        public Edit_Recipe(bool CreatRecipe)
        {
            InitializeComponent();
            this.CreatRecipe = CreatRecipe;
            if (CreatRecipe)
            {
                this.Text = "新建产品";
                CBE_Type.EditValue = 1;

            }
        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {

           Remark = TE_Remark.Text;
           RecipeName = TE_RecipeName.Text.Trim();
            double.TryParse(TE_F1.Text, out frame[0]);
            double.TryParse(TE_F2.Text, out frame[1]);
            double.TryParse(TE_F3.Text, out frame[2]);
            double.TryParse(TE_F4.Text, out frame[3]);
            double.TryParse(TE_F5.Text, out frame[4]);
            double.TryParse(TE_F6.Text, out frame[5]);


            double.TryParse(TE_O1.Text, out offset[0]);
            double.TryParse(TE_O2.Text, out offset[1]);
            double.TryParse(TE_O3.Text, out offset[2]);
            double.TryParse(TE_O4.Text, out offset[3]);
            double.TryParse(TE_O5.Text, out offset[4]);
            double.TryParse(TE_O6.Text, out offset[5]);




            if (CreatRecipe)
            {
                if (RecipeName.Trim() == "")
                {
                    MessageBox.Show("名称为空");
                    return;
                }
                if (!Regex.IsMatch(RecipeName.Trim(), @"^[a-zA-Z0-9_]+$"))
                {
                    MessageBox.Show("名称不符合规范");
                    return;
                }
                                

                if (db.ExistRecipe(RecipeName))
                {
                    MessageBox.Show("产品名称已存在！");
                    return;
                }
                else
                {


                



                    if (db.AddRecipe(RecipeName, int.Parse(CBE_Type.EditValue.ToString()),frame,offset,Remark))
                    {
                        
                        this.Close();
                        
                    }
                    else
                    {
                        RecipeName = "";
                        MessageBox.Show("操作错误！");
                        return;
                    }


                }


            }
            else
            {


                if (TC_Traj.SelectedTabPageIndex == 2)
                {
                    double.TryParse(FL1.Text, out frame[0]);
                    double.TryParse(FL2.Text, out frame[1]);
                    double.TryParse(FL3.Text, out frame[2]);
                    double.TryParse(FL4.Text, out frame[3]);
                    double.TryParse(FL5.Text, out frame[4]);
                    double.TryParse(FL6.Text, out frame[5]);
                }

                if (TC_Traj.SelectedTabPageIndex == 3)
                {
                    double.TryParse(TL1.Text, out offset[0]);
                    double.TryParse(TL2.Text, out offset[1]);
                    double.TryParse(TL3.Text, out offset[2]);
                    double.TryParse(TL4.Text, out offset[3]);
                    double.TryParse(TL5.Text, out offset[4]);
                    double.TryParse(TL6.Text, out offset[5]);

                }

                //
                if (db.EditRecipe(RecipeName, int.Parse(CBE_Type.EditValue.ToString()), frame, offset, Remark))
                {

                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作错误！");
                    return;
                }

            }

        }

        private void TP_Frame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edit_Recipe_Load(object sender, EventArgs e)
        {
            int i = 0;
            if (!CreatRecipe)
            {
                if ((frame = db.GetRecipe(RecipeName, ref offset, ref Remark, ref i)) != null && offset!=null)
                {

                    TE_Remark.Text = Remark;
                    CBE_Type.EditValue = i;

                    TE_F1.Text = frame[0].ToString();
                    TE_F2.Text = frame[1].ToString();
                    TE_F3.Text = frame[2].ToString();
                    TE_F4.Text = frame[3].ToString();
                    TE_F5.Text = frame[4].ToString();
                    TE_F6.Text = frame[5].ToString();

                    TE_O1.Text = offset[0].ToString();

                    TE_O2.Text = offset[1].ToString();

                    TE_O3.Text = offset[2].ToString();

                    TE_O4.Text = offset[3].ToString();

                    TE_O5.Text = offset[4].ToString();

                    TE_O6.Text = offset[5].ToString();


                }
                string[] Item = new string[50];
                for (int j = 1; j <= 50; j++)
                {
                    Item[j - 1] = j.ToString();
                }
                CBE_Tool.Properties.Items.AddRange((object[])Item);
                CBE_Tool.SelectedIndex = 0;

                CBE_Frame.Properties.Items.AddRange((object[])Item);
                CBE_Frame.SelectedIndex = 0;
            }
            else
            {
                TC_Traj.TabPages.Remove(ToolLib);
                TC_Traj.TabPages.Remove(FrameLib);

            }
        }

        private void CBE_Tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = db.GetPresetList("TOOL", CBE_Tool.SelectedIndex + 1);
            if (data != null)
            {

                //SE_1.Value = decimal.Parse(data[0]);
                //SE_2.Value = decimal.Parse(data[1]);
                //SE_3.Value = decimal.Parse(data[2]);
                //SE_4.Value = decimal.Parse(data[3]);
                //SE_5.Value = decimal.Parse(data[4]);
                //SE_6.Value = decimal.Parse(data[5]);
                //TE_Remark.Text = data[6];
                TL1.Text = data[0];
                TL2.Text = data[1];
                TL3.Text = data[2];
                TL4.Text = data[3];
                TL5.Text = data[4];
                TL6.Text = data[5];


                ll_tool.Text = "工具库说明:" + data[6];



            }
        }

        private void CBE_Frame_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = db.GetPresetList("FRAME", CBE_Frame.SelectedIndex + 1);
            if (data != null)
            {

                //SE_1.Value = decimal.Parse(data[0]);
                //SE_2.Value = decimal.Parse(data[1]);
                //SE_3.Value = decimal.Parse(data[2]);
                //SE_4.Value = decimal.Parse(data[3]);
                //SE_5.Value = decimal.Parse(data[4]);
                //SE_6.Value = decimal.Parse(data[5]);
                //TE_Remark.Text = data[6];
                FL1.Text = data[0];
                FL2.Text = data[1];
                FL3.Text = data[2];
               FL4.Text = data[3];
                FL5.Text = data[4];
               FL6.Text = data[5];

               LL_RecipeRemark.Text = "产品坐标系库说明:" + data[6];
                                





            }
        }
    }
}
