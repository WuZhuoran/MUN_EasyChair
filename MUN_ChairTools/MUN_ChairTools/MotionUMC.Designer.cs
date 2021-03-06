﻿namespace MUN_ChairTools
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
            this.numericUpDownUMCTime = new System.Windows.Forms.NumericUpDown();
            this.labelSecond = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUMCTime)).BeginInit();
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
            this.labelTime.Location = new System.Drawing.Point(12, 87);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 28);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "总时长：";
            // 
            // numericUpDownUMCTime
            // 
            this.numericUpDownUMCTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDownUMCTime.Location = new System.Drawing.Point(114, 85);
            this.numericUpDownUMCTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownUMCTime.Name = "numericUpDownUMCTime";
            this.numericUpDownUMCTime.Size = new System.Drawing.Size(142, 35);
            this.numericUpDownUMCTime.TabIndex = 3;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelSecond.Location = new System.Drawing.Point(262, 87);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(33, 28);
            this.labelSecond.TabIndex = 4;
            this.labelSecond.Text = "秒";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(211, 136);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(91, 35);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "确定";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // MotionUMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 183);
            this.ControlBox = false;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.numericUpDownUMCTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMotionCountry);
            this.Controls.Add(this.comboBoxMotionCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MotionUMC";
            this.Text = "无主持核心磋商动议";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUMCTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMotionCountry;
        private System.Windows.Forms.Label labelMotionCountry;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown numericUpDownUMCTime;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
    }
}