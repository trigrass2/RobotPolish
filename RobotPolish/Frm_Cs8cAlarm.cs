//using System.Linq;
using System;
using System.Data;
using System.Windows.Forms;
using RobotKit;

namespace RobotPolish
{
    public partial class Frm_Cs8cAlarm : Std_Form
    {
        string[] date;
        string[] Txt;
        public Frm_Cs8cAlarm()
        {
            InitializeComponent();
        }


        void DataRefresh()
        {
            try
            {

            
            if (TxtData.SoapData.SoapStaus)
            {
                FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);
                ftp.DownLoadLog();

               if (   !PublicFunc.ReadCs8CLog(out date,out Txt))
               {
                   return;
               }
             
                if (date!=null &&Txt!=null)
                {

                    DataView dv = new DataView();
                    dv.Table = new System.Data.DataTable("Sequen");
                    dv.Table.Columns.Add();
                    dv.Table.Columns.Add();
                    dv.Table.Rows.Clear();
                    for (int i = Txt.Length - 1; i >= 0; i--)
                    {
                        if (Txt[i] != null && Txt[i].IndexOf("COM-PC:") < 0)
                        {

                                dv.Table.Rows.Add((object[])new string[] { date[i], Txt[i] });

                        }

                    }

                    
                    GC_Alarm.DataSource = dv;
                    gv.Columns[0].Caption = "日期";
                    gv.Columns[1].Caption = "报警信息";

                }



            }

            }
            catch
            {

            }




        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            if (TxtData.PublicData.FtpLog)
            {
                DataRefresh();
            }
            
        }

        private void Frm_Cs8cAlarm_Load(object sender, EventArgs e)
        {

            DataRefresh();

        }

        private void BT_OutPort_Click(object sender, EventArgs e)
        {
            string FileName;
            if (gv.RowCount==0)
            {
                MessageBox.Show("没有日志记录");
                return;
            }
            if ((FileName = PublicFunc.SfD_Show(Application.StartupPath, "XLS文件|*.xls")) == null)
            {
                return;
            }
            gv.ExportToXls(FileName);
        }




    }
}
