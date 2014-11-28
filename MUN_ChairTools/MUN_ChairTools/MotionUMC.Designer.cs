namespace MUN_ChairTools
{
    partial class MotionUMC
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
            this.comboBoxMotionCountry = new System.Windows.Forms.ComboBox();
            this.labelMotionCountry = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMotionCountry
            // 
            this.comboBoxMotionCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxMotionCountry.FormattingEnabled = true;
            this.comboBoxMotionCountry.Location = new System.Drawing.Point(114, 33);
            this.comboBoxMotionCountry.Name = "comboBoxMotionCountry";
            this.comboBoxMotionCountry.Size = new System.Drawing.Size(179, 36);
            this.comboBoxMotionCountry.TabIndex = 0;
            // 
            // labelMotionCountry
            // 
            this.labelMotionCountry.AutoSize = true;
            this.labelMotionCountry.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelMotionCountry.Location = new System.Drawing.Point(12, 36);
            this.labelMotionCountry.Name = "labelMotionCountry";
            this.labelMotionCountry.Size = new System.Drawing.Size(96, 28);
            this.labelMotionCountry.TabIndex = 1;
            this.labelMotionCountry.Text = "动议国：";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTime.Location = new System.Drawing.Point(12, 106);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 28);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "总时长：";
            // 
            // MotionUMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 183);
            this.ControlBox = false;
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMotionCountry);
            this.Controls.Add(this.comboBoxMotionCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MotionUMC";
            this.Text = "无主持核心磋商动议";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMotionCountry;
        private System.Windows.Forms.Label labelMotionCountry;
        private System.Windows.Forms.Label labelTime;
    }
}