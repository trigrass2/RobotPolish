using System;
using System.Windows.Forms;
using RobotKit;

namespace RobotPolish
{
    public partial class Edit_ToolZ : DevExpress.XtraEditors.XtraForm
    {
        DataBaseManage db = new DataBaseManage();
        string PresetName = null;
        int SelectIndex;
        public Edit_ToolZ(string preset, int index)
        {
            InitializeComponent();
            PresetName = preset;
            SelectIndex = index;
          //  LL_Preset.Text = "工艺名:" + PresetName;
            //if (preset.ToUpper()!="Staublipreset".ToUpper())
            //{
            //    LC_Name.Text = "速度:";
            //}

            if (TxtData.PolishData.IsEditTool)
            {
                this.Text = "工具值Z轴变动(输入法切换到英文)";
                PresetName = "TOOL";
            }
            else
            {

                this.Text = "编辑产品坐标系";
                PresetName = "FRAME";
            }

        }

        private void BT_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Empty_Click(object sender, EventArgs e)
        {

            SE_1.Value = 0;
            SE_2.Value = 0;
            SE_3.Value = 0;
            SE_4.Value = 0;
            SE_5.Value = 0;
            SE_6.Value = 0;
        }

        private void BT_Apply_Click(object sender, EventArgs e)
        {
           double[] data= new double[]   {
                (double) (SE_1.Value), (double) (SE_2.Value), (double) (SE_3.Value),
                (double) (SE_4.Value), (double) (SE_5.Value), (double) (SE_6.Value)
            };
           data = Val3.TrsfTrsf(data, Val3.InverseTrsf(new double[] { 0, 0, (double)(SE_Z.Value), 0, 0, 0 }));
            if (data==null)
            {
                MessageBox.Show("错误");
                return;
            }

            double[] databuff = new double[7];

            for (int i=0;i<6;i++)
            {
                databuff[i + 1] = Math.Round(data[i],3);
            }

            databuff[0] = CBE_IO.SelectedIndex + 1;


            db.EditPresetList(PresetName, databuff, TE_Remark.Text);
        }

        private void BT_ok_Click(object sender, EventArgs e)
        {
            BT_Apply_Click(this, null);
            BT_Cancle_Click(this, null);}

        private void Edit_Preset_Leave(object sender, EventArgs e)
        {
                        
        }

        private void Edit_Preset_Load(object sender, EventArgs e)
        {
            CBE_IO.Properties.Items.Clear();
            string[] Item;
            //if (PresetName=="StaubliPreset")
            //{
                Item=new string[50];
                for (int i=1;i<=50;i++)
                {
                    Item[i-1]=i.ToString();
                }
                CBE_IO.Properties.Items.AddRange((object[])Item);
                CBE_IO.SelectedIndex = SelectIndex;

            //}
            //else
            //{
            //    Item=new string[200];
            //    for (int i=1;i<=200;i++)
            //    {
            //        Item[i-1]=i.ToString();
            //    }

            //}
               //CBE_IO.Properties.Items.AddRange((object[])Item);
               //CBE_IO.SelectedIndex = SelectIndex;

        }

        private void CBE_IO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] data = db.GetPresetList(PresetName,CBE_IO.SelectedIndex+1);
            if (data!=null&&data.Length>=12)
            {

                SE_1.Value = decimal.Parse(data[0]);
                SE_2.Value = decimal.Parse(data[1]);
                SE_3.Value = decimal.Parse(data[2]);
                SE_4.Value = decimal.Parse(data[3]);
                SE_5.Value = decimal.Parse(data[4]);
                SE_6.Value = decimal.Parse(data[5]);
                TE_Remark.Text = data[11];

            }
                        
        }
    }
}
