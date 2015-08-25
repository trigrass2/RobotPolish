//using System.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RobotPolish
{
    public partial class Frm_Infor : Std_Form
    {
        public Frm_Infor()
        {
            InitializeComponent();
        }

        private void Frm_Infor_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath+"\\MainShow.jpg"))
            {
                this.PE_Main.Image =Image.FromFile(Application.StartupPath + "\\MainShow.jpg");
            }
        }
    }
}
