//using System.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;
using RobotKit;


namespace RobotPolish
{
    public partial class Frm_Position : Std_Form
    {
        DataBaseManage db = new DataBaseManage();
        public Frm_Position()
        {
            InitializeComponent();
            if (System.IO.File.Exists(Application.StartupPath + "\\RobotShow.jpg"))
            {
                this.PE_Robot.Image = Image.FromFile(Application.StartupPath + "\\RobotShow.jpg");
            }
        }

        private void GC_Tool_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_TeachHome_Click(object sender, EventArgs e)
        {
            Teach(15);
        }

        private void BT_TeachTool_Click(object sender, EventArgs e)
        {
            Teach(14);
        }

        private void BT_EditHome_Click(object sender, EventArgs e)
        {
            Edit_HomeTcp frm = new Edit_HomeTcp(false);
            frm.ShowDialog();
            ReadHomeTcp();
        }

        private void BT_EditTool_Click(object sender, EventArgs e)
        {
            Edit_HomeTcp frm = new Edit_HomeTcp(true);
            frm.ShowDialog();
            ReadHomeTcp();
        }


        private void Teach(int Flag)
        {


            if (TxtData.SoapData.InterfaceType != 9)
            {
                MessageBox.Show("下位机请切换到主界面!");
                return;
            }

            if (TxtData.SoapData.ToolMode != 1)
            {
                MessageBox.Show("请切换到手动模式!");
                return;
            }
            TxtData.PolishData.UploadType = 1;
            TxtData.PublicData.ErrorCode = RobotKit.SoapInstance.SoapRead.SetAppdata("nVirtualKey", 275) ? 40 : 12;
            Frm_Wait frm = new Frm_Wait("",true);
            frm.ShowDialog();
            ReadHomeTcp();
                        
        }




        private void ReadHomeTcp()
        {
            TxtData.MdbData.Home = db.GetHome();
            TxtData.MdbData.Tool = db.GetTool();
            if (TxtData.MdbData.Home != null && TxtData.MdbData.Tool != null)
            {


                LL_J1.Text = "J1:" + TxtData.MdbData.Home[0].ToString();
                LL_J2.Text = "J2:" + TxtData.MdbData.Home[1].ToString();
                LL_J3.Text = "J3:" + TxtData.MdbData.Home[2].ToString();
                LL_J4.Text = "J4:" + TxtData.MdbData.Home[3].ToString();
                LL_J5.Text = "J5:" + TxtData.MdbData.Home[4].ToString();
                LL_J6.Text = "J6:" + TxtData.MdbData.Home[5].ToString();


                LL_T1.Text = "X:" + TxtData.MdbData.Tool[0].ToString();
                LL_T2.Text = "Y:" + TxtData.MdbData.Tool[1].ToString();
                LL_T3.Text = "Z:" + TxtData.MdbData.Tool[2].ToString();
                LL_T4.Text = "RX:" + TxtData.MdbData.Tool[3].ToString();
                LL_T5.Text = "RY" + TxtData.MdbData.Tool[4].ToString();
                LL_T6.Text = "RZ:" + TxtData.MdbData.Tool[5].ToString();

            }

        }

        private void Frm_Position_Load(object sender, EventArgs e)
        {
            ReadHomeTcp();
            if (TxtData.SoapData.SoapStaus)
            {

                TxtData.SoapData.ValVersion = SoapInstance.SoapRead.GetControllerVersion();
                TxtData.SoapData.RobotType = SoapInstance.SoapRead.GetArmType();


            }

            LL_RobotType.Text = "机器人类型:" + TxtData.SoapData.RobotType;
            LL_Val.Text = "Val3版本:" + TxtData.SoapData.ValVersion;
            LL_IP.Text = "IP:" + TxtData.XMLConfigure.IpAddress;
        }

        private void BT_EditIP_Click(object sender, EventArgs e)
        {
            string Buff = TxtData.XMLConfigure.IpAddress;
            Edit_Ip frm = new Edit_Ip(1);
            frm.ShowDialog();
           // Frm_Cs8cConfig_Load(this, null);
            db.GetIp(ref TxtData.XMLConfigure.IpAddress, ref TxtData.XMLConfigure.RestrictCode);
            PublicFunc.ReadXMLConfigure();
            if (TxtData.XMLConfigure.IpAddress != Buff)
            {


                MessageBox.Show("请关闭软件并重新打开");
            }
        }

    }
}
