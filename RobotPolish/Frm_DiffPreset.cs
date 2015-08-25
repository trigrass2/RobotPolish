using System;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using RobotKit;

namespace RobotPolish
{
    public partial class Frm_DiffPreset : Std_DataView
    {
        string FileName = null;
        public Frm_DiffPreset()
        {
            InitializeComponent();
        }

        private void Frm_StaubliPreset_Load(object sender, EventArgs e)
        {
            BT_Z.Visible = TxtData.PolishData.IsEditTool ? true : false;
            BT_Diff.Visible = BT_Z.Visible;
            GC_Modbus.DataSource = TxtData.PolishData.IsEditTool ? db.GetDV_Presetlist("TOOL") : db.GetDV_Presetlist("FRAME");
           //去除其中的列和题头
            //   GC_Modbus.
            if (gv.RowCount > 12)
            {
                gv.Columns.Remove(gv.Columns["PRESETNAME"]);
                gv.Columns.Remove(gv.Columns["ID"]);
               // gv.Columns.Remove(gv.Columns["BP1"]);

                gv.Columns.Remove(gv.Columns["BP7"]);
                gv.Columns.Remove(gv.Columns["BP8"]);
                gv.Columns.Remove(gv.Columns["BP9"]);
                gv.Columns.Remove(gv.Columns["BP10"]);

                if (!TxtData.PolishData.IsEditTool)
                {
                    gv.Columns.Remove(gv.Columns["BP2"]);
                    gv.Columns.Remove(gv.Columns["BP3"]);
                    gv.Columns.Remove(gv.Columns["BP4"]);
        
                    gv.Columns.Remove(gv.Columns["BP5"]);
                    gv.Columns.Remove(gv.Columns["BP6"]);
     




                }
                else
                {
                    gv.Columns["BP2"].Caption = "MOVEJ提升";
                    gv.Columns["BP3"].Caption = "打磨压力";
                    gv.Columns["BP4"].Caption = "公转速度";
                    gv.Columns["BP5"].Caption = "自转速度";
                    gv.Columns["BP6"].Caption = "转台速度";
                  //  gv.Columns["BP10"].Caption = "备注";

                }



                gv.Columns["INDEX"].Caption = "序号";
                gv.Columns["POWERATE"].Caption = "X";
                gv.Columns["FREQUEN"].Caption = "Y";
                gv.Columns["PWM"].Caption = "Z";
                gv.Columns["PRESSURE"].Caption = "RX";
                gv.Columns["FOLLOWSEN"].Caption = "RY";
                //gv.Columns["BP1"].Caption = "RZ";
                //gv.Columns["REMARK"].Caption = "备注";
                                

                gv.Columns["BP1"].Caption = "RZ";
                gv.Columns["REMARK"].Caption = "备注";
                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

                for (int i = 0; i < gv.Columns.Count; i++)
                {

                    gv.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;


                }

            }
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            string Buff=TxtData.PolishData.IsEditTool?"TOOL":"FRAME";
            if (TxtData.PolishData.IsEditTool)
            {
                Edit_ToolLib frm = new Edit_ToolLib(Buff, gv.GetSelectedRows()[0]);
                frm.ShowDialog();
            }
            else
            {
                Edit_Preset frm = new Edit_Preset(Buff, gv.GetSelectedRows()[0]);
                frm.ShowDialog();
            }
 
            Frm_StaubliPreset_Load(this, null);
        }

        private void BT_Teach_Click(object sender, EventArgs e)
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


            TxtData.PublicData.ErrorCode = 0;
            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Poll));
            Frm_Wait frm = new Frm_Wait(true);
            frm.ShowDialog();
            Frm_StaubliPreset_Load(this, null);
        }

        void Poll(object target)
        {
            try
            {
 
            //if (!db.SavePreset())
            //{
            //    TxtData.PublicData.ErrorCode = 1;
            //    return;
            //}

            //FtpClient ftp = new FtpClient(TxtData.XMLConfigure.IpAddress);

            //if (!ftp.UpLoadPreset())
            //{
            //    TxtData.PublicData.ErrorCode = 21;
            //    return;
            //}



                if (TxtData.PolishData.IsEditTool)
                {
                    if (!SoapInstance.SoapRead.SetAppdata("nVirtualKey", 273))
                    {
                        TxtData.PublicData.ErrorCode = 12;
                        return;
                    }
                    TxtData.PolishData.UploadType = 2;
                }
                else
                {
                    if (!SoapInstance.SoapRead.SetAppdata("nVirtualKey", 274))
                    {
                        TxtData.PublicData.ErrorCode = 12;
                        return;
                    }
                    TxtData.PolishData.UploadType = 3;
                }

                TxtData.PolishData.UploadIndex = gv.GetSelectedRows()[0];

            while (TxtData.SoapData.InterfaceType == 9)
            {
                System.Threading.Thread.Sleep(10);
            }
            TxtData.PublicData.ErrorCode = 40;
            }
            catch (System.Exception ex)
            {
                TxtData.PublicData.ErrorCode = 12;
            }
                        

        }
  
        private void BT_Import_Click(object sender, EventArgs e)
        {
            if ((FileName = PublicFunc.OpenDir_Show()) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait("", false);
            frm.ShowDialog();
            Frm_StaubliPreset_Load(this, null);
        }

        void PollImport(object target)
        {
            if (TxtData.PolishData.IsEditTool)
            {
                TxtData.PublicData.ErrorCode = (db.ImportPreset(FileName, "TOOL") == 0) ? 40 : 17;
            }
            else
            {
                TxtData.PublicData.ErrorCode = (db.ImportPreset(FileName, "FRAME") == 0) ? 40 : 17;
            }

        }


        void PollOutport(object target)
        {
            if (TxtData.PolishData.IsEditTool)
            {
                TxtData.PublicData.ErrorCode = db.SavePreset("TOOL", FileName) ? 40 : 2;
       
            }
            else
            {
                TxtData.PublicData.ErrorCode = db.SavePreset("FRAME", FileName) ? 40 : 2;
                }
        }

        private void BT_OutPort_Click(object sender, EventArgs e)
        {
            if ((FileName = PublicFunc.SfD_Show()) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollOutport));
            Frm_Wait frm = new Frm_Wait("", false);
            frm.ShowDialog();
            Frm_StaubliPreset_Load(this, null);}

        private void BT_Z_Click(object sender, EventArgs e)
        {
            string Buff = TxtData.PolishData.IsEditTool ? "TOOL" : "FRAME";
            Edit_ToolZ frm = new Edit_ToolZ(Buff, gv.GetSelectedRows()[0]);
            frm.ShowDialog();
            Frm_StaubliPreset_Load(this, null);
         
        }

        private void BT_Diff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定需要以第一个工具为标准工具进行\nZ轴 10mm 方向的差分吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            string[] data= db.GetPresetList("TOOL", 1);
            double[] ddata = new double[6];

            if (data==null)
            {
                return;
            }
            for (int i=0;i<6;i++)
            {
                if (!double.TryParse(data[i], out ddata[i]))
                {
                    MessageBox.Show("数据转换不成功");
                    return;
                }
                
            }

            double[][] Buff = PublicFunc.DiffTool(ddata);


            if (Buff==null)
            {

                MessageBox.Show("转换不成功");
                    return;
            }


            if (db.EditPresetList(Buff))
            {
                MessageBox.Show("成功");
            }
            else
            {


                MessageBox.Show("失败");

            }

            Frm_StaubliPreset_Load(this, null);




        }

    }
}
