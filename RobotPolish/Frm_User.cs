using System;
using System.Windows.Forms;
using RobotKit;

namespace RobotPolish
{
    public partial class Frm_User : Std_Form
    {
        private DataBaseManage db = new DataBaseManage();

        public Frm_User()
        {
            InitializeComponent();
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
            TableShow();
            db.GetPopedom(ref TxtData.PublicData.ScreenEnable);
         
        }

        private void TableShow()
        {
            GC_User.DataSource = db.GetDV_User();
            if (gv.RowCount > 0)
            {


                gv.Columns.Remove(gv.Columns["PASSWORD"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);
                gv.Columns.Remove(gv.Columns["REMARK"]);
                gv.Columns.Remove(gv.Columns["CELLPHONE"]);
                gv.Columns.Remove(gv.Columns["FAX"]);

                //gv.Columns.Remove(gv.Columns["ARRAY_XCOUNT"]);
                //gv.Columns.Remove(gv.Columns["ARRAY_XOFFSET"]);
                //gv.Columns.Remove(gv.Columns["ARRAY_YCOUNT"]);
                //gv.Columns.Remove(gv.Columns["ARRAY_YOFFSET"]);
                ////gv.Columns.Remove(gv.Columns["OFFSET_X"]);
                ////************************************************
                gv.Columns["USER"].Caption = "用户名";
                gv.Columns["NAME"].Caption = "名称";
                gv.Columns["ACCESSLEVEL"].Caption = "权限";
                gv.Columns["EMAIL"].Caption = "电子邮件";
                gv.Columns["TELEPHONE"].Caption = "电话";




            }
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if (gv.RowCount == 0)
            {
                MessageBox.Show("没有选择项");
                return;
            }
            if (MessageBox.Show("确定需要删除吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            string Name = gv.GetFocusedRowCellValue("USER").ToString();
            db.DeleteUser(Name);

            Frm_User_Load(this, null);


        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            if (gv.RowCount == 0)
            {
                MessageBox.Show("没有可编辑项");
                return;
            }
            string Name = gv.GetFocusedRowCellValue("USER").ToString();
            Edit_User frm = new Edit_User(Name);
            frm.ShowDialog();
            Frm_User_Load(this, null);
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            Edit_User frm = new Edit_User();
            frm.ShowDialog();
            Frm_User_Load(this, null);
        }



    }
}