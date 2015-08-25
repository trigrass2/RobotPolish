namespace RobotPolish
{
    partial class Frm_Gongyi
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
            this.PC_Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PC_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // PC_Box
            // 
            this.PC_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PC_Box.Image = global::RobotPolish.Properties.Resources._23;
            this.PC_Box.Location = new System.Drawing.Point(0, 0);
            this.PC_Box.Name = "PC_Box";
            this.PC_Box.Size = new System.Drawing.Size(341, 286);
            this.PC_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PC_Box.TabIndex = 0;
            this.PC_Box.TabStop = false;
            // 
            // Frm_Gongyi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 286);
            this.Controls.Add(this.PC_Box);
            this.Name = "Frm_Gongyi";
            this.Text = "Frm_Gongyi";
            ((System.ComponentModel.ISupportInitialize)(this.PC_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PC_Box;
    }
}