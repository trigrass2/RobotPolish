namespace RobotPolish
{
    partial class Frm_Preset
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
            this.BT_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.CBE_PresetName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LL_ReMark = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).BeginInit();
            this.gc_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).BeginInit();
            this.SCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBE_PresetName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_control
            // 
            this.gc_control.Controls.Add(this.labelControl1);
            this.gc_control.Controls.Add(this.BT_Delete);
            this.gc_control.Controls.Add(this.CBE_PresetName);
            this.gc_control.Controls.Add(this.LL_ReMark);
            this.gc_control.Size = new System.Drawing.Size(937, 58);
            this.gc_control.Controls.SetChildIndex(this.LL_ReMark, 0);
            this.gc_control.Controls.SetChildIndex(this.CBE_PresetName, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Delete, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_OutPort, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Import, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Teach, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Edit, 0);
            this.gc_control.Controls.SetChildIndex(this.labelControl1, 0);
            // 
            // SCC
            // 
            this.SCC.Size = new System.Drawing.Size(937, 528);
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(40, 29);
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_Teach
            // 
            this.BT_Teach.Location = new System.Drawing.Point(149, 29);
            this.BT_Teach.Text = "添加";
            //this.BT_Teach.Click += new System.EventHandler(this.BT_Teach_Click);
            // 
            // BT_Import
            // 
            this.BT_Import.Location = new System.Drawing.Point(258, 29);
            this.BT_Import.Click += new System.EventHandler(this.BT_Import_Click);
            // 
            // BT_OutPort
            // 
            this.BT_OutPort.Location = new System.Drawing.Point(367, 29);
            this.BT_OutPort.Click += new System.EventHandler(this.BT_OutPort_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(476, 29);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 6;
            this.BT_Delete.Text = "删除";
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // CBE_PresetName
            // 
            this.CBE_PresetName.Location = new System.Drawing.Point(629, 30);
            this.CBE_PresetName.Name = "CBE_PresetName";
            this.CBE_PresetName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBE_PresetName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBE_PresetName.Size = new System.Drawing.Size(100, 20);
            this.CBE_PresetName.TabIndex = 7;
            this.CBE_PresetName.SelectedValueChanged += new System.EventHandler(this.CBE_PresetName_SelectedValueChanged);
            // 
            // LL_ReMark
            // 
            this.LL_ReMark.Location = new System.Drawing.Point(755, 34);
            this.LL_ReMark.Name = "LL_ReMark";
            this.LL_ReMark.Size = new System.Drawing.Size(52, 13);
            this.LL_ReMark.TabIndex = 8;
            this.LL_ReMark.Text = "工艺备注:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(573, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "工艺名:";
            // 
            // Frm_Preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 528);
            this.Name = "Frm_Preset";
            this.Text = "Frm_Preset";
            this.Load += new System.EventHandler(this.Frm_Preset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).EndInit();
            this.gc_control.ResumeLayout(false);
            this.gc_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).EndInit();
            this.SCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CBE_PresetName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BT_Delete;
        private DevExpress.XtraEditors.LabelControl LL_ReMark;
        private DevExpress.XtraEditors.ComboBoxEdit CBE_PresetName;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}