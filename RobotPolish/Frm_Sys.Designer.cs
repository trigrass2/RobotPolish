namespace RobotPolish
{
    partial class Frm_Sys
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
            this.PE_Center = new DevExpress.XtraEditors.PictureEdit();
            this.PE_R3 = new DevExpress.XtraEditors.PictureEdit();
            this.PE_R4 = new DevExpress.XtraEditors.PictureEdit();
            this.PE_R2 = new DevExpress.XtraEditors.PictureEdit();
            this.PE_R1 = new DevExpress.XtraEditors.PictureEdit();
            this.GC_Robot = new DevExpress.XtraEditors.GroupControl();
            this.GC_WorkPlace = new DevExpress.XtraEditors.GroupControl();
            this.GC_WP4 = new DevExpress.XtraEditors.GroupControl();
            this.TB_View4 = new DevExpress.XtraEditors.SimpleButton();
            this.LL_WP4 = new DevExpress.XtraEditors.LabelControl();
            this.GC_WP3 = new DevExpress.XtraEditors.GroupControl();
            this.TB_View3 = new DevExpress.XtraEditors.SimpleButton();
            this.LL_WP3 = new DevExpress.XtraEditors.LabelControl();
            this.GC_WP2 = new DevExpress.XtraEditors.GroupControl();
            this.TB_View2 = new DevExpress.XtraEditors.SimpleButton();
            this.LL_WP2 = new DevExpress.XtraEditors.LabelControl();
            this.LL_WorkplaceCount = new DevExpress.XtraEditors.LabelControl();
            this.SE_WorkPlaceCount = new DevExpress.XtraEditors.SpinEdit();
            this.GC_WP1 = new DevExpress.XtraEditors.GroupControl();
            this.TB_View1 = new DevExpress.XtraEditors.SimpleButton();
            this.LL_WP1 = new DevExpress.XtraEditors.LabelControl();
            this.GC_ProductCfg = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit3 = new DevExpress.XtraEditors.SpinEdit();
            this.LL_Cycle = new DevExpress.XtraEditors.LabelControl();
            this.LL_HomeSpeed = new DevExpress.XtraEditors.LabelControl();
            this.LL_Sp = new DevExpress.XtraEditors.LabelControl();
            this.LL_Triggle = new DevExpress.XtraEditors.LabelControl();
            this.CBE_Triggle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SE_Cycle = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.SE_Pan = new DevExpress.XtraEditors.SpinEdit();
            this.LL_Type = new DevExpress.XtraEditors.LabelControl();
            this.LL_Remark = new DevExpress.XtraEditors.LabelControl();
            this.LL_IP = new DevExpress.XtraEditors.LabelControl();
            this.LL_ID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PE_Center.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Robot)).BeginInit();
            this.GC_Robot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WorkPlace)).BeginInit();
            this.GC_WorkPlace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP4)).BeginInit();
            this.GC_WP4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP3)).BeginInit();
            this.GC_WP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP2)).BeginInit();
            this.GC_WP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SE_WorkPlaceCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP1)).BeginInit();
            this.GC_WP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ProductCfg)).BeginInit();
            this.GC_ProductCfg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Triggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_Cycle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_Pan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PE_Center
            // 
            this.PE_Center.EditValue = global::RobotPolish.Properties.Resources.sys;
            this.PE_Center.Location = new System.Drawing.Point(114, 165);
            this.PE_Center.Name = "PE_Center";
            this.PE_Center.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PE_Center.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.PE_Center.Properties.Appearance.Options.UseBackColor = true;
            this.PE_Center.Properties.Appearance.Options.UseForeColor = true;
            this.PE_Center.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PE_Center.Size = new System.Drawing.Size(284, 153);
            this.PE_Center.TabIndex = 4;
            this.PE_Center.ToolTip = "激光打磨机器人(第七轴)";
            this.PE_Center.Click += new System.EventHandler(this.PE_R1_Click);
            // 
            // PE_R3
            // 
            this.PE_R3.EditValue = global::RobotPolish.Properties.Resources.Robot;
            this.PE_R3.Location = new System.Drawing.Point(345, 266);
            this.PE_R3.Name = "PE_R3";
            this.PE_R3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PE_R3.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.PE_R3.Properties.Appearance.Options.UseBackColor = true;
            this.PE_R3.Properties.Appearance.Options.UseForeColor = true;
            this.PE_R3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PE_R3.Size = new System.Drawing.Size(169, 134);
            this.PE_R3.TabIndex = 2;
            this.PE_R3.ToolTip = "激光打磨机器人3";
            this.PE_R3.Click += new System.EventHandler(this.PE_R1_Click);
            // 
            // PE_R4
            // 
            this.PE_R4.EditValue = global::RobotPolish.Properties.Resources.Robot;
            this.PE_R4.Location = new System.Drawing.Point(22, 324);
            this.PE_R4.Name = "PE_R4";
            this.PE_R4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PE_R4.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.PE_R4.Properties.Appearance.Options.UseBackColor = true;
            this.PE_R4.Properties.Appearance.Options.UseForeColor = true;
            this.PE_R4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PE_R4.Size = new System.Drawing.Size(169, 134);
            this.PE_R4.TabIndex = 3;
            this.PE_R4.ToolTip = "激光打磨机器人4";
            this.PE_R4.Click += new System.EventHandler(this.PE_R1_Click);
            // 
            // PE_R2
            // 
            this.PE_R2.EditValue = global::RobotPolish.Properties.Resources.Robot;
            this.PE_R2.Location = new System.Drawing.Point(291, 25);
            this.PE_R2.Name = "PE_R2";
            this.PE_R2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PE_R2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.PE_R2.Properties.Appearance.Options.UseBackColor = true;
            this.PE_R2.Properties.Appearance.Options.UseForeColor = true;
            this.PE_R2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PE_R2.Size = new System.Drawing.Size(169, 134);
            this.PE_R2.TabIndex = 1;
            this.PE_R2.ToolTip = "激光打磨机器人2";
            this.PE_R2.Click += new System.EventHandler(this.PE_R1_Click);
            // 
            // PE_R1
            // 
            this.PE_R1.EditValue = global::RobotPolish.Properties.Resources.Robot;
            this.PE_R1.Location = new System.Drawing.Point(22, 56);
            this.PE_R1.Name = "PE_R1";
            this.PE_R1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PE_R1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.PE_R1.Properties.Appearance.Options.UseBackColor = true;
            this.PE_R1.Properties.Appearance.Options.UseForeColor = true;
            this.PE_R1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PE_R1.Size = new System.Drawing.Size(169, 134);
            this.PE_R1.TabIndex = 0;
            this.PE_R1.ToolTip = "激光打磨机器人1";
            this.PE_R1.EditValueChanged += new System.EventHandler(this.PE_R1_EditValueChanged);
            this.PE_R1.Click += new System.EventHandler(this.PE_R1_Click);
            // 
            // GC_Robot
            // 
            this.GC_Robot.Controls.Add(this.GC_WorkPlace);
            this.GC_Robot.Controls.Add(this.GC_ProductCfg);
            this.GC_Robot.Controls.Add(this.LL_Type);
            this.GC_Robot.Controls.Add(this.LL_Remark);
            this.GC_Robot.Controls.Add(this.LL_IP);
            this.GC_Robot.Controls.Add(this.LL_ID);
            this.GC_Robot.Location = new System.Drawing.Point(704, 12);
            this.GC_Robot.Name = "GC_Robot";
            this.GC_Robot.Size = new System.Drawing.Size(352, 534);
            this.GC_Robot.TabIndex = 5;
            this.GC_Robot.Text = "机器人信息";
            // 
            // GC_WorkPlace
            // 
            this.GC_WorkPlace.Controls.Add(this.GC_WP4);
            this.GC_WorkPlace.Controls.Add(this.GC_WP3);
            this.GC_WorkPlace.Controls.Add(this.GC_WP2);
            this.GC_WorkPlace.Controls.Add(this.LL_WorkplaceCount);
            this.GC_WorkPlace.Controls.Add(this.SE_WorkPlaceCount);
            this.GC_WorkPlace.Controls.Add(this.GC_WP1);
            this.GC_WorkPlace.Location = new System.Drawing.Point(19, 235);
            this.GC_WorkPlace.Name = "GC_WorkPlace";
            this.GC_WorkPlace.Size = new System.Drawing.Size(316, 290);
            this.GC_WorkPlace.TabIndex = 14;
            this.GC_WorkPlace.Text = "工位信息:";
            // 
            // GC_WP4
            // 
            this.GC_WP4.Controls.Add(this.TB_View4);
            this.GC_WP4.Controls.Add(this.LL_WP4);
            this.GC_WP4.Location = new System.Drawing.Point(10, 228);
            this.GC_WP4.Name = "GC_WP4";
            this.GC_WP4.Size = new System.Drawing.Size(291, 53);
            this.GC_WP4.TabIndex = 16;
            this.GC_WP4.Text = "工位4";
            // 
            // TB_View4
            // 
            this.TB_View4.Location = new System.Drawing.Point(224, 24);
            this.TB_View4.Name = "TB_View4";
            this.TB_View4.Size = new System.Drawing.Size(51, 23);
            this.TB_View4.TabIndex = 4;
            this.TB_View4.Text = "查看";
            // 
            // LL_WP4
            // 
            this.LL_WP4.Location = new System.Drawing.Point(18, 29);
            this.LL_WP4.Name = "LL_WP4";
            this.LL_WP4.Size = new System.Drawing.Size(52, 13);
            this.LL_WP4.TabIndex = 10;
            this.LL_WP4.Text = "产品名称:";
            // 
            // GC_WP3
            // 
            this.GC_WP3.Controls.Add(this.TB_View3);
            this.GC_WP3.Controls.Add(this.LL_WP3);
            this.GC_WP3.Location = new System.Drawing.Point(10, 169);
            this.GC_WP3.Name = "GC_WP3";
            this.GC_WP3.Size = new System.Drawing.Size(291, 53);
            this.GC_WP3.TabIndex = 15;
            this.GC_WP3.Text = "工位3";
            // 
            // TB_View3
            // 
            this.TB_View3.Location = new System.Drawing.Point(224, 24);
            this.TB_View3.Name = "TB_View3";
            this.TB_View3.Size = new System.Drawing.Size(51, 23);
            this.TB_View3.TabIndex = 3;
            this.TB_View3.Text = "查看";
            // 
            // LL_WP3
            // 
            this.LL_WP3.Location = new System.Drawing.Point(18, 29);
            this.LL_WP3.Name = "LL_WP3";
            this.LL_WP3.Size = new System.Drawing.Size(52, 13);
            this.LL_WP3.TabIndex = 10;
            this.LL_WP3.Text = "产品名称:";
            // 
            // GC_WP2
            // 
            this.GC_WP2.Controls.Add(this.TB_View2);
            this.GC_WP2.Controls.Add(this.LL_WP2);
            this.GC_WP2.Location = new System.Drawing.Point(10, 111);
            this.GC_WP2.Name = "GC_WP2";
            this.GC_WP2.Size = new System.Drawing.Size(291, 53);
            this.GC_WP2.TabIndex = 14;
            this.GC_WP2.Text = "工位2";
            // 
            // TB_View2
            // 
            this.TB_View2.Location = new System.Drawing.Point(224, 24);
            this.TB_View2.Name = "TB_View2";
            this.TB_View2.Size = new System.Drawing.Size(51, 23);
            this.TB_View2.TabIndex = 2;
            this.TB_View2.Text = "查看";
            // 
            // LL_WP2
            // 
            this.LL_WP2.Location = new System.Drawing.Point(18, 29);
            this.LL_WP2.Name = "LL_WP2";
            this.LL_WP2.Size = new System.Drawing.Size(52, 13);
            this.LL_WP2.TabIndex = 10;
            this.LL_WP2.Text = "产品名称:";
            // 
            // LL_WorkplaceCount
            // 
            this.LL_WorkplaceCount.Location = new System.Drawing.Point(10, 29);
            this.LL_WorkplaceCount.Name = "LL_WorkplaceCount";
            this.LL_WorkplaceCount.Size = new System.Drawing.Size(64, 13);
            this.LL_WorkplaceCount.TabIndex = 0;
            this.LL_WorkplaceCount.Text = "工位总个数:";
            // 
            // SE_WorkPlaceCount
            // 
            this.SE_WorkPlaceCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SE_WorkPlaceCount.Location = new System.Drawing.Point(89, 25);
            this.SE_WorkPlaceCount.Name = "SE_WorkPlaceCount";
            this.SE_WorkPlaceCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_WorkPlaceCount.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SE_WorkPlaceCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SE_WorkPlaceCount.Size = new System.Drawing.Size(100, 20);
            this.SE_WorkPlaceCount.TabIndex = 1;
            // 
            // GC_WP1
            // 
            this.GC_WP1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GC_WP1.Appearance.Options.UseBackColor = true;
            this.GC_WP1.Controls.Add(this.TB_View1);
            this.GC_WP1.Controls.Add(this.LL_WP1);
            this.GC_WP1.Location = new System.Drawing.Point(10, 52);
            this.GC_WP1.Name = "GC_WP1";
            this.GC_WP1.Size = new System.Drawing.Size(291, 53);
            this.GC_WP1.TabIndex = 13;
            this.GC_WP1.Text = "工位1";
            // 
            // TB_View1
            // 
            this.TB_View1.Location = new System.Drawing.Point(224, 24);
            this.TB_View1.Name = "TB_View1";
            this.TB_View1.Size = new System.Drawing.Size(51, 23);
            this.TB_View1.TabIndex = 1;
            this.TB_View1.Text = "查看";
            this.TB_View1.Click += new System.EventHandler(this.TB_View1_Click);
            // 
            // LL_WP1
            // 
            this.LL_WP1.Location = new System.Drawing.Point(18, 29);
            this.LL_WP1.Name = "LL_WP1";
            this.LL_WP1.Size = new System.Drawing.Size(52, 13);
            this.LL_WP1.TabIndex = 10;
            this.LL_WP1.Text = "产品名称:";
            // 
            // GC_ProductCfg
            // 
            this.GC_ProductCfg.Controls.Add(this.labelControl4);
            this.GC_ProductCfg.Controls.Add(this.spinEdit3);
            this.GC_ProductCfg.Controls.Add(this.LL_Cycle);
            this.GC_ProductCfg.Controls.Add(this.LL_HomeSpeed);
            this.GC_ProductCfg.Controls.Add(this.LL_Sp);
            this.GC_ProductCfg.Controls.Add(this.LL_Triggle);
            this.GC_ProductCfg.Controls.Add(this.CBE_Triggle);
            this.GC_ProductCfg.Controls.Add(this.SE_Cycle);
            this.GC_ProductCfg.Controls.Add(this.spinEdit2);
            this.GC_ProductCfg.Controls.Add(this.SE_Pan);
            this.GC_ProductCfg.Location = new System.Drawing.Point(18, 118);
            this.GC_ProductCfg.Name = "GC_ProductCfg";
            this.GC_ProductCfg.Size = new System.Drawing.Size(316, 110);
            this.GC_ProductCfg.TabIndex = 15;
            this.GC_ProductCfg.Text = "生产配置信息:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(192, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "周期等待:";
            // 
            // spinEdit3
            // 
            this.spinEdit3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit3.Location = new System.Drawing.Point(250, 83);
            this.spinEdit3.Name = "spinEdit3";
            this.spinEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit3.Properties.MaxValue = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.spinEdit3.Size = new System.Drawing.Size(51, 20);
            this.spinEdit3.TabIndex = 10;
            // 
            // LL_Cycle
            // 
            this.LL_Cycle.Location = new System.Drawing.Point(22, 60);
            this.LL_Cycle.Name = "LL_Cycle";
            this.LL_Cycle.Size = new System.Drawing.Size(52, 13);
            this.LL_Cycle.TabIndex = 4;
            this.LL_Cycle.Text = "生产周期:";
            // 
            // LL_HomeSpeed
            // 
            this.LL_HomeSpeed.Location = new System.Drawing.Point(192, 60);
            this.LL_HomeSpeed.Name = "LL_HomeSpeed";
            this.LL_HomeSpeed.Size = new System.Drawing.Size(52, 13);
            this.LL_HomeSpeed.TabIndex = 7;
            this.LL_HomeSpeed.Text = "回零速度:";
            // 
            // LL_Sp
            // 
            this.LL_Sp.Location = new System.Drawing.Point(22, 86);
            this.LL_Sp.Name = "LL_Sp";
            this.LL_Sp.Size = new System.Drawing.Size(52, 13);
            this.LL_Sp.TabIndex = 6;
            this.LL_Sp.Text = "光斑补偿:";
            // 
            // LL_Triggle
            // 
            this.LL_Triggle.Location = new System.Drawing.Point(22, 34);
            this.LL_Triggle.Name = "LL_Triggle";
            this.LL_Triggle.Size = new System.Drawing.Size(52, 13);
            this.LL_Triggle.TabIndex = 2;
            this.LL_Triggle.Text = "触发方式:";
            // 
            // CBE_Triggle
            // 
            this.CBE_Triggle.Location = new System.Drawing.Point(89, 31);
            this.CBE_Triggle.Name = "CBE_Triggle";
            this.CBE_Triggle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_Triggle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_Triggle.Size = new System.Drawing.Size(212, 20);
            this.CBE_Triggle.TabIndex = 3;
            // 
            // SE_Cycle
            // 
            this.SE_Cycle.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SE_Cycle.Location = new System.Drawing.Point(89, 57);
            this.SE_Cycle.Name = "SE_Cycle";
            this.SE_Cycle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_Cycle.Properties.MaxValue = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.SE_Cycle.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SE_Cycle.Size = new System.Drawing.Size(84, 20);
            this.SE_Cycle.TabIndex = 5;
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(250, 57);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinEdit2.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEdit2.Size = new System.Drawing.Size(51, 20);
            this.spinEdit2.TabIndex = 9;
            // 
            // SE_Pan
            // 
            this.SE_Pan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SE_Pan.Location = new System.Drawing.Point(89, 83);
            this.SE_Pan.Name = "SE_Pan";
            this.SE_Pan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SE_Pan.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SE_Pan.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SE_Pan.Size = new System.Drawing.Size(84, 20);
            this.SE_Pan.TabIndex = 8;
            // 
            // LL_Type
            // 
            this.LL_Type.Location = new System.Drawing.Point(193, 89);
            this.LL_Type.Name = "LL_Type";
            this.LL_Type.Size = new System.Drawing.Size(64, 13);
            this.LL_Type.TabIndex = 3;
            this.LL_Type.Text = "机器人类型:";
            // 
            // LL_Remark
            // 
            this.LL_Remark.Location = new System.Drawing.Point(27, 56);
            this.LL_Remark.Name = "LL_Remark";
            this.LL_Remark.Size = new System.Drawing.Size(28, 13);
            this.LL_Remark.TabIndex = 2;
            this.LL_Remark.Text = "备注:";
            // 
            // LL_IP
            // 
            this.LL_IP.Location = new System.Drawing.Point(27, 89);
            this.LL_IP.Name = "LL_IP";
            this.LL_IP.Size = new System.Drawing.Size(14, 13);
            this.LL_IP.TabIndex = 1;
            this.LL_IP.Text = "IP:";
            // 
            // LL_ID
            // 
            this.LL_ID.Location = new System.Drawing.Point(27, 27);
            this.LL_ID.Name = "LL_ID";
            this.LL_ID.Size = new System.Drawing.Size(64, 13);
            this.LL_ID.TabIndex = 0;
            this.LL_ID.Text = "机器人序号:";
            // 
            // Frm_Sys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 547);
            this.Controls.Add(this.GC_Robot);
            this.Controls.Add(this.PE_R3);
            this.Controls.Add(this.PE_R4);
            this.Controls.Add(this.PE_R2);
            this.Controls.Add(this.PE_R1);
            this.Controls.Add(this.PE_Center);
            this.Name = "Frm_Sys";
            this.Text = "Frm_Sys";
            this.Load += new System.EventHandler(this.Frm_Sys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PE_Center.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PE_R1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Robot)).EndInit();
            this.GC_Robot.ResumeLayout(false);
            this.GC_Robot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WorkPlace)).EndInit();
            this.GC_WorkPlace.ResumeLayout(false);
            this.GC_WorkPlace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP4)).EndInit();
            this.GC_WP4.ResumeLayout(false);
            this.GC_WP4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP3)).EndInit();
            this.GC_WP3.ResumeLayout(false);
            this.GC_WP3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP2)).EndInit();
            this.GC_WP2.ResumeLayout(false);
            this.GC_WP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SE_WorkPlaceCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_WP1)).EndInit();
            this.GC_WP1.ResumeLayout(false);
            this.GC_WP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ProductCfg)).EndInit();
            this.GC_ProductCfg.ResumeLayout(false);
            this.GC_ProductCfg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Triggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_Cycle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE_Pan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PE_R1;
        private DevExpress.XtraEditors.PictureEdit PE_R2;
        private DevExpress.XtraEditors.PictureEdit PE_R4;
        private DevExpress.XtraEditors.PictureEdit PE_R3;
        private DevExpress.XtraEditors.PictureEdit PE_Center;
        private DevExpress.XtraEditors.GroupControl GC_Robot;
        private DevExpress.XtraEditors.LabelControl LL_Remark;
        private DevExpress.XtraEditors.LabelControl LL_IP;
        private DevExpress.XtraEditors.LabelControl LL_ID;
        private DevExpress.XtraEditors.LabelControl LL_Type;
        private DevExpress.XtraEditors.GroupControl GC_WorkPlace;
        private DevExpress.XtraEditors.GroupControl GC_WP4;
        private DevExpress.XtraEditors.SimpleButton TB_View4;
        private DevExpress.XtraEditors.LabelControl LL_WP4;
        private DevExpress.XtraEditors.GroupControl GC_WP3;
        private DevExpress.XtraEditors.SimpleButton TB_View3;
        private DevExpress.XtraEditors.LabelControl LL_WP3;
        private DevExpress.XtraEditors.GroupControl GC_WP2;
        private DevExpress.XtraEditors.SimpleButton TB_View2;
        private DevExpress.XtraEditors.LabelControl LL_WP2;
        private DevExpress.XtraEditors.LabelControl LL_WorkplaceCount;
        private DevExpress.XtraEditors.SpinEdit SE_WorkPlaceCount;
        private DevExpress.XtraEditors.GroupControl GC_WP1;
        private DevExpress.XtraEditors.SimpleButton TB_View1;
        private DevExpress.XtraEditors.LabelControl LL_WP1;
        private DevExpress.XtraEditors.GroupControl GC_ProductCfg;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinEdit3;
        private DevExpress.XtraEditors.LabelControl LL_Cycle;
        private DevExpress.XtraEditors.LabelControl LL_HomeSpeed;
        private DevExpress.XtraEditors.LabelControl LL_Sp;
        private DevExpress.XtraEditors.LabelControl LL_Triggle;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_Triggle;
        private DevExpress.XtraEditors.SpinEdit SE_Cycle;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SpinEdit SE_Pan;
    }
}