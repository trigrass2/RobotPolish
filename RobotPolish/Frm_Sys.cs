using System;

namespace RobotPolish
{
    public partial class Frm_Sys : Std_Form
    {
        public Frm_Sys()
        {
            InitializeComponent();
        }

        private void PE_R1_Click(object sender, EventArgs e)
        {
            if ( sender is DevExpress.XtraEditors.PictureEdit)
            {

                DevExpress.XtraEditors.PictureEdit buff = (DevExpress.XtraEditors.PictureEdit)(sender);
                int Index = buff.TabIndex;
                LL_ID.Text="机器人序号:"+Index.ToString();
                LL_Remark.Text="备注:"+TxtData.RobotGroup.Remark[Index];
                LL_IP.Text="ip:"+TxtData.RobotGroup.IpAddress[Index];
                LL_Type.Text = "机器人类型:" + TxtData.RobotGroup.Type[Index];

            



            }




        }

        private void PE_R1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Sys_Load(object sender, EventArgs e)
        {
            PE_R1_Click(PE_R1, null);
        }

        private void TB_View1_Click(object sender, EventArgs e)
        {
            //double[,] Ncdata=PublicFunc.ReadNCFile(@"C:\1.TXT");
            //if (Ncdata==null)
            //{
            //    MessageBox.Show("读取文件出错！");
            //    return;
            //}
            //if (!PublicFunc.SaveNCFile(@"c:\2.txt", Ncdata, TxtData.MdbData.Tool))
            //{
            //    MessageBox.Show("生成文件出错！");
            //    return;

            //}



        }
    }
}
