namespace RobotPolish
{
    partial class Frm_Recipe
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
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Traj = new DevExpress.XtraGrid.GridControl();
            this.GV_Appro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Appro = new DevExpress.XtraGrid.GridControl();
            this.GC_Cut = new DevExpress.XtraGrid.GridControl();
            this.GV_Cut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GC_Leave = new DevExpress.XtraGrid.GridControl();
            this.GV_Leave = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Gp_TrajInfor = new DevExpress.XtraEditors.GroupControl();
            this.LL_TrajRemark = new DevExpress.XtraEditors.LabelControl();
            this.LL_PointCount = new DevExpress.XtraEditors.LabelControl();
            this.GC_Recipe = new DevExpress.XtraEditors.GroupControl();
            this.LL_RecipeRemark = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeOffset = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeFrame = new DevExpress.XtraEditors.LabelControl();
            this.LL_TrajCount = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeName = new DevExpress.XtraEditors.LabelControl();
            this.CBE_RecipeName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GC_RecipeOper = new DevExpress.XtraEditors.GroupControl();
            this.BT_ReicpeFrame = new DevExpress.XtraEditors.SimpleButton();
            this.BT_RecipeEdit = new DevExpress.XtraEditors.SimpleButton();
            this.BT_OutPut = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Import = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.BT_New = new DevExpress.XtraEditors.SimpleButton();
            this.GC_TrajOper = new DevExpress.XtraEditors.GroupControl();
            this.BT_DeleteTraj = new DevExpress.XtraEditors.SimpleButton();
            this.BT_MatLab = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.BT_TrajDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Speed = new DevExpress.XtraEditors.SimpleButton();
            this.SCC = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.NUD_Speed = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.NUD_Rot = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.NUD_Rel = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.NUD_Press = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ND_Z = new System.Windows.Forms.NumericUpDown();
            this.BT_Download = new DevExpress.XtraEditors.SimpleButton();
            this.BT_PowerOn = new DevExpress.XtraEditors.SimpleButton();
            this.CBE_Custom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Appro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Appro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Leave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Leave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gp_TrajInfor)).BeginInit();
            this.Gp_TrajInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Recipe)).BeginInit();
            this.GC_Recipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_RecipeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_RecipeOper)).BeginInit();
            this.GC_RecipeOper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_TrajOper)).BeginInit();
            this.GC_TrajOper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).BeginInit();
            this.SCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ND_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Custom.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.gv.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_FocusedRowChanged);
            // 
            // GC_Traj
            // 
            this.GC_Traj.Dock = System.Windows.Forms.DockStyle.Left;
            this.GC_Traj.Location = new System.Drawing.Point(0, 0);
            this.GC_Traj.MainView = this.gv;
            this.GC_Traj.Name = "GC_Traj";
            this.GC_Traj.Size = new System.Drawing.Size(268, 589);
            this.GC_Traj.TabIndex = 2;
            this.GC_Traj.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // GV_Appro
            // 
            this.GV_Appro.ActiveFilterEnabled = false;
            this.GV_Appro.GridControl = this.GC_Appro;
            this.GV_Appro.Name = "GV_Appro";
            this.GV_Appro.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Appro.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Appro.OptionsBehavior.AutoSelectAllInEditor = false;
            this.GV_Appro.OptionsBehavior.Editable = false;
            this.GV_Appro.OptionsCustomization.AllowColumnMoving = false;
            this.GV_Appro.OptionsCustomization.AllowFilter = false;
            this.GV_Appro.OptionsCustomization.AllowGroup = false;
            this.GV_Appro.OptionsCustomization.AllowSort = false;
            this.GV_Appro.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GV_Appro.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Appro.OptionsView.ShowGroupPanel = false;
            this.GV_Appro.SynchronizeClones = false;
            // 
            // GC_Appro
            // 
            this.GC_Appro.Location = new System.Drawing.Point(277, 64);
            this.GC_Appro.MainView = this.GV_Appro;
            this.GC_Appro.Name = "GC_Appro";
            this.GC_Appro.Size = new System.Drawing.Size(563, 121);
            this.GC_Appro.TabIndex = 3;
            this.GC_Appro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Appro});
            // 
            // GC_Cut
            // 
            this.GC_Cut.Location = new System.Drawing.Point(277, 191);
            this.GC_Cut.MainView = this.GV_Cut;
            this.GC_Cut.Name = "GC_Cut";
            this.GC_Cut.Size = new System.Drawing.Size(563, 288);
            this.GC_Cut.TabIndex = 4;
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
            // 
            // GC_Leave
            // 
            this.GC_Leave.Location = new System.Drawing.Point(277, 489);
            this.GC_Leave.MainView = this.GV_Leave;
            this.GC_Leave.Name = "GC_Leave";
            this.GC_Leave.Size = new System.Drawing.Size(563, 98);
            this.GC_Leave.TabIndex = 5;
            this.GC_Leave.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Leave});
            // 
            // GV_Leave
            // 
            this.GV_Leave.ActiveFilterEnabled = false;
            this.GV_Leave.GridControl = this.GC_Leave;
            this.GV_Leave.Name = "GV_Leave";
            this.GV_Leave.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Leave.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Leave.OptionsBehavior.AutoSelectAllInEditor = false;
            this.GV_Leave.OptionsBehavior.Editable = false;
            this.GV_Leave.OptionsCustomization.AllowColumnMoving = false;
            this.GV_Leave.OptionsCustomization.AllowFilter = false;
            this.GV_Leave.OptionsCustomization.AllowGroup = false;
            this.GV_Leave.OptionsCustomization.AllowSort = false;
            this.GV_Leave.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GV_Leave.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Leave.OptionsView.ShowGroupPanel = false;
            this.GV_Leave.SynchronizeClones = false;
            // 
            // Gp_TrajInfor
            // 
            this.Gp_TrajInfor.Controls.Add(this.LL_TrajRemark);
            this.Gp_TrajInfor.Controls.Add(this.LL_PointCount);
            this.Gp_TrajInfor.Location = new System.Drawing.Point(276, 3);
            this.Gp_TrajInfor.Name = "Gp_TrajInfor";
            this.Gp_TrajInfor.Size = new System.Drawing.Size(563, 53);
            this.Gp_TrajInfor.TabIndex = 6;
            this.Gp_TrajInfor.Text = "路径信息";
            // 
            // LL_TrajRemark
            // 
            this.LL_TrajRemark.Location = new System.Drawing.Point(317, 30);
            this.LL_TrajRemark.Name = "LL_TrajRemark";
            this.LL_TrajRemark.Size = new System.Drawing.Size(52, 13);
            this.LL_TrajRemark.TabIndex = 11;
            this.LL_TrajRemark.Text = "路径说明:";
            // 
            // LL_PointCount
            // 
            this.LL_PointCount.Location = new System.Drawing.Point(15, 30);
            this.LL_PointCount.Name = "LL_PointCount";
            this.LL_PointCount.Size = new System.Drawing.Size(40, 13);
            this.LL_PointCount.TabIndex = 10;
            this.LL_PointCount.Text = "点个数:";
            // 
            // GC_Recipe
            // 
            this.GC_Recipe.Controls.Add(this.LL_RecipeRemark);
            this.GC_Recipe.Controls.Add(this.LL_RecipeOffset);
            this.GC_Recipe.Controls.Add(this.LL_RecipeFrame);
            this.GC_Recipe.Controls.Add(this.LL_TrajCount);
            this.GC_Recipe.Controls.Add(this.LL_RecipeName);
            this.GC_Recipe.Controls.Add(this.CBE_RecipeName);
            this.GC_Recipe.Location = new System.Drawing.Point(0, 12);
            this.GC_Recipe.Name = "GC_Recipe";
            this.GC_Recipe.Size = new System.Drawing.Size(222, 107);
            this.GC_Recipe.TabIndex = 7;
            this.GC_Recipe.Text = "产品信息";
            // 
            // LL_RecipeRemark
            // 
            this.LL_RecipeRemark.Location = new System.Drawing.Point(10, 88);
            this.LL_RecipeRemark.Name = "LL_RecipeRemark";
            this.LL_RecipeRemark.Size = new System.Drawing.Size(28, 13);
            this.LL_RecipeRemark.TabIndex = 5;
            this.LL_RecipeRemark.Text = "说明:";
            // 
            // LL_RecipeOffset
            // 
            this.LL_RecipeOffset.Location = new System.Drawing.Point(10, 68);
            this.LL_RecipeOffset.Name = "LL_RecipeOffset";
            this.LL_RecipeOffset.Size = new System.Drawing.Size(40, 13);
            this.LL_RecipeOffset.TabIndex = 4;
            this.LL_RecipeOffset.Text = "工具值:";
            // 
            // LL_RecipeFrame
            // 
            this.LL_RecipeFrame.Location = new System.Drawing.Point(10, 48);
            this.LL_RecipeFrame.Name = "LL_RecipeFrame";
            this.LL_RecipeFrame.Size = new System.Drawing.Size(64, 13);
            this.LL_RecipeFrame.TabIndex = 3;
            this.LL_RecipeFrame.Text = "产品坐标系:";
            // 
            // LL_TrajCount
            // 
            this.LL_TrajCount.Location = new System.Drawing.Point(84, 3);
            this.LL_TrajCount.Name = "LL_TrajCount";
            this.LL_TrajCount.Size = new System.Drawing.Size(64, 13);
            this.LL_TrajCount.TabIndex = 2;
            this.LL_TrajCount.Text = "路径总个数:";
            this.LL_TrajCount.Visible = false;
            // 
            // LL_RecipeName
            // 
            this.LL_RecipeName.Location = new System.Drawing.Point(10, 28);
            this.LL_RecipeName.Name = "LL_RecipeName";
            this.LL_RecipeName.Size = new System.Drawing.Size(52, 13);
            this.LL_RecipeName.TabIndex = 1;
            this.LL_RecipeName.Text = "产品名称:";
            // 
            // CBE_RecipeName
            // 
            this.CBE_RecipeName.EditValue = "";
            this.CBE_RecipeName.Location = new System.Drawing.Point(73, 24);
            this.CBE_RecipeName.Name = "CBE_RecipeName";
            this.CBE_RecipeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_RecipeName.Properties.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CBE_RecipeName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_RecipeName.Size = new System.Drawing.Size(130, 20);
            this.CBE_RecipeName.TabIndex = 0;
            this.CBE_RecipeName.TextChanged += new System.EventHandler(this.CBE_RecipeName_TextChanged);
            // 
            // GC_RecipeOper
            // 
            this.GC_RecipeOper.Controls.Add(this.BT_ReicpeFrame);
            this.GC_RecipeOper.Controls.Add(this.BT_RecipeEdit);
            this.GC_RecipeOper.Controls.Add(this.BT_OutPut);
            this.GC_RecipeOper.Controls.Add(this.BT_Import);
            this.GC_RecipeOper.Controls.Add(this.BT_Delete);
            this.GC_RecipeOper.Controls.Add(this.BT_New);
            this.GC_RecipeOper.Location = new System.Drawing.Point(0, 122);
            this.GC_RecipeOper.Name = "GC_RecipeOper";
            this.GC_RecipeOper.Size = new System.Drawing.Size(222, 109);
            this.GC_RecipeOper.TabIndex = 8;
            this.GC_RecipeOper.Text = "产品编辑";
            // 
            // BT_ReicpeFrame
            // 
            this.BT_ReicpeFrame.Location = new System.Drawing.Point(18, 52);
            this.BT_ReicpeFrame.Name = "BT_ReicpeFrame";
            this.BT_ReicpeFrame.Size = new System.Drawing.Size(75, 23);
            this.BT_ReicpeFrame.TabIndex = 6;
            this.BT_ReicpeFrame.Text = "坐标系";
            this.BT_ReicpeFrame.Click += new System.EventHandler(this.BT_ReicpeFrame_Click);
            // 
            // BT_RecipeEdit
            // 
            this.BT_RecipeEdit.Location = new System.Drawing.Point(111, 52);
            this.BT_RecipeEdit.Name = "BT_RecipeEdit";
            this.BT_RecipeEdit.Size = new System.Drawing.Size(75, 23);
            this.BT_RecipeEdit.TabIndex = 4;
            this.BT_RecipeEdit.Text = "编辑";
            this.BT_RecipeEdit.Click += new System.EventHandler(this.BT_RecipeEdit_Click);
            // 
            // BT_OutPut
            // 
            this.BT_OutPut.Location = new System.Drawing.Point(111, 80);
            this.BT_OutPut.Name = "BT_OutPut";
            this.BT_OutPut.Size = new System.Drawing.Size(75, 23);
            this.BT_OutPut.TabIndex = 3;
            this.BT_OutPut.Text = "导出";
            this.BT_OutPut.Click += new System.EventHandler(this.BT_OutPut_Click);
            // 
            // BT_Import
            // 
            this.BT_Import.Location = new System.Drawing.Point(18, 80);
            this.BT_Import.Name = "BT_Import";
            this.BT_Import.Size = new System.Drawing.Size(75, 23);
            this.BT_Import.TabIndex = 2;
            this.BT_Import.Text = "导入";
            this.BT_Import.Click += new System.EventHandler(this.BT_Import_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(111, 24);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 1;
            this.BT_Delete.Text = "删除";
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_New
            // 
            this.BT_New.Location = new System.Drawing.Point(18, 24);
            this.BT_New.Name = "BT_New";
            this.BT_New.Size = new System.Drawing.Size(75, 23);
            this.BT_New.TabIndex = 0;
            this.BT_New.Text = "新建";
            this.BT_New.Click += new System.EventHandler(this.BT_New_Click);
            // 
            // GC_TrajOper
            // 
            this.GC_TrajOper.Controls.Add(this.BT_DeleteTraj);
            this.GC_TrajOper.Controls.Add(this.BT_MatLab);
            this.GC_TrajOper.Controls.Add(this.BT_Edit);
            this.GC_TrajOper.Controls.Add(this.BT_TrajDelete);
            this.GC_TrajOper.Controls.Add(this.BT_Speed);
            this.GC_TrajOper.Location = new System.Drawing.Point(0, 237);
            this.GC_TrajOper.Name = "GC_TrajOper";
            this.GC_TrajOper.Size = new System.Drawing.Size(222, 113);
            this.GC_TrajOper.TabIndex = 9;
            this.GC_TrajOper.Text = "路径编辑";
            // 
            // BT_DeleteTraj
            // 
            this.BT_DeleteTraj.Location = new System.Drawing.Point(18, 81);
            this.BT_DeleteTraj.Name = "BT_DeleteTraj";
            this.BT_DeleteTraj.Size = new System.Drawing.Size(75, 23);
            this.BT_DeleteTraj.TabIndex = 5;
            this.BT_DeleteTraj.Text = "删除";
            this.BT_DeleteTraj.Click += new System.EventHandler(this.BT_DeleteTraj_Click);
            // 
            // BT_MatLab
            // 
            this.BT_MatLab.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BT_MatLab.Appearance.Options.UseForeColor = true;
            this.BT_MatLab.Location = new System.Drawing.Point(111, 52);
            this.BT_MatLab.Name = "BT_MatLab";
            this.BT_MatLab.Size = new System.Drawing.Size(75, 23);
            this.BT_MatLab.TabIndex = 4;
            this.BT_MatLab.Text = "Matlab速度";
            this.BT_MatLab.Click += new System.EventHandler(this.BT_MatLab_Click);
            // 
            // BT_Edit
            // 
            this.BT_Edit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BT_Edit.Appearance.Options.UseForeColor = true;
            this.BT_Edit.Location = new System.Drawing.Point(110, 24);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Edit.TabIndex = 3;
            this.BT_Edit.Text = "打磨点参数";
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_TrajDelete
            // 
            this.BT_TrajDelete.Location = new System.Drawing.Point(18, 24);
            this.BT_TrajDelete.Name = "BT_TrajDelete";
            this.BT_TrajDelete.Size = new System.Drawing.Size(75, 23);
            this.BT_TrajDelete.TabIndex = 2;
            this.BT_TrajDelete.Text = "局部路径";
            this.BT_TrajDelete.Click += new System.EventHandler(this.BT_TrajPart_Click);
            // 
            // BT_Speed
            // 
            this.BT_Speed.Location = new System.Drawing.Point(18, 52);
            this.BT_Speed.Name = "BT_Speed";
            this.BT_Speed.Size = new System.Drawing.Size(75, 23);
            this.BT_Speed.TabIndex = 1;
            this.BT_Speed.Text = "路径批处理";
            this.BT_Speed.Click += new System.EventHandler(this.BT_Speed_Click);
            // 
            // SCC
            // 
            this.SCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCC.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.SCC.Location = new System.Drawing.Point(0, 0);
            this.SCC.Name = "SCC";
            this.SCC.Panel1.Controls.Add(this.Gp_TrajInfor);
            this.SCC.Panel1.Controls.Add(this.GC_Appro);
            this.SCC.Panel1.Controls.Add(this.GC_Leave);
            this.SCC.Panel1.Controls.Add(this.GC_Traj);
            this.SCC.Panel1.Controls.Add(this.GC_Cut);
            this.SCC.Panel1.Text = "Panel1";
            this.SCC.Panel2.Controls.Add(this.groupControl1);
            this.SCC.Panel2.Controls.Add(this.GC_Recipe);
            this.SCC.Panel2.Controls.Add(this.GC_RecipeOper);
            this.SCC.Panel2.Controls.Add(this.GC_TrajOper);
            this.SCC.Panel2.Text = "Panel2";
            this.SCC.Size = new System.Drawing.Size(1097, 589);
            this.SCC.SplitterPosition = 246;
            this.SCC.TabIndex = 10;
            this.SCC.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.NUD_Speed);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.NUD_Rot);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.NUD_Rel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.NUD_Press);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.ND_Z);
            this.groupControl1.Controls.Add(this.BT_Download);
            this.groupControl1.Controls.Add(this.BT_PowerOn);
            this.groupControl1.Controls.Add(this.CBE_Custom);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 354);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(222, 223);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "生产配置";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 159);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "转台速度";
            // 
            // NUD_Speed
            // 
            this.NUD_Speed.Location = new System.Drawing.Point(136, 155);
            this.NUD_Speed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUD_Speed.Name = "NUD_Speed";
            this.NUD_Speed.Size = new System.Drawing.Size(76, 21);
            this.NUD_Speed.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "自转速度";
            // 
            // NUD_Rot
            // 
            this.NUD_Rot.Location = new System.Drawing.Point(136, 128);
            this.NUD_Rot.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUD_Rot.Name = "NUD_Rot";
            this.NUD_Rot.Size = new System.Drawing.Size(76, 21);
            this.NUD_Rot.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "公转速度";
            // 
            // NUD_Rel
            // 
            this.NUD_Rel.Location = new System.Drawing.Point(135, 103);
            this.NUD_Rel.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUD_Rel.Name = "NUD_Rel";
            this.NUD_Rel.Size = new System.Drawing.Size(76, 21);
            this.NUD_Rel.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "打磨压力";
            // 
            // NUD_Press
            // 
            this.NUD_Press.Location = new System.Drawing.Point(135, 76);
            this.NUD_Press.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUD_Press.Name = "NUD_Press";
            this.NUD_Press.Size = new System.Drawing.Size(76, 21);
            this.NUD_Press.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "MoveJ上抬距离(毫米）";
            // 
            // ND_Z
            // 
            this.ND_Z.Location = new System.Drawing.Point(135, 49);
            this.ND_Z.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ND_Z.Name = "ND_Z";
            this.ND_Z.Size = new System.Drawing.Size(76, 21);
            this.ND_Z.TabIndex = 23;
            // 
            // BT_Download
            // 
            this.BT_Download.Location = new System.Drawing.Point(127, 186);
            this.BT_Download.Name = "BT_Download";
            this.BT_Download.Size = new System.Drawing.Size(75, 23);
            this.BT_Download.TabIndex = 22;
            this.BT_Download.Text = "下载";
            this.BT_Download.Click += new System.EventHandler(this.BT_Download_Click);
            // 
            // BT_PowerOn
            // 
            this.BT_PowerOn.Location = new System.Drawing.Point(18, 186);
            this.BT_PowerOn.Name = "BT_PowerOn";
            this.BT_PowerOn.Size = new System.Drawing.Size(75, 23);
            this.BT_PowerOn.TabIndex = 21;
            this.BT_PowerOn.Text = "上电";
            this.BT_PowerOn.Click += new System.EventHandler(this.BT_PowerOn_Click);
            // 
            // CBE_Custom
            // 
            this.CBE_Custom.Location = new System.Drawing.Point(67, 24);
            this.CBE_Custom.Name = "CBE_Custom";
            this.CBE_Custom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_Custom.Size = new System.Drawing.Size(141, 20);
            this.CBE_Custom.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "客户:";
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Interval = 50;
            // 
            // Frm_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 589);
            this.Controls.Add(this.SCC);
            this.Name = "Frm_Recipe";
            this.Text = "Frm_Recipe";
            this.Load += new System.EventHandler(this.Frm_Recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Appro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Appro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Leave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Leave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gp_TrajInfor)).EndInit();
            this.Gp_TrajInfor.ResumeLayout(false);
            this.Gp_TrajInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Recipe)).EndInit();
            this.GC_Recipe.ResumeLayout(false);
            this.GC_Recipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_RecipeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_RecipeOper)).EndInit();
            this.GC_RecipeOper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_TrajOper)).EndInit();
            this.GC_TrajOper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).EndInit();
            this.SCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Rel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ND_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Custom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl GC_Traj;
        protected DevExpress.XtraGrid.GridControl GC_Appro;
        protected DevExpress.XtraGrid.GridControl GC_Cut;
        protected DevExpress.XtraGrid.GridControl GC_Leave;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Cut;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Leave;
        private DevExpress.XtraEditors.GroupControl Gp_TrajInfor;
        private DevExpress.XtraEditors.GroupControl GC_Recipe;
        private DevExpress.XtraEditors.GroupControl GC_RecipeOper;
        private DevExpress.XtraEditors.GroupControl GC_TrajOper;
        private DevExpress.XtraEditors.LabelControl LL_RecipeName;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_RecipeName;
        private DevExpress.XtraEditors.LabelControl LL_RecipeFrame;
        private DevExpress.XtraEditors.LabelControl LL_TrajCount;
        private DevExpress.XtraEditors.LabelControl LL_RecipeRemark;
        private DevExpress.XtraEditors.LabelControl LL_RecipeOffset;
        private DevExpress.XtraEditors.LabelControl LL_PointCount;
        private DevExpress.XtraEditors.SimpleButton BT_RecipeEdit;
        private DevExpress.XtraEditors.SimpleButton BT_OutPut;
        private DevExpress.XtraEditors.SimpleButton BT_Import;
        private DevExpress.XtraEditors.SimpleButton BT_Delete;
        private DevExpress.XtraEditors.SimpleButton BT_New;
        private DevExpress.XtraEditors.SimpleButton BT_ReicpeFrame;
        private DevExpress.XtraEditors.SimpleButton BT_TrajDelete;
        private DevExpress.XtraEditors.SimpleButton BT_Speed;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Appro;
        private DevExpress.XtraEditors.LabelControl LL_TrajRemark;
        private DevExpress.XtraEditors.SplitContainerControl SCC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_Custom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BT_Edit;
        private DevExpress.XtraEditors.SimpleButton BT_Download;
        private DevExpress.XtraEditors.SimpleButton BT_PowerOn;
        private DevExpress.XtraEditors.SimpleButton BT_MatLab;
        private System.Windows.Forms.Timer timer_Refresh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown ND_Z;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown NUD_Speed;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown NUD_Rot;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown NUD_Rel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.NumericUpDown NUD_Press;
        private DevExpress.XtraEditors.SimpleButton BT_DeleteTraj;



    }
}