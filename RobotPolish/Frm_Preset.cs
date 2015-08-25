//using System.Linq;
using System;
using System.Threading;
using System.Windows.Forms;

namespace RobotPolish
{
    public partial class Frm_Preset : Std_DataView
    {
        string FileName = null;
        
        public Frm_Preset()
        {
            InitializeComponent();
            this.BT_Teach.Text = "添加";
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if (CBE_PresetName.Properties.Items.Count==0)
            {
                MessageBox.Show("没有工艺");
                return;
            }
            if (MessageBox.Show("确定需要删除吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollDelete));
            Frm_Wait frm = new Frm_Wait("", false);
            frm.ShowDialog();
            Frm_Preset_Load(this, null);
        }

        private void Frm_Preset_Load(object sender, EventArgs e)
        {
            CBE_PresetName.Properties.Items.Clear();
            TxtData.PublicData.PresetName = db.GetPresetName();
      
            if (TxtData.PublicData.PresetName != null)
            {
                CBE_PresetName.Properties.Items.AddRange((object[])(TxtData.PublicData.PresetName));
                CBE_PresetName.SelectedIndex = 0;
              
            }
            else
            {
                CBE_PresetName.Text = "";

            }
            CBE_PresetName_SelectedValueChanged(this,null);
            //去除其中的列和题头
            //   GC_Modbus.

        }

        private void CBE_PresetName_SelectedValueChanged(object sender, EventArgs e)
        {
              if (TxtData.PublicData.PresetName == null||CBE_PresetName.Text.Trim()=="")
            {
                return;
            }
            LL_ReMark.Text = "工艺备注:"+db.GetPresetRemark(CBE_PresetName.Text);
            GC_Modbus.DataSource = db.GetDV_Presetlist(CBE_PresetName.Text.ToString());
            if (gv.RowCount > 12)
            {
                gv.Columns.Remove(gv.Columns["PRESETNAME"]);
                gv.Columns.Remove(gv.Columns["ID"]);
                gv.Columns.Remove(gv.Columns["BP1"]);
                gv.Columns.Remove(gv.Columns["BP2"]);
                gv.Columns.Remove(gv.Columns["BP3"]);
                gv.Columns.Remove(gv.Columns["BP4"]);
                gv.Columns.Remove(gv.Columns["REMARK"]);
                gv.Columns["INDEX"].Caption = "速度(mm/s)";
                gv.Columns["POWERATE"].Caption = "激光功率(%)";
                gv.Columns["FREQUEN"].Caption = "占空比频率(%)";
                gv.Columns["PWM"].Caption = "占空比大小(%)";
                gv.Columns["PRESSURE"].Caption = "气体压力(%)";
                gv.Columns["FOLLOWSEN"].Caption = "随动高度(%)";
                //gv.Columns["REMARK"].Caption = "备注";
                gv.Columns["INDEX"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            }
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            if (CBE_PresetName.Properties.Items.Count == 0)
            {
                MessageBox.Show("没有工艺");
                return;
            }
            if (CBE_PresetName.Properties.Items.Count != 0)
            {
                Edit_Preset frm = new Edit_Preset(CBE_PresetName.EditValue.ToString(), gv.GetSelectedRows()[0]);
                frm.ShowDialog();
                Frm_Preset_Load(this,null);
            }
        }

        private void BT_Import_Click(object sender, EventArgs e)
        {
            if (CBE_PresetName.Properties.Items.Count == 0)
            {
                MessageBox.Show("没有工艺");
                return;
            }
            if ((FileName = PublicFunc.OpenDir_Show()) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollImport));
            Frm_Wait frm = new Frm_Wait("", false);
            frm.ShowDialog();
           
        }

        void PollImport(object target)
        {
            TxtData.PublicData.ErrorCode = db.ImportPreset(FileName, CBE_PresetName.EditValue.ToString()) == 0 ? 40 : 39;

        }


        void PollOutport(object target)
        {

            TxtData.PublicData.ErrorCode = db.SavePreset(CBE_PresetName.EditValue.ToString(), FileName) ? 40 : 2;
        }

        private void BT_OutPort_Click(object sender, EventArgs e)
        {
            if (CBE_PresetName.Properties.Items.Count == 0)
            {
                MessageBox.Show("没有工艺");
                return;
            }
            if ((FileName = PublicFunc.SfD_Show()) == null)
            {
                return;
            }
            TxtData.PublicData.ErrorCode = 0;

            System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(PollOutport));
            Frm_Wait frm = new Frm_Wait("", false);
            frm.ShowDialog();
        }

        void PollDelete(object target)
        {


            TxtData.PublicData.ErrorCode = db.DeletePreset(CBE_PresetName.EditValue.ToString()) ? 40 : 2;
        }



       




    }
}
