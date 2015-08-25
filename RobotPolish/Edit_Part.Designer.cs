namespace RobotPolish
{
    partial class Edit_Part
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
            this.BT_ok = new DevExpress.XtraEditors.SimpleButton();
            this.BT_Cancle = new DevExpress.XtraEditors.SimpleButton();
            this.CBE_Type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LL_Type = new DevExpress.XtraEditors.LabelControl();
            this.LL_RecipeName = new DevExpress.XtraEditors.LabelControl();
            this.TE_Remark = new DevExpress.XtraEditors.TextEdit();
            this.GC_Traj = new DevExpress.XtraEditors.GroupControl();
            this.TE_RecipeName = new DevExpress.XtraEditors.TextEdit();
            this.LL_Remark = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.TE_File = new DevExpress.XtraEditors.TextEdit();
            this.BT_File = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).BeginInit();
            this.GC_Traj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TE_RecipeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_File.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ok
            // 
            this.BT_ok.Location = new System.Drawing.Point(59, 182);
            this.BT_ok.Name = "BT_ok";
            this.BT_ok.Size = new System.Drawing.Size(57, 23);
            this.BT_ok.TabIndex = 7;
            this.BT_ok.Text = "确定";
            this.BT_ok.Click += new System.EventHandler(this.BT_ok_Click);
            // 
            // BT_Cancle
            // 
            this.BT_Cancle.Location = new System.Drawing.Point(206, 182);
            this.BT_Cancle.Name = "BT_Cancle";
            this.BT_Cancle.Size = new System.Drawing.Size(57, 23);
            this.BT_Cancle.TabIndex = 10;
            this.BT_Cancle.Text = "取消";
            this.BT_Cancle.Click += new System.EventHandler(this.BT_Cancle_Click);
            // 
            // CBE_Type
            // 
            this.CBE_Type.Location = new System.Drawing.Point(238, 29);
            this.CBE_Type.Name = "CBE_Type";
            this.CBE_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_Type.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBE_Type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_Type.Size = new System.Drawing.Size(66, 20);
            this.CBE_Type.TabIndex = 12;
            this.CBE_Type.Visible = false;
            // 
            // LL_Type
            // 
            this.LL_Type.Location = new System.Drawing.Point(177, 32);
            this.LL_Type.Name = "LL_Type";
            this.LL_Type.Size = new System.Drawing.Size(40, 13);
            this.LL_Type.TabIndex = 14;
            this.LL_Type.Text = "工位号:";
            this.LL_Type.Visible = false;
            // 
            // LL_RecipeName
            // 
            this.LL_RecipeName.Location = new System.Drawing.Point(10, 31);
            this.LL_RecipeName.Name = "LL_RecipeName";
            this.LL_RecipeName.Size = new System.Drawing.Size(52, 13);
            this.LL_RecipeName.TabIndex = 11;
            this.LL_RecipeName.Text = "产品名称:";
            // 
            // TE_Remark
            // 
            this.TE_Remark.Location = new System.Drawing.Point(78, 56);
            this.TE_Remark.Name = "TE_Remark";
            this.TE_Remark.Size = new System.Drawing.Size(226, 20);
            this.TE_Remark.TabIndex = 23;
            // 
            // GC_Traj
            // 
            this.GC_Traj.Controls.Add(this.TE_RecipeName);
            this.GC_Traj.Controls.Add(this.LL_Remark);
            this.GC_Traj.Controls.Add(this.TE_Remark);
            this.GC_Traj.Controls.Add(this.LL_RecipeName);
            this.GC_Traj.Controls.Add(this.LL_Type);
            this.GC_Traj.Controls.Add(this.CBE_Type);
            this.GC_Traj.Location = new System.Drawing.Point(1, 9);
            this.GC_Traj.Name = "GC_Traj";
            this.GC_Traj.Size = new System.Drawing.Size(313, 88);
            this.GC_Traj.TabIndex = 24;
            this.GC_Traj.Text = "产品信息:";
            // 
            // TE_RecipeName
            // 
            this.TE_RecipeName.Location = new System.Drawing.Point(78, 30);
            this.TE_RecipeName.Name = "TE_RecipeName";
            this.TE_RecipeName.Size = new System.Drawing.Size(93, 20);
            this.TE_RecipeName.TabIndex = 25;
            // 
            // LL_Remark
            // 
            this.LL_Remark.Location = new System.Drawing.Point(11, 62);
            this.LL_Remark.Name = "LL_Remark";
            this.LL_Remark.Size = new System.Drawing.Size(28, 13);
            this.LL_Remark.TabIndex = 24;
            this.LL_Remark.Text = "备注:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "局部路径的Matlab程序文本";
            // 
            // TE_File
            // 
            this.TE_File.Location = new System.Drawing.Point(11, 142);
            this.TE_File.Name = "TE_File";
            this.TE_File.Size = new System.Drawing.Size(303, 20);
            this.TE_File.TabIndex = 26;
            // 
            // BT_File
            // 
            this.BT_File.Location = new System.Drawing.Point(164, 111);
            this.BT_File.Name = "BT_File";
            this.BT_File.Size = new System.Drawing.Size(75, 23);
            this.BT_File.TabIndex = 27;
            this.BT_File.Text = "选择";
            this.BT_File.UseVisualStyleBackColor = true;
            this.BT_File.Click += new System.EventHandler(this.BT_File_Click);
            // 
            // Edit_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 226);
            this.ControlBox = false;
            this.Controls.Add(this.BT_File);
            this.Controls.Add(this.TE_File);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Cancle);
            this.Controls.Add(this.BT_ok);
            this.Controls.Add(this.GC_Traj);
            this.Name = "Edit_Part";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑产品";
            ((System.ComponentModel.ISupportInitialize)(this.CBE_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Traj)).EndInit();
            this.GC_Traj.ResumeLayout(false);
            this.GC_Traj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TE_RecipeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TE_File.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_ok;
        private DevExpress.XtraEditors.SimpleButton BT_Cancle;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_Type;
        private DevExpress.XtraEditors.LabelControl LL_Type;
        private DevExpress.XtraEditors.LabelControl LL_RecipeName;
        private DevExpress.XtraEditors.TextEdit TE_Remark;
        private DevExpress.XtraEditors.GroupControl GC_Traj;
        private DevExpress.XtraEditors.LabelControl LL_Remark;
        private DevExpress.XtraEditors.TextEdit TE_RecipeName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TE_File;
        private System.Windows.Forms.Button BT_File;
    }
}