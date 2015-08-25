namespace RobotPolish
{
    partial class Frm_Axis
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
            this.GC_7 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.R_T_DisEnable = new System.Windows.Forms.RadioButton();
            this.R_T_Enable = new System.Windows.Forms.RadioButton();
            this.NUD_Speed = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LL_TEnable = new DevExpress.XtraEditors.LabelControl();
            this.LL_Table = new DevExpress.XtraEditors.LabelControl();
            this.BT_T1 = new DevExpress.XtraEditors.SimpleButton();
            this.GC_8 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LL_MainEnable = new DevExpress.XtraEditors.LabelControl();
            this.LL_MainPower = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_DisablePower = new System.Windows.Forms.RadioButton();
            this.RB_EnablePower = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.R_M_DisEnable = new System.Windows.Forms.RadioButton();
            this.R_M_Enable = new System.Windows.Forms.RadioButton();
            this.GC_Sync7 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CE_Sync7 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ND_ATI = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.LL_ATI = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_ATICLOSE = new System.Windows.Forms.RadioButton();
            this.RB_ATIOPEN = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_7)).BeginInit();
            this.GC_7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_8)).BeginInit();
            this.GC_8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Sync7)).BeginInit();
            this.GC_Sync7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Sync7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ND_ATI)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_7
            // 
            this.GC_7.Controls.Add(this.groupBox7);
            this.GC_7.Controls.Add(this.NUD_Speed);
            this.GC_7.Controls.Add(this.pictureEdit1);
            this.GC_7.Controls.Add(this.labelControl1);
            this.GC_7.Controls.Add(this.groupBox4);
            this.GC_7.Location = new System.Drawing.Point(268, 13);
            this.GC_7.Name = "GC_7";
            this.GC_7.Size = new System.Drawing.Size(250, 392);
            this.GC_7.TabIndex = 0;
            this.GC_7.Text = "转台";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.R_T_DisEnable);
            this.groupBox7.Controls.Add(this.R_T_Enable);
            this.groupBox7.Location = new System.Drawing.Point(21, 289);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(217, 46);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            // 
            // R_T_DisEnable
            // 
            this.R_T_DisEnable.AutoSize = true;
            this.R_T_DisEnable.Location = new System.Drawing.Point(124, 20);
            this.R_T_DisEnable.Name = "R_T_DisEnable";
            this.R_T_DisEnable.Size = new System.Drawing.Size(73, 17);
            this.R_T_DisEnable.TabIndex = 42;
            this.R_T_DisEnable.TabStop = true;
            this.R_T_DisEnable.Text = "转台停止";
            this.R_T_DisEnable.UseVisualStyleBackColor = true;
            // 
            // R_T_Enable
            // 
            this.R_T_Enable.AutoSize = true;
            this.R_T_Enable.Location = new System.Drawing.Point(17, 22);
            this.R_T_Enable.Name = "R_T_Enable";
            this.R_T_Enable.Size = new System.Drawing.Size(73, 17);
            this.R_T_Enable.TabIndex = 41;
            this.R_T_Enable.TabStop = true;
            this.R_T_Enable.Text = "转台启动";
            this.R_T_Enable.UseVisualStyleBackColor = true;
            // 
            // NUD_Speed
            // 
            this.NUD_Speed.Location = new System.Drawing.Point(109, 352);
            this.NUD_Speed.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.NUD_Speed.Name = "NUD_Speed";
            this.NUD_Speed.Size = new System.Drawing.Size(92, 21);
            this.NUD_Speed.TabIndex = 34;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 357);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "转台速度:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LL_TEnable);
            this.groupBox4.Controls.Add(this.LL_Table);
            this.groupBox4.Location = new System.Drawing.Point(21, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 70);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "状态";
            // 
            // LL_TEnable
            // 
            this.LL_TEnable.Location = new System.Drawing.Point(11, 20);
            this.LL_TEnable.Name = "LL_TEnable";
            this.LL_TEnable.Size = new System.Drawing.Size(96, 13);
            this.LL_TEnable.TabIndex = 36;
            this.LL_TEnable.Text = "转台启动状态未知";
            // 
            // LL_Table
            // 
            this.LL_Table.Location = new System.Drawing.Point(11, 46);
            this.LL_Table.Name = "LL_Table";
            this.LL_Table.Size = new System.Drawing.Size(96, 13);
            this.LL_Table.TabIndex = 35;
            this.LL_Table.Text = "转台速度状态未知";
            // 
            // BT_T1
            // 
            this.BT_T1.Location = new System.Drawing.Point(319, 432);
            this.BT_T1.Name = "BT_T1";
            this.BT_T1.Size = new System.Drawing.Size(174, 51);
            this.BT_T1.TabIndex = 32;
            this.BT_T1.Text = "设置";
            this.BT_T1.Click += new System.EventHandler(this.BT_T1_Click);
            // 
            // GC_8
            // 
            this.GC_8.Controls.Add(this.groupBox5);
            this.GC_8.Controls.Add(this.groupBox2);
            this.GC_8.Controls.Add(this.pictureEdit2);
            this.GC_8.Controls.Add(this.groupBox1);
            this.GC_8.Location = new System.Drawing.Point(12, 13);
            this.GC_8.Name = "GC_8";
            this.GC_8.Size = new System.Drawing.Size(250, 392);
            this.GC_8.TabIndex = 1;
            this.GC_8.Tag = "";
            this.GC_8.Text = "主轴";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LL_MainEnable);
            this.groupBox5.Controls.Add(this.LL_MainPower);
            this.groupBox5.Location = new System.Drawing.Point(19, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 78);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "状态";
            // 
            // LL_MainEnable
            // 
            this.LL_MainEnable.Location = new System.Drawing.Point(6, 46);
            this.LL_MainEnable.Name = "LL_MainEnable";
            this.LL_MainEnable.Size = new System.Drawing.Size(96, 13);
            this.LL_MainEnable.TabIndex = 36;
            this.LL_MainEnable.Text = "主轴启动状态未知";
            // 
            // LL_MainPower
            // 
            this.LL_MainPower.Appearance.ForeColor = System.Drawing.Color.Red;
            this.LL_MainPower.Location = new System.Drawing.Point(6, 20);
            this.LL_MainPower.Name = "LL_MainPower";
            this.LL_MainPower.Size = new System.Drawing.Size(96, 13);
            this.LL_MainPower.TabIndex = 35;
            this.LL_MainPower.Text = "主轴上电状态未知";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_DisablePower);
            this.groupBox2.Controls.Add(this.RB_EnablePower);
            this.groupBox2.Location = new System.Drawing.Point(19, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 42);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // RB_DisablePower
            // 
            this.RB_DisablePower.AutoSize = true;
            this.RB_DisablePower.Location = new System.Drawing.Point(124, 14);
            this.RB_DisablePower.Name = "RB_DisablePower";
            this.RB_DisablePower.Size = new System.Drawing.Size(73, 17);
            this.RB_DisablePower.TabIndex = 42;
            this.RB_DisablePower.TabStop = true;
            this.RB_DisablePower.Text = "主轴下电";
            this.RB_DisablePower.UseVisualStyleBackColor = true;
            // 
            // RB_EnablePower
            // 
            this.RB_EnablePower.AutoSize = true;
            this.RB_EnablePower.Location = new System.Drawing.Point(17, 14);
            this.RB_EnablePower.Name = "RB_EnablePower";
            this.RB_EnablePower.Size = new System.Drawing.Size(73, 17);
            this.RB_EnablePower.TabIndex = 41;
            this.RB_EnablePower.TabStop = true;
            this.RB_EnablePower.Text = "主轴上电";
            this.RB_EnablePower.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.R_M_DisEnable);
            this.groupBox1.Controls.Add(this.R_M_Enable);
            this.groupBox1.Location = new System.Drawing.Point(19, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 46);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // R_M_DisEnable
            // 
            this.R_M_DisEnable.AutoSize = true;
            this.R_M_DisEnable.Location = new System.Drawing.Point(124, 20);
            this.R_M_DisEnable.Name = "R_M_DisEnable";
            this.R_M_DisEnable.Size = new System.Drawing.Size(73, 17);
            this.R_M_DisEnable.TabIndex = 42;
            this.R_M_DisEnable.TabStop = true;
            this.R_M_DisEnable.Text = "主轴停止";
            this.R_M_DisEnable.UseVisualStyleBackColor = true;
            // 
            // R_M_Enable
            // 
            this.R_M_Enable.AutoSize = true;
            this.R_M_Enable.Location = new System.Drawing.Point(17, 22);
            this.R_M_Enable.Name = "R_M_Enable";
            this.R_M_Enable.Size = new System.Drawing.Size(73, 17);
            this.R_M_Enable.TabIndex = 41;
            this.R_M_Enable.TabStop = true;
            this.R_M_Enable.Text = "主轴启动";
            this.R_M_Enable.UseVisualStyleBackColor = true;
            // 
            // GC_Sync7
            // 
            this.GC_Sync7.Controls.Add(this.textEdit1);
            this.GC_Sync7.Controls.Add(this.labelControl2);
            this.GC_Sync7.Controls.Add(this.CE_Sync7);
            this.GC_Sync7.Controls.Add(this.pictureEdit3);
            this.GC_Sync7.Enabled = false;
            this.GC_Sync7.Location = new System.Drawing.Point(780, 13);
            this.GC_Sync7.Name = "GC_Sync7";
            this.GC_Sync7.Size = new System.Drawing.Size(250, 392);
            this.GC_Sync7.TabIndex = 2;
            this.GC_Sync7.Text = "打磨头2";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = 0;
            this.textEdit1.Location = new System.Drawing.Point(82, 311);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(86, 20);
            this.textEdit1.TabIndex = 46;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 315);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 47;
            this.labelControl2.Text = "速度:";
            // 
            // CE_Sync7
            // 
            this.CE_Sync7.Location = new System.Drawing.Point(22, 347);
            this.CE_Sync7.Name = "CE_Sync7";
            this.CE_Sync7.Properties.Caption = "启用";
            this.CE_Sync7.Size = new System.Drawing.Size(75, 19);
            this.CE_Sync7.TabIndex = 45;
            this.CE_Sync7.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox8);
            this.groupControl1.Controls.Add(this.groupBox6);
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.pictureEdit4);
            this.groupControl1.Location = new System.Drawing.Point(524, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(250, 392);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "ATI";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ND_ATI);
            this.groupBox8.Controls.Add(this.labelControl3);
            this.groupBox8.Location = new System.Drawing.Point(20, 268);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(217, 67);
            this.groupBox8.TabIndex = 46;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "过压报警";
            // 
            // ND_ATI
            // 
            this.ND_ATI.Location = new System.Drawing.Point(85, 25);
            this.ND_ATI.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ND_ATI.Name = "ND_ATI";
            this.ND_ATI.Size = new System.Drawing.Size(92, 21);
            this.ND_ATI.TabIndex = 36;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "压力阀值:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.LL_ATI);
            this.groupBox6.Location = new System.Drawing.Point(19, 184);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(217, 78);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "状态";
            // 
            // LL_ATI
            // 
            this.LL_ATI.Location = new System.Drawing.Point(15, 33);
            this.LL_ATI.Name = "LL_ATI";
            this.LL_ATI.Size = new System.Drawing.Size(113, 13);
            this.LL_ATI.TabIndex = 35;
            this.LL_ATI.Text = "置零ATI数据状态未知";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_ATICLOSE);
            this.groupBox3.Controls.Add(this.RB_ATIOPEN);
            this.groupBox3.Location = new System.Drawing.Point(19, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 55);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            // 
            // RB_ATICLOSE
            // 
            this.RB_ATICLOSE.AutoSize = true;
            this.RB_ATICLOSE.Location = new System.Drawing.Point(118, 20);
            this.RB_ATICLOSE.Name = "RB_ATICLOSE";
            this.RB_ATICLOSE.Size = new System.Drawing.Size(102, 17);
            this.RB_ATICLOSE.TabIndex = 42;
            this.RB_ATICLOSE.TabStop = true;
            this.RB_ATICLOSE.Text = "置零ATI数据关";
            this.RB_ATICLOSE.UseVisualStyleBackColor = true;
            // 
            // RB_ATIOPEN
            // 
            this.RB_ATIOPEN.AutoSize = true;
            this.RB_ATIOPEN.Location = new System.Drawing.Point(15, 20);
            this.RB_ATIOPEN.Name = "RB_ATIOPEN";
            this.RB_ATIOPEN.Size = new System.Drawing.Size(102, 17);
            this.RB_ATIOPEN.TabIndex = 41;
            this.RB_ATIOPEN.TabStop = true;
            this.RB_ATIOPEN.Text = "置零ATI数据开";
            this.RB_ATIOPEN.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = global::RobotPolish.Properties.Resources.无标题;
            this.pictureEdit4.Location = new System.Drawing.Point(49, 62);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(160, 116);
            this.pictureEdit4.TabIndex = 40;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::RobotPolish.Properties.Resources.main1;
            this.pictureEdit3.Location = new System.Drawing.Point(19, 62);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(217, 116);
            this.pictureEdit3.TabIndex = 40;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::RobotPolish.Properties.Resources.FullSizeRender1;
            this.pictureEdit2.Location = new System.Drawing.Point(45, 24);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(134, 154);
            this.pictureEdit2.TabIndex = 40;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::RobotPolish.Properties.Resources._222631_12141364307991918_c478c3b92865a5c297baf8047ce7d3fc;
            this.pictureEdit1.Location = new System.Drawing.Point(21, 62);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(217, 116);
            this.pictureEdit1.TabIndex = 33;
            // 
            // Frm_Axis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 533);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GC_Sync7);
            this.Controls.Add(this.GC_8);
            this.Controls.Add(this.GC_7);
            this.Controls.Add(this.BT_T1);
            this.Name = "Frm_Axis";
            this.Text = "Frm_Config";
            ((System.ComponentModel.ISupportInitialize)(this.GC_7)).EndInit();
            this.GC_7.ResumeLayout(false);
            this.GC_7.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_8)).EndInit();
            this.GC_8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Sync7)).EndInit();
            this.GC_Sync7.ResumeLayout(false);
            this.GC_Sync7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Sync7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ND_ATI)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GC_7;
        private DevExpress.XtraEditors.GroupControl GC_8;
        private DevExpress.XtraEditors.SimpleButton BT_T1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.GroupControl GC_Sync7;
        private DevExpress.XtraEditors.CheckEdit CE_Sync7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.RadioButton R_M_Enable;
        private System.Windows.Forms.NumericUpDown NUD_Speed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_DisablePower;
        private System.Windows.Forms.RadioButton RB_EnablePower;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton R_M_DisEnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_ATICLOSE;
        private System.Windows.Forms.RadioButton RB_ATIOPEN;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl LL_Table;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.LabelControl LL_MainPower;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraEditors.LabelControl LL_ATI;
        private DevExpress.XtraEditors.LabelControl LL_MainEnable;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl LL_TEnable;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton R_T_DisEnable;
        private System.Windows.Forms.RadioButton R_T_Enable;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown ND_ATI;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}