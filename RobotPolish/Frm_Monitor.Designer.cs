namespace RobotPolish
{
    partial class Frm_Monitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GC_Cut = new DevExpress.XtraGrid.GridControl();
            this.GV_Cut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Oper = new DevExpress.XtraEditors.GroupControl();
            this.BT_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Infor = new DevExpress.XtraEditors.GroupControl();
            this.ll9 = new System.Windows.Forms.Label();
            this.ll8 = new System.Windows.Forms.Label();
            this.ll7 = new System.Windows.Forms.Label();
            this.ll6 = new System.Windows.Forms.Label();
            this.ll5 = new System.Windows.Forms.Label();
            this.ll4 = new System.Windows.Forms.Label();
            this.ll3 = new System.Windows.Forms.Label();
            this.ll2 = new System.Windows.Forms.Label();
            this.ll1 = new System.Windows.Forms.Label();
            this.ll0 = new System.Windows.Forms.Label();
            this.GC_Preset = new DevExpress.XtraEditors.GroupControl();
            this.LL_TEnable = new DevExpress.XtraEditors.LabelControl();
            this.LL_ATI = new DevExpress.XtraEditors.LabelControl();
            this.LL_MainEnable = new DevExpress.XtraEditors.LabelControl();
            this.LL_Table = new DevExpress.XtraEditors.LabelControl();
            this.LL_MainPower = new DevExpress.XtraEditors.LabelControl();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.GC_Traj = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Oper)).BeginInit();
            this.GC_Oper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Infor)).BeginInit();
            this.GC_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Preset)).BeginInit();
            this.GC_Preset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_Cut
            // 
            this.GC_Cut.Location = new System.Drawing.Point(319, 3);
            this.GC_Cut.MainView = this.GV_Cut;
            this.GC_Cut.Name = "GC_Cut";
            this.GC_Cut.Size = new System.Drawing.Size(716, 587);
            this.GC_Cut.TabIndex = 5;
            this.GC_Cut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Cut});
            // 
            // GV_Cut
            // 
            this.GV_Cut.ActiveFilterEnabled = false;
            this.GV_Cut.GridControl = this.GC_Cut;
            this.GV_Cut.Name = "GV_Cut";
            this.GV_Cut.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Cut.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Cut.OptionsBehavior.AutoSelectAllInEditor = false;
            this.GV_Cut.OptionsBehavior.Editable = false;
            this.GV_Cut.OptionsCustomization.AllowColumnMoving = false;
            this.GV_Cut.OptionsCustomization.AllowFilter = false;
            this.GV_Cut.OptionsCustomization.AllowGroup = false;
            this.GV_Cut.OptionsCustomization.AllowSort = false;
            this.GV_Cut.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GV_Cut.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Cut.OptionsView.ShowGroupPanel = false;
            this.GV_Cut.SynchronizeClones = false;
            this.GV_Cut.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_Cut_CustomDrawCell);
            // 
            // GC_Oper
            // 
            this.GC_Oper.Controls.Add(this.BT_Stop);
            this.GC_Oper.Controls.Add(this.BT_Pause);
            this.GC_Oper.Location = new System.Drawing.Point(1042, 476);
            this.GC_Oper.Name = "GC_Oper";
            this.GC_Oper.Size = new System.Drawing.Size(330, 79);
            this.GC_Oper.TabIndex = 6;
            this.GC_Oper.Text = "操作";
            this.GC_Oper.Visible = false;
            // 
            // BT_Stop
            // 
            this.BT_Stop.Location = new System.Drawing.Point(182, 41);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(87, 25);
            this.BT_Stop.TabIndex = 1;
            this.BT_Stop.Text = "结束";
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // BT_Pause
            // 
            this.BT_Pause.Enabled = false;
            this.BT_Pause.Location = new System.Drawing.Point(26, 41);
            this.BT_Pause.Name = "BT_Pause";
            this.BT_Pause.Size = new System.Drawing.Size(87, 25);
            this.BT_Pause.TabIndex = 0;
            this.BT_Pause.Text = "暂停";
            this.BT_Pause.Click += new System.EventHandler(this.BT_Pause_Click);
            // 
            // GC_Infor
            // 
            this.GC_Infor.Controls.Add(this.ll9);
            this.GC_Infor.Controls.Add(this.ll8);
            this.GC_Infor.Controls.Add(this.ll7);
            this.GC_Infor.Controls.Add(this.ll6);
            this.GC_Infor.Controls.Add(this.ll5);
            this.GC_Infor.Controls.Add(this.ll4);
            this.GC_Infor.Controls.Add(this.ll3);
            this.GC_Infor.Controls.Add(this.ll2);
            this.GC_Infor.Controls.Add(this.ll1);
            this.GC_Infor.Controls.Add(this.ll0);
            this.GC_Infor.Location = new System.Drawing.Point(1041, 3);
            this.GC_Infor.Name = "GC_Infor";
            this.GC_Infor.Size = new System.Drawing.Size(330, 280);
            this.GC_Infor.TabIndex = 9;
            this.GC_Infor.Text = "生产信息";
            // 
            // ll9
            // 
            this.ll9.AutoSize = true;
            this.ll9.Location = new System.Drawing.Point(19, 255);
            this.ll9.Name = "ll9";
            this.ll9.Size = new System.Drawing.Size(55, 14);
            this.ll9.TabIndex = 9;
            this.ll9.Text = "状态未知";
            // 
            // ll8
            // 
            this.ll8.AutoSize = true;
            this.ll8.Location = new System.Drawing.Point(19, 230);
            this.ll8.Name = "ll8";
            this.ll8.Size = new System.Drawing.Size(55, 14);
            this.ll8.TabIndex = 8;
            this.ll8.Text = "状态未知";
            // 
            // ll7
            // 
            this.ll7.AutoSize = true;
            this.ll7.Location = new System.Drawing.Point(19, 206);
            this.ll7.Name = "ll7";
            this.ll7.Size = new System.Drawing.Size(55, 14);
            this.ll7.TabIndex = 7;
            this.ll7.Text = "状态未知";
            // 
            // ll6
            // 
            this.ll6.AutoSize = true;
            this.ll6.Location = new System.Drawing.Point(19, 181);
            this.ll6.Name = "ll6";
            this.ll6.Size = new System.Drawing.Size(55, 14);
            this.ll6.TabIndex = 6;
            this.ll6.Text = "状态未知";
            // 
            // ll5
            // 
            this.ll5.AutoSize = true;
            this.ll5.Location = new System.Drawing.Point(19, 156);
            this.ll5.Name = "ll5";
            this.ll5.Size = new System.Drawing.Size(55, 14);
            this.ll5.TabIndex = 5;
            this.ll5.Text = "状态未知";
            // 
            // ll4
            // 
            this.ll4.AutoSize = true;
            this.ll4.Location = new System.Drawing.Point(19, 131);
            this.ll4.Name = "ll4";
            this.ll4.Size = new System.Drawing.Size(55, 14);
            this.ll4.TabIndex = 4;
            this.ll4.Text = "状态未知";
            // 
            // ll3
            // 
            this.ll3.AutoSize = true;
            this.ll3.Location = new System.Drawing.Point(19, 107);
            this.ll3.Name = "ll3";
            this.ll3.Size = new System.Drawing.Size(55, 14);
            this.ll3.TabIndex = 3;
            this.ll3.Text = "状态未知";
            // 
            // ll2
            // 
            this.ll2.AutoSize = true;
            this.ll2.Location = new System.Drawing.Point(19, 82);
            this.ll2.Name = "ll2";
            this.ll2.Size = new System.Drawing.Size(55, 14);
            this.ll2.TabIndex = 2;
            this.ll2.Text = "状态未知";
            // 
            // ll1
            // 
            this.ll1.AutoSize = true;
            this.ll1.Location = new System.Drawing.Point(19, 57);
            this.ll1.Name = "ll1";
            this.ll1.Size = new System.Drawing.Size(55, 14);
            this.ll1.TabIndex = 1;
            this.ll1.Text = "状态未知";
            // 
            // ll0
            // 
            this.ll0.AutoSize = true;
            this.ll0.Location = new System.Drawing.Point(19, 32);
            this.ll0.Name = "ll0";
            this.ll0.Size = new System.Drawing.Size(55, 14);
            this.ll0.TabIndex = 0;
            this.ll0.Text = "状态未知";
            // 
            // GC_Preset
            // 
            this.GC_Preset.Controls.Add(this.LL_TEnable);
            this.GC_Preset.Controls.Add(this.LL_ATI);
            this.GC_Preset.Controls.Add(this.LL_MainEnable);
            this.GC_Preset.Controls.Add(this.LL_Table);
            this.GC_Preset.Controls.Add(this.LL_MainPower);
            this.GC_Preset.Location = new System.Drawing.Point(1045, 290);
            this.GC_Preset.Name = "GC_Preset";
            this.GC_Preset.Size = new System.Drawing.Size(330, 180);
            this.GC_Preset.TabIndex = 10;
            this.GC_Preset.Text = "信号";
            // 
            // LL_TEnable
            // 
            this.LL_TEnable.Location = new System.Drawing.Point(6, 34);
            this.LL_TEnable.Name = "LL_TEnable";
            this.LL_TEnable.Size = new System.Drawing.Size(96, 14);
            this.LL_TEnable.TabIndex = 40;
            this.LL_TEnable.Text = "转台启动状态未知";
            // 
            // LL_ATI
            // 
            this.LL_ATI.Location = new System.Drawing.Point(6, 90);
            this.LL_ATI.Name = "LL_ATI";
            this.LL_ATI.Size = new System.Drawing.Size(116, 14);
            this.LL_ATI.TabIndex = 38;
            this.LL_ATI.Text = "置零ATI数据状态未知";
            // 
            // LL_MainEnable
            // 
            this.LL_MainEnable.Location = new System.Drawing.Point(6, 118);
            this.LL_MainEnable.Name = "LL_MainEnable";
            this.LL_MainEnable.Size = new System.Drawing.Size(96, 14);
            this.LL_MainEnable.TabIndex = 41;
            this.LL_MainEnable.Text = "主轴启动状态未知";
            // 
            // LL_Table
            // 
            this.LL_Table.Location = new System.Drawing.Point(6, 146);
            this.LL_Table.Name = "LL_Table";
            this.LL_Table.Size = new System.Drawing.Size(96, 14);
            this.LL_Table.TabIndex = 37;
            this.LL_Table.Text = "转台速度状态未知";
            // 
            // LL_MainPower
            // 
            this.LL_MainPower.Appearance.ForeColor = System.Drawing.Color.Red;
            this.LL_MainPower.Location = new System.Drawing.Point(6, 62);
            this.LL_MainPower.Name = "LL_MainPower";
            this.LL_MainPower.Size = new System.Drawing.Size(96, 14);
            this.LL_MainPower.TabIndex = 39;
            this.LL_MainPower.Text = "主轴上电状态未知";
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Interval = 50;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // GC_Traj
            // 
            this.GC_Traj.Dock = System.Windows.Forms.DockStyle.Left;
            this.GC_Traj.Location = new System.Drawing.Point(0, 0);
            this.GC_Traj.MainView = this.gv;
            this.GC_Traj.Name = "GC_Traj";
            this.GC_Traj.Size = new System.Drawing.Size(313, 590);
            this.GC_Traj.TabIndex = 11;
            this.GC_Traj.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.ActiveFilterEnabled = false;
            this.gv.GridControl = this.GC_Traj;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsCustomization.AllowColumnMoving = false;
            this.gv.OptionsCustomization.AllowColumnResizing = false;
            this.gv.OptionsCustomization.AllowFilter = false;
            this.gv.OptionsCustomization.AllowGroup = false;
            this.gv.OptionsCustomization.AllowSort = false;
            this.gv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv.OptionsView.EnableAppearanceOddRow = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.SynchronizeClones = false;
            // 
            // Frm_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 590);
            this.Controls.Add(this.GC_Traj);
            this.Controls.Add(this.GC_Preset);
            this.Controls.Add(this.GC_Infor);
            this.Controls.Add(this.GC_Oper);
            this.Controls.Add(this.GC_Cut);
            this.Name = "Frm_Monitor";
            this.Text = "Frm_Monitor";
            this.Load += new System.EventHandler(this.Frm_Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Oper)).EndInit();
            this.GC_Oper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Infor)).EndInit();
            this.GC_Infor.ResumeLayout(false);
            this.GC_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Preset)).EndInit();
            this.GC_Preset.ResumeLayout(false);
            this.GC_Preset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl GC_Cut;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Cut;
        private DevExpress.XtraEditors.GroupControl GC_Oper;
        private DevExpress.XtraEditors.SimpleButton BT_Stop;
        private DevExpress.XtraEditors.SimpleButton BT_Pause;
        private DevExpress.XtraEditors.GroupControl GC_Infor;
        private DevExpress.XtraEditors.GroupControl GC_Preset;
        private System.Windows.Forms.Timer timer_Refresh;
        private DevExpress.XtraEditors.LabelControl LL_TEnable;
        private DevExpress.XtraEditors.LabelControl LL_ATI;
        private DevExpress.XtraEditors.LabelControl LL_MainEnable;
        private DevExpress.XtraEditors.LabelControl LL_Table;
        private DevExpress.XtraEditors.LabelControl LL_MainPower;
        private System.Windows.Forms.Label ll9;
        private System.Windows.Forms.Label ll8;
        private System.Windows.Forms.Label ll7;
        private System.Windows.Forms.Label ll6;
        private System.Windows.Forms.Label ll5;
        private System.Windows.Forms.Label ll4;
        private System.Windows.Forms.Label ll3;
        private System.Windows.Forms.Label ll2;
        private System.Windows.Forms.Label ll1;
        private System.Windows.Forms.Label ll0;
        protected DevExpress.XtraGrid.GridControl GC_Traj;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
    }
}