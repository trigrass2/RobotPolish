namespace RobotPolish
{
    partial class Frm_DiffPreset
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
            this.BT_Z = new System.Windows.Forms.Button();
            this.BT_Diff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).BeginInit();
            this.gc_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).BeginInit();
            this.SCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_control
            // 
            this.gc_control.Controls.Add(this.BT_Diff);
            this.gc_control.Controls.Add(this.BT_Z);
            this.gc_control.Controls.SetChildIndex(this.BT_Z, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_OutPort, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Import, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Teach, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Edit, 0);
            this.gc_control.Controls.SetChildIndex(this.BT_Diff, 0);
            // 
            // BT_Edit
            // 
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_Teach
            // 
            this.BT_Teach.Click += new System.EventHandler(this.BT_Teach_Click);
            // 
            // BT_Import
            // 
            this.BT_Import.Visible = false;
            this.BT_Import.Click += new System.EventHandler(this.BT_Import_Click);
            // 
            // BT_OutPort
            // 
            this.BT_OutPort.Visible = false;
            this.BT_OutPort.Click += new System.EventHandler(this.BT_OutPort_Click);
            // 
            // BT_Z
            // 
            this.BT_Z.Location = new System.Drawing.Point(491, 29);
            this.BT_Z.Name = "BT_Z";
            this.BT_Z.Size = new System.Drawing.Size(75, 23);
            this.BT_Z.TabIndex = 6;
            this.BT_Z.Text = "Z轴变动";
            this.BT_Z.UseVisualStyleBackColor = true;
            this.BT_Z.Click += new System.EventHandler(this.BT_Z_Click);
            // 
            // BT_Diff
            // 
            this.BT_Diff.Location = new System.Drawing.Point(587, 29);
            this.BT_Diff.Name = "BT_Diff";
            this.BT_Diff.Size = new System.Drawing.Size(75, 23);
            this.BT_Diff.TabIndex = 7;
            this.BT_Diff.Text = "差分";
            this.BT_Diff.UseVisualStyleBackColor = true;
            this.BT_Diff.Click += new System.EventHandler(this.BT_Diff_Click);
            // 
            // Frm_DiffPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 528);
            this.Name = "Frm_DiffPreset";
            this.Text = "Frm_StaubliPreset";
            this.Load += new System.EventHandler(this.Frm_StaubliPreset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_control)).EndInit();
            this.gc_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCC)).EndInit();
            this.SCC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Z;
        private System.Windows.Forms.Button BT_Diff;
    }
}